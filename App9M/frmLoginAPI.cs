using App9M.Data;
using App9M.Entity;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;
using App9M.Entity.Models;
using System.IO;

namespace App9M
{
    public partial class frmLoginAPI : Form
    {
        private iDataService ds;
        private DataContext dc;
        private int parameteId;

        private Dictionary<string, string?> currentReqHeaders = new();
        private bool isSave = false;
        public frmLoginAPI(iDataService dataService, DataContext dataContext)
        {
            ds = dataService;
            dc = dataContext;
            InitializeComponent();
        }

        private void frmLoginAPI_Load(object sender, EventArgs e)
        {
            loadDataServices();
        }

        private void frmLoginAPI_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = isSave ? DialogResult.OK : DialogResult.Cancel;
        }

        private void fillParameters()
        {
            foreach (var param in ds.parameters.ToList())
            {
                string finalValue = string.Empty;
                if (param.Type == "Static")
                {
                    finalValue = param.PathValue;
                }
                else if (param.Type == "Capture")
                {
                    if (param.Source == "Header")
                    {
                        var hdr = currentReqHeaders.Where(x => x.Key == param.PathValue).FirstOrDefault();
                        if (!string.IsNullOrEmpty(hdr.Key) && !string.IsNullOrEmpty(hdr.Value))
                            finalValue = hdr.Value;
                    }
                    else if (param.Source == "Body")
                    {
                        var respBody = txtRespBody.Text;
                        finalValue = ds.getValueFromJSONString(respBody, param.PathValue);
                    }
                }
                param.FinalValue = finalValue;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAPIUrl.Text) && !string.IsNullOrWhiteSpace(ds.BaseUrl) && cboReqType.SelectedItem != null)
            {
                string burl = ds.BaseUrl.EndsWith("/") ? ds.BaseUrl : ds.BaseUrl + "/";
                string pth = txtAPIUrl.Text.StartsWith("/") ? txtAPIUrl.Text.Substring(1) : txtAPIUrl.Text;
                string reqType = cboReqType?.SelectedItem?.ToString() ?? string.Empty;
                string body = txtReqText.Text;

                RestResponse? msg = ds.ExecuteRequest(reqType, burl, pth, body);
                currentReqHeaders = ds.GetHeadersFromMsg(msg);
                txtRespBody.Text = ds.GetRespBody(msg);

                ds.SetSettingValue("LoginReqType", reqType);
                ds.SetSettingValue("LoginUrl", pth);
                ds.SetSettingValue("LoginReqJson", body);
                ds.SetSettingValue("LoginRespJson", txtRespBody.Text);

                ds.refreshLoginUrl();
            }
        }
        private void loadDataServices()
        {
            ds.parameters = dc.tblParameters.Where(x=>x.urlId == 0 || x.urlId == null).ToList();
            if (ds.LoginUrl != null)
            {
                cboReqType.SelectedItem = ds.LoginUrl.ReqType;
                txtAPIUrl.Text = ds.LoginUrl.Url;
                txtReqText.Text = ds.LoginUrl.ReqJson;
                var rsp = dc.tblSettings.Where(x => x.Name == "LoginRespJson").FirstOrDefault();
                txtRespBody.Text = rsp != null ? rsp.Description : string.Empty;
            }
            bindGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboType.SelectedItem != null && cboSource.SelectedItem != null)
            {
                var type = cboType.SelectedItem.ToString();
                var source = cboSource.SelectedItem.ToString();

                source = (type == "Static") ? "---" : source;
                if (type == "Capture" && source == "---") return;

                tblParameters item;
                if (parameteId > 0)
                {
                    item = ds.parameters.Where(x => x.Id == parameteId).FirstOrDefault();
                }
                else
                {
                    item = ds.parameters.Where(x => x.Name == txtName.Text).FirstOrDefault();
                }
                if (item == null)
                {
                    ds.parameters.Add(
                        new Entity.Models.tblParameters
                        {
                            Id = parameteId,
                            Name = txtName.Text,
                            Type = type,
                            Source = source,
                            PathValue = txtPathValue.Text,
                            CreatedDate = DateTime.Now,
                            FinalValue = string.Empty,
                        }
                    );
                }
                else
                {
                    item.Id = parameteId;
                    item.Name = txtName.Text;
                    item.Type = type;
                    item.Source = source;
                    item.PathValue = txtPathValue.Text;
                    item.UpdatedDate = DateTime.Now;
                    item.FinalValue = string.Empty;
                }

                parameteId = 0;
                txtName.Text = string.Empty;
                cboType.SelectedIndex = -1;
                cboSource.SelectedIndex = -1;
                txtPathValue.Text = string.Empty;

                bindGrid();

            }
        }

        private void bindGrid()
        {
            if (ds.parameters != null && ds.parameters.Count > 0)
            {
                dgvParameters.DataSource = new BindingSource { DataSource = ds.parameters };
            }
        }

        private void dgvParameters_DoubleClick(object sender, EventArgs e)
        {

            var item = (Entity.Models.tblParameters)((DataGridView)sender).CurrentRow.DataBoundItem;

            parameteId = item.Id;
            txtName.Text = item.Name;
            cboType.SelectedItem = item.Type;
            cboSource.SelectedItem = item.Source;
            txtPathValue.Text = item.PathValue;
        }

        private void btnSaveNclose_Click(object sender, EventArgs e)
        {
            if (dc != null && dc.tblParameters != null)
            {
                fillParameters();
                dc.tblParameters.AddRange(ds.parameters.Where(x => x.Id == 0).ToList());
                dc.tblParameters.UpdateRange(ds.parameters.Where(x => x.Id != 0).ToList());
                dc.SaveChanges();
            }
            isSave = true;
            Close();
        }

        private void dgvParameters_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var item = (Entity.Models.tblParameters)e.Row.DataBoundItem;
            ds.parameters.Remove(item);
            if (item.Id > 0)
            {
                dc.tblParameters.Remove(item);
                dc.SaveChanges();
            }
        }

        private void cboReqType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var reqType = ((ComboBox)sender).SelectedItem.ToString();
            bool isGetOrDelete = reqType == "GET" || reqType == "DELETE";

            label3.Visible = !isGetOrDelete;
            txtReqText.Visible = !isGetOrDelete;

            txtRespBody.Height = isGetOrDelete ? 219 : 99;
            label4.Location = new Point(10, isGetOrDelete ? 350 : 470);
            txtRespBody.Location = new Point(10, isGetOrDelete ? 368 : 488);
        }
    }
}
