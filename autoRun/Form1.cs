using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using autoRun.Common;
using autoRun.UI;
using MainModule.Interface;
using MainModule.Service;

namespace autoRun
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public readonly IUrlService _urlService;
        
        public Form1()
        {
            InitializeComponent();
            _urlService = new UrlService();
            ThreadCommon.ThreadStart(_urlService.GetList_UrlWithActiveStatus());
        }

        private void btnAutoRun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            var frm = new AutoRunUC(){ Dock = DockStyle.Fill};

            pnMain.Controls.Add(frm);
            frm.Show();
        }
    }
}
