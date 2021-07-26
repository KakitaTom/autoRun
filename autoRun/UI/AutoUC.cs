using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainModule.Interface;
using MainModule.Service;

namespace autoRun.UI
{
    public partial class AutoUC : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly IUrlService _urlService;

        public AutoUC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _urlService = new UrlService();

            DataURL_Load();
        }

        public void DataURL_Load()
        {
            gcUrlRun.DataSource = _urlService.GetList_Url();
        }

        public void DataDetail_Load()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
