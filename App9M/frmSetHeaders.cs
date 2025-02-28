using App9M.Data;
using App9M.Entity;
using App9M.Entity.Models;

namespace App9M
{
    public partial class frmSetHeaders : Form
    {
        private iDataService ds;
        private DataContext dc;
        private int headerId = 0;
        public frmSetHeaders(iDataService _dataService, DataContext dataContext)
        {
            ds = _dataService;
            dc = dataContext;
            InitializeComponent();
        }

        private void dgvHeaders_DoubleClick(object sender, EventArgs e)
        {
            var item = (tblHeaders)((DataGridView)sender).CurrentRow.DataBoundItem;

            headerId = item.Id;
            txtHeader.Text = item.HeaderKey;
            txtValue.Text = item.HeaderValue;
        }

        private void dgvHeaders_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var item = (tblHeaders)e.Row.DataBoundItem;
            ds.headers.Remove(item);
            if (item.Id > 0)
            {
                dc.tblHeaders.Remove(item);
                dc.SaveChanges();
            }
        }

        private void frmSetHeaders_Load(object sender, EventArgs e)
        {
            ds.headers = dc.tblHeaders.Where(x => x.urlId == 0 || x.urlId == null).ToList();
            ds.parameters = dc.tblParameters.Where(x => x.urlId == 0 || x.urlId == null).ToList();

            lstDynVariables.Items.Clear();
            var names = ds.parameters.Select(x => x.Name).ToArray();
            if(names!= null && names.Length>0)
                lstDynVariables.Items.AddRange(names);
            
            refreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var hdr = ds.headers.Where(h => h.HeaderKey == txtHeader.Text).FirstOrDefault();
            if (hdr == null)
                ds.headers.Add(new tblHeaders {Id=0, HeaderKey = txtHeader.Text, HeaderValue = txtValue.Text ,urlId = 0});
            else
            {
                hdr.HeaderValue = txtValue.Text;
                hdr.urlId = 0;
                hdr.Id = headerId;
            }    
            refreshGrid();
            txtHeader.Text = string.Empty;
            txtValue.Text = string.Empty;
            headerId = 0;
        }

        private void btnSaveNClose_Click(object sender, EventArgs e)
        {
            foreach (var th in dc.tblHeaders.ToList())
            {
                var h = ds.headers.FirstOrDefault(x => x.HeaderKey == th.HeaderKey && (x.urlId == 0 || x.urlId == null));
                if (h == null)
                {
                    dc.tblHeaders.Remove(th);
                }
            }

            foreach (var header in ds.headers)
            {
                var item = dc.tblHeaders.FirstOrDefault(x => x.HeaderKey == header.HeaderKey && (x.urlId == 0 || x.urlId == null));
                if (item == null)
                {
                    dc.tblHeaders.Add(new tblHeaders
                    {
                        HeaderKey = header.HeaderKey,
                        HeaderValue = header.HeaderValue,
                        HeaderFinalValue = ds.GetFinalValue(header.HeaderValue)
                    });
                }
                else
                {
                    item.HeaderValue = header.HeaderValue;
                    item.HeaderFinalValue = ds.GetFinalValue(header.HeaderValue);
                    dc.Update(item);
                }
            }

            dc.SaveChanges();
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ds.headers = new List<tblHeaders>();
            Close();
        }

        private void lstDynVariables_DoubleClick(object sender, EventArgs e)
        {
            txtValue.Text += $"«{((ListBox)sender).SelectedItem}»";
        }
        private void refreshGrid()
        {
            if (ds.headers.Count > 0)
                dgvHeaders.DataSource = 
                    new BindingSource
                    {
                        DataSource = ds.headers.ToList()
                    };
        }
    }
}
