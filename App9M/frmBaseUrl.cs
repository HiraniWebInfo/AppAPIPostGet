using App9M.Data;
using App9M.Entity;

namespace App9M
{
    public partial class frmBaseUrl : Form
    {
        private readonly iDataService ds;
        private readonly DataContext dc;
        public frmBaseUrl(iDataService _dataService, DataContext _dataContext)
        {
            ds = _dataService;
            dc = _dataContext;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ds.BaseUrl = txtBaseUrl.Text;

            var baseUrlSetting = dc.tblSettings.Where(x => x.Name == "BaseUrl").FirstOrDefault();

            if (baseUrlSetting != null)
            {
                baseUrlSetting.Description = txtBaseUrl.Text;
                baseUrlSetting.UpdatedDate = DateTime.Now;
                dc.tblSettings.Update(baseUrlSetting);
            }
            else
            {
                dc.tblSettings.Add(new Entity.Models.tblSettings
                {
                    Name = "BaseUrl",
                    Description = txtBaseUrl.Text,
                    CreatedDate = DateTime.Now,
                });
            }

            dc.SaveChanges();

            DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmBaseUrl_Load(object sender, EventArgs e)
        {
            if(dc.tblSettings.Where(x => x.Name == "BaseUrl").Any())
            {
                ds.BaseUrl = dc.tblSettings.Where(x => x.Name == "BaseUrl").First().Description;
                txtBaseUrl.Text = ds.BaseUrl;
            }
        }
    }
}
