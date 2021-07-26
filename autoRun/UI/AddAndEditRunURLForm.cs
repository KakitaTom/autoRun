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
using MainModule.ModelViews;
using MainModule.Service;

namespace autoRun.UI
{
    public partial class AddAndEditRunURLForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IUrlService _urlService;
        private UrlRunView _urlRunView;
        private bool _isAdd;
        private string confirmString;

        public AddAndEditRunURLForm()
        {
            InitializeComponent();
            gbAE.Text = "Thêm mới một Url";
            confirmString = "thêm mới";
            _urlService = new UrlService();
            _isAdd = true;
        }

        public AddAndEditRunURLForm(UrlRunView editedUrl)
        {
            InitializeComponent();
            _urlService = new UrlService();
            _urlRunView = new UrlRunView();
            _isAdd = false;

            _urlRunView.Id = editedUrl.Id;
            _urlRunView.Name = editedUrl.Name;
            _urlRunView.IsActive = editedUrl.IsActive;
            _urlRunView.TimeDeley= editedUrl.TimeDeley;
            _urlRunView.Url = editedUrl.Url;

            gbAE.Text = "Chỉnh sửa một Url";
            confirmString = "chỉnh sửa";
            tbName.Text = _urlRunView.Name;
            nbrTime.Text = _urlRunView.TimeDeley.ToString();
            tbUrl.Text = _urlRunView.Url;
            cbActive.Checked = (bool)_urlRunView.IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            var confirmResult = MessageBox.Show("Bạn có chắc muốn" + confirmString + "Url này không?",
                "Confirm Save!!",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
                return;

            var newUrl = new UrlRunView()
            {
                Name = tbName.Text,
                Url = tbUrl.Text,
                TimeDeley = (int)nbrTime.Value,
                IsActive = cbActive.Checked == true
            };

            if (_isAdd)
            {
                var result = _urlService.Add(newUrl);

                if (result == 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    this.Close();
                    return;
                }
                MessageBox.Show("Trùng Url đã có vui lòng kiểm tra lại");
            }
            else
            {
                newUrl.Id = _urlRunView.Id;

                var result = _urlService.Edit(newUrl);

                switch (result)
                {
                    case 0:
                        MessageBox.Show("Chỉnh sửa thành công thành công");
                        this.Close();
                        break;
                    case 1:
                        MessageBox.Show("Đã tồn tại Url vừa sử vui lòng kiểm tra lại");
                        break;
                    case 2:
                        MessageBox.Show("Url bạn muốn sửa không tồn tại");
                        break;
                    default:
                        break;
                }
            }
        }

        private bool Validate()
        {
            if ((int) nbrTime.Value <= 0)
            {
                MessageBox.Show("Thời gian run không được <= 0");
                return false;
            }

            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Không được để trống tên Url");
                return false;
            }

            if (String.IsNullOrWhiteSpace(tbUrl.Text))
            {
                MessageBox.Show("Không được để trống Url");
                return false;
            }

            return true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}