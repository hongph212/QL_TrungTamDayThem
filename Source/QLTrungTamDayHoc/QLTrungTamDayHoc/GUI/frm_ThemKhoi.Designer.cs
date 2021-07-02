namespace QLTrungTamDayHoc
{
    partial class frm_ThemKhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemKhoi));
            this.txtHocPhi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.EditValue = "";
            this.txtHocPhi.EnterMoveNextControl = true;
            this.txtHocPhi.Location = new System.Drawing.Point(329, 112);
            this.txtHocPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtHocPhi.Properties.Appearance.Options.UseFont = true;
            this.txtHocPhi.Properties.MaxLength = 35;
            this.txtHocPhi.Properties.PasswordChar = '*';
            this.txtHocPhi.Properties.UseSystemPasswordChar = true;
            this.txtHocPhi.Size = new System.Drawing.Size(220, 28);
            this.txtHocPhi.TabIndex = 30;
            // 
            // txtTenKhoi
            // 
            this.txtTenKhoi.EditValue = "";
            this.txtTenKhoi.EnterMoveNextControl = true;
            this.txtTenKhoi.Location = new System.Drawing.Point(329, 46);
            this.txtTenKhoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhoi.Name = "txtTenKhoi";
            this.txtTenKhoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenKhoi.Properties.Appearance.Options.UseFont = true;
            this.txtTenKhoi.Properties.MaxLength = 20;
            this.txtTenKhoi.Size = new System.Drawing.Size(220, 28);
            this.txtTenKhoi.TabIndex = 28;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(222, 113);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 23);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Học phí:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(222, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 23);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Tên khối:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHuy.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.btnHuy.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseBackColor = true;
            this.btnHuy.Appearance.Options.UseBorderColor = true;
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(450, 290);
            this.btnHuy.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnHuy.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 46);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Hủy";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.btnThem.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseBorderColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(231, 290);
            this.btnThem.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnThem.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnThem.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnThem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 46);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLamMoi.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.btnLamMoi.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLamMoi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Appearance.Options.UseBackColor = true;
            this.btnLamMoi.Appearance.Options.UseBorderColor = true;
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.Appearance.Options.UseForeColor = true;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(12, 290);
            this.btnLamMoi.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.btnLamMoi.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.btnLamMoi.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnLamMoi.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(124, 46);
            this.btnLamMoi.TabIndex = 33;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // frm_ThemKhoi
            // 
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 354);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtHocPhi);
            this.Controls.Add(this.txtTenKhoi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_ThemKhoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khối";
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.TextEdit txtHocPhi;
        private DevExpress.XtraEditors.TextEdit txtTenKhoi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}