using App9M.Data;
using App9M.Entity;
using RestSharp;
using System.Net;

namespace App9M
{
    public partial class frmMain9M : Form
    {
        private iDataService ds;
        private DataContext dc;

        private frmBaseUrl FrmBaseUrl;
        private frmLoginAPI FrmLoginAPI;
        private Dictionary<string, string?> currentReqHeaders = new();
        private frmSetHeaders frmSetHeaders;

        public frmMain9M(iDataService _dataService, DataContext dataContext,
            frmBaseUrl _FrmBaseUrl, frmLoginAPI _FrmLoginAPI, frmSetHeaders _FrmSetHeaders
            )
        {
            ds = _dataService;
            dc = dataContext;
            FrmBaseUrl = _FrmBaseUrl;
            FrmLoginAPI = _FrmLoginAPI;
            frmSetHeaders = _FrmSetHeaders;
            InitializeComponent();
        }

        private void frmMain9M_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ds.BaseUrl))
            {
                if (FrmBaseUrl.ShowDialog(this) == DialogResult.Cancel)
                {
                    Close();
                }
                else
                {
                    loadDataServices();
                }
            }
        }

        private void lstAPI_DoubleClick(object sender, EventArgs e)
        {
            var sItem = ((ListBox)sender).SelectedItem.ToString();
            if (!string.IsNullOrEmpty(sItem))
            {
                var uItem = dc.tblUrlList.Where(u => u.Name == sItem).FirstOrDefault();
                if (uItem != null)
                {
                    cboReqType.SelectedItem = uItem.ReqType;
                    txtAPIUrl.Text = uItem.Url;
                    txtReqText.Text = uItem.ReqJson;

                    //Global headers
                    //Url specific headers

                    //Global params
                    //Url Specific params
                }
            }
        }

        private void frmMain9M_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Save pending changes and sanity
        }

        private void btnSetBaseUrl_Click(object sender, EventArgs e)
        {
            FrmBaseUrl.ShowDialog(this);
        }
        private void loadDataServices()
        {
            ds.BaseUrl = dc.tblSettings.Where(x => x.Name == "BaseUrl").First().Description;
        }

        private void btnSetLoginApi_Click(object sender, EventArgs e)
        {
            FrmLoginAPI.ShowDialog(this);
        }

        private void btnSetRefreshAPI_Click(object sender, EventArgs e)
        {

        }

        private void cboReqType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var reqType = ((ComboBox)sender).SelectedItem.ToString();
            bool isGetOrDelete = reqType == "GET" || reqType == "DELETE";
            txtReqText.ReadOnly = isGetOrDelete;
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
                if (msg != null && msg.ResponseStatus == ResponseStatus.Completed)
                {
                    if (msg.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        //perform refresh
                        //if refresh fail
                        //perform login
                    }
                    else if ((int)msg.StatusCode >= 200 && (int)msg.StatusCode <= 299)
                    {
                        currentReqHeaders = ds.GetHeadersFromMsg(msg);
                        txtRespBody.Text = ds.GetRespBody(msg);
                    }

                }
            }
        }

        private void btnSetHeaders_Click(object sender, EventArgs e)
        {
            frmSetHeaders.ShowDialog(this);
        }
    }
}
