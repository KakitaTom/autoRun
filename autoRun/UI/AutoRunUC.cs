using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using autoRun.Common;
using MainModule.Interface;
using MainModule.Service;
using MainModule.ModelViews;
using Task = System.Threading.Tasks.Task;

namespace autoRun.UI
{
    public partial class AutoRunUC : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IUrlService _urlService;

        public AutoRunUC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            gbAuto.Controls.AddRange(new Control[]
            {
                btnAdd, btnEdit, btnDelete, btnStatusChange, gcUrlRun, gcRunDetail
            });
            _urlService = new UrlService();
            
            DataURL_Load();
            DataDetail_Load();
        }

        public void DataURL_Load()
        {
            gcUrlRun.DataSource = _urlService.GetList_Url();
        }

        public void DataDetail_Load()
        {
            var id = gvUrlRun.GetFocusedRowCellValue("Id") == null ? 0 : (int)gvUrlRun.GetFocusedRowCellValue("Id");
            gcRunDetail.DataSource = _urlService.GetList_RunDetail(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new AddAndEditRunURLForm())
            {
                frm.ShowDialog();
            }

            ThreadCommon.ThreadStop();
            ThreadCommon.ThreadStart(_urlService.GetList_UrlWithActiveStatus());

            DataURL_Load();
            DataDetail_Load();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ThreadCommon.ThreadStop();
            var editedUrl = new UrlRunView();
            editedUrl.Id = (int)gvUrlRun.GetFocusedRowCellValue("Id");
            editedUrl.Name = gvUrlRun.GetFocusedRowCellValue("Name") == null ? "" : gvUrlRun.GetFocusedRowCellValue("Name").ToString();
            editedUrl.TimeDeley = (int)gvUrlRun.GetFocusedRowCellValue("TimeDeley");
            editedUrl.Url = gvUrlRun.GetFocusedRowCellValue("Url") == null ? "" : gvUrlRun.GetFocusedRowCellValue("Url").ToString();
            editedUrl.IsActive = (bool)gvUrlRun.GetFocusedRowCellValue("IsActive");
            
            using (var frm = new AddAndEditRunURLForm(editedUrl))
            {
                ThreadCommon.ThreadStart(_urlService.GetList_UrlWithEditUrl(editedUrl.Id));
                frm.ShowDialog();
                ThreadCommon.ThreadStop();
            }

            ThreadCommon.ThreadStart(_urlService.GetList_UrlWithActiveStatus());

            DataURL_Load();
            DataDetail_Load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = (int)gvUrlRun.GetFocusedRowCellValue("Id");

            var confirmResult = MessageBox.Show("Bạn có chắc sẽ xoá Url này không?",
                "Confirm Delete!",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
                return;

            _urlService.Delete(id);

            ThreadCommon.ThreadStop();
            ThreadCommon.ThreadStart(_urlService.GetList_UrlWithActiveStatus());

            DataURL_Load();
            DataDetail_Load();
        }

        private void btnStatusChange_Click(object sender, EventArgs e)
        {
            var id = (int)gvUrlRun.GetFocusedRowCellValue("Id");

            var confirmResult = MessageBox.Show("Bạn có chắc đổi trạng thái Url này không?",
                "Confirm Lock/Unlock!!",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
                return;

            _urlService.ChangeStatus(id);

            ThreadCommon.ThreadStop();
            ThreadCommon.ThreadStart(_urlService.GetList_UrlWithActiveStatus());

            DataURL_Load();
            DataDetail_Load();
        }

        private void gvUrlRun_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataDetail_Load();
        }

        private void AutoRunUC_Load(object sender, EventArgs e)
        {
            ThreadCommon.ThreadStart(_urlService.GetList_UrlWithActiveStatus());
        }
    }
}
