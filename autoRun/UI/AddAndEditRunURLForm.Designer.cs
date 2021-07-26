
namespace autoRun.UI
{
    partial class AddAndEditRunURLForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditRunURLForm));
            this.gbAE = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nbrTime = new System.Windows.Forms.NumericUpDown();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.tbUrl = new DevExpress.XtraEditors.TextEdit();
            this.gbAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUrl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAE
            // 
            this.gbAE.Controls.Add(this.tbUrl);
            this.gbAE.Controls.Add(this.tbName);
            this.gbAE.Controls.Add(this.btnCancel);
            this.gbAE.Controls.Add(this.btnSave);
            this.gbAE.Controls.Add(this.cbActive);
            this.gbAE.Controls.Add(this.nbrTime);
            this.gbAE.Controls.Add(this.label4);
            this.gbAE.Controls.Add(this.label3);
            this.gbAE.Controls.Add(this.label2);
            this.gbAE.Controls.Add(this.label1);
            this.gbAE.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAE.ForeColor = System.Drawing.Color.Red;
            this.gbAE.Location = new System.Drawing.Point(12, 12);
            this.gbAE.Name = "gbAE";
            this.gbAE.Size = new System.Drawing.Size(382, 278);
            this.gbAE.TabIndex = 0;
            this.gbAE.TabStop = false;
            this.gbAE.Text = "Group Box Chung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Url:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(222, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tính bằng giây";
            // 
            // nbrTime
            // 
            this.nbrTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrTime.Location = new System.Drawing.Point(100, 135);
            this.nbrTime.Name = "nbrTime";
            this.nbrTime.Size = new System.Drawing.Size(106, 27);
            this.nbrTime.TabIndex = 5;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.ForeColor = System.Drawing.Color.Black;
            this.cbActive.Location = new System.Drawing.Point(100, 178);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(102, 23);
            this.cbActive.TabIndex = 6;
            this.cbActive.Text = "Hoạt động";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(261, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(16, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 49);
            this.tbName.Name = "tbName";
            this.tbName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Properties.Appearance.Options.UseFont = true;
            this.tbName.Size = new System.Drawing.Size(261, 26);
            this.tbName.TabIndex = 9;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(100, 92);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Properties.Appearance.Options.UseFont = true;
            this.tbUrl.Size = new System.Drawing.Size(261, 26);
            this.tbUrl.TabIndex = 10;
            // 
            // AddAndEditRunURLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 299);
            this.Controls.Add(this.gbAE);
            this.Name = "AddAndEditRunURLForm";
            this.Text = "AddAndEditRunURLForm";
            this.gbAE.ResumeLayout(false);
            this.gbAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUrl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAE;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.NumericUpDown nbrTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit tbUrl;
        private DevExpress.XtraEditors.TextEdit tbName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}