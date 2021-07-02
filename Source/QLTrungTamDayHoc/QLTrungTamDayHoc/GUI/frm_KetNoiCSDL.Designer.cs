namespace QLTrungTamDayHoc.GUI
{
    partial class frm_KetNoiCSDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KetNoiCSDL));
            this.rdbWindowsAuthentication = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoMoiDuLieuMau = new System.Windows.Forms.Button();
            this.rdbServerAuthentication = new System.Windows.Forms.RadioButton();
            this.grbDatabaseConnection = new System.Windows.Forms.GroupBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewDB = new System.Windows.Forms.TextBox();
            this.cmbDbName = new System.Windows.Forms.ComboBox();
            this.lblSelectDbName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckbRemeberPass = new System.Windows.Forms.CheckBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSyncStatus = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grbLogOn = new System.Windows.Forms.GroupBox();
            this.pnlConnectionInfo = new System.Windows.Forms.Panel();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1.SuspendLayout();
            this.grbDatabaseConnection.SuspendLayout();
            this.grbLogOn.SuspendLayout();
            this.pnlConnectionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbWindowsAuthentication
            // 
            this.rdbWindowsAuthentication.AutoSize = true;
            this.rdbWindowsAuthentication.Checked = true;
            this.rdbWindowsAuthentication.Location = new System.Drawing.Point(28, 22);
            this.rdbWindowsAuthentication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbWindowsAuthentication.Name = "rdbWindowsAuthentication";
            this.rdbWindowsAuthentication.Size = new System.Drawing.Size(256, 21);
            this.rdbWindowsAuthentication.TabIndex = 0;
            this.rdbWindowsAuthentication.TabStop = true;
            this.rdbWindowsAuthentication.Text = "Sử dụng chứng thực quyền Window";
            this.rdbWindowsAuthentication.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoMoiDuLieuMau);
            this.groupBox1.Location = new System.Drawing.Point(12, 549);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(441, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu mẫu";
            // 
            // btnTaoMoiDuLieuMau
            // 
            this.btnTaoMoiDuLieuMau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTaoMoiDuLieuMau.Enabled = false;
            this.btnTaoMoiDuLieuMau.Location = new System.Drawing.Point(12, 20);
            this.btnTaoMoiDuLieuMau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoMoiDuLieuMau.Name = "btnTaoMoiDuLieuMau";
            this.btnTaoMoiDuLieuMau.Size = new System.Drawing.Size(418, 28);
            this.btnTaoMoiDuLieuMau.TabIndex = 10;
            this.btnTaoMoiDuLieuMau.Text = "Tạo dữ liệu mẫu cho ứng dụng";
            this.btnTaoMoiDuLieuMau.UseVisualStyleBackColor = false;
            // 
            // rdbServerAuthentication
            // 
            this.rdbServerAuthentication.AutoSize = true;
            this.rdbServerAuthentication.Location = new System.Drawing.Point(28, 50);
            this.rdbServerAuthentication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbServerAuthentication.Name = "rdbServerAuthentication";
            this.rdbServerAuthentication.Size = new System.Drawing.Size(246, 21);
            this.rdbServerAuthentication.TabIndex = 1;
            this.rdbServerAuthentication.Text = "Sử dụng chứng thực quyền Server";
            this.rdbServerAuthentication.UseVisualStyleBackColor = true;
            // 
            // grbDatabaseConnection
            // 
            this.grbDatabaseConnection.Controls.Add(this.btnTaoMoi);
            this.grbDatabaseConnection.Controls.Add(this.label1);
            this.grbDatabaseConnection.Controls.Add(this.txtNewDB);
            this.grbDatabaseConnection.Controls.Add(this.cmbDbName);
            this.grbDatabaseConnection.Controls.Add(this.lblSelectDbName);
            this.grbDatabaseConnection.Location = new System.Drawing.Point(12, 445);
            this.grbDatabaseConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDatabaseConnection.Name = "grbDatabaseConnection";
            this.grbDatabaseConnection.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDatabaseConnection.Size = new System.Drawing.Size(441, 96);
            this.grbDatabaseConnection.TabIndex = 5;
            this.grbDatabaseConnection.TabStop = false;
            this.grbDatabaseConnection.Text = "Chọn database làm việc";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTaoMoi.Enabled = false;
            this.btnTaoMoi.Location = new System.Drawing.Point(349, 38);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(80, 37);
            this.btnTaoMoi.TabIndex = 8;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tạo mới cơ sở dữ liệu:";
            // 
            // txtNewDB
            // 
            this.txtNewDB.Enabled = false;
            this.txtNewDB.Location = new System.Drawing.Point(210, 47);
            this.txtNewDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewDB.Name = "txtNewDB";
            this.txtNewDB.Size = new System.Drawing.Size(133, 23);
            this.txtNewDB.TabIndex = 9;
            // 
            // cmbDbName
            // 
            this.cmbDbName.AllowDrop = true;
            this.cmbDbName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmbDbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDbName.Enabled = false;
            this.cmbDbName.FormattingEnabled = true;
            this.cmbDbName.Location = new System.Drawing.Point(12, 46);
            this.cmbDbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDbName.Name = "cmbDbName";
            this.cmbDbName.Size = new System.Drawing.Size(173, 24);
            this.cmbDbName.TabIndex = 1;
            // 
            // lblSelectDbName
            // 
            this.lblSelectDbName.AutoSize = true;
            this.lblSelectDbName.Location = new System.Drawing.Point(8, 26);
            this.lblSelectDbName.Name = "lblSelectDbName";
            this.lblSelectDbName.Size = new System.Drawing.Size(171, 17);
            this.lblSelectDbName.TabIndex = 0;
            this.lblSelectDbName.Text = "Chọn cơ sở dữ liệu có sẵn:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 113);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(312, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTestConnection.Location = new System.Drawing.Point(329, 145);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(100, 37);
            this.btnTestConnection.TabIndex = 6;
            this.btnTestConnection.Text = "Kết nối";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(117, 85);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(312, 23);
            this.txtUserName.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(42, 117);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(42, 89);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Tài khoản";
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(12, 130);
            this.cmbServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(275, 24);
            this.cmbServerName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.Location = new System.Drawing.Point(328, 620);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 37);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ckbRemeberPass
            // 
            this.ckbRemeberPass.AutoSize = true;
            this.ckbRemeberPass.Location = new System.Drawing.Point(117, 145);
            this.ckbRemeberPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbRemeberPass.Name = "ckbRemeberPass";
            this.ckbRemeberPass.Size = new System.Drawing.Size(117, 21);
            this.ckbRemeberPass.TabIndex = 7;
            this.ckbRemeberPass.Text = "Nhớ mật khẩu";
            this.ckbRemeberPass.UseVisualStyleBackColor = true;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(37, 138);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(96, 17);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "Server Name :";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOK.Location = new System.Drawing.Point(194, 620);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(126, 37);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Lưu cấu hình";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // lblSyncStatus
            // 
            this.lblSyncStatus.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblSyncStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSyncStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyncStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblSyncStatus.Image")));
            this.lblSyncStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSyncStatus.Location = new System.Drawing.Point(251, 0);
            this.lblSyncStatus.Name = "lblSyncStatus";
            this.lblSyncStatus.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSyncStatus.Size = new System.Drawing.Size(211, 26);
            this.lblSyncStatus.TabIndex = 21;
            this.lblSyncStatus.Text = "Đang tìm máy chủ...";
            this.lblSyncStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.Location = new System.Drawing.Point(293, 123);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 37);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Tìm trong mạng";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grbLogOn
            // 
            this.grbLogOn.Controls.Add(this.ckbRemeberPass);
            this.grbLogOn.Controls.Add(this.txtPassword);
            this.grbLogOn.Controls.Add(this.btnTestConnection);
            this.grbLogOn.Controls.Add(this.txtUserName);
            this.grbLogOn.Controls.Add(this.lblPassword);
            this.grbLogOn.Controls.Add(this.lblUserName);
            this.grbLogOn.Controls.Add(this.rdbServerAuthentication);
            this.grbLogOn.Controls.Add(this.rdbWindowsAuthentication);
            this.grbLogOn.Location = new System.Drawing.Point(12, 249);
            this.grbLogOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbLogOn.Name = "grbLogOn";
            this.grbLogOn.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbLogOn.Size = new System.Drawing.Size(441, 188);
            this.grbLogOn.TabIndex = 4;
            this.grbLogOn.TabStop = false;
            this.grbLogOn.Text = "Đăng nhập vào Server";
            // 
            // pnlConnectionInfo
            // 
            this.pnlConnectionInfo.BackColor = System.Drawing.Color.Azure;
            this.pnlConnectionInfo.Controls.Add(this.panelControl1);
            this.pnlConnectionInfo.Controls.Add(this.groupBox1);
            this.pnlConnectionInfo.Controls.Add(this.grbDatabaseConnection);
            this.pnlConnectionInfo.Controls.Add(this.btnCancel);
            this.pnlConnectionInfo.Controls.Add(this.lblServerName);
            this.pnlConnectionInfo.Controls.Add(this.btnOK);
            this.pnlConnectionInfo.Controls.Add(this.grbLogOn);
            this.pnlConnectionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConnectionInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlConnectionInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlConnectionInfo.Name = "pnlConnectionInfo";
            this.pnlConnectionInfo.Size = new System.Drawing.Size(467, 670);
            this.pnlConnectionInfo.TabIndex = 20;
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.BackColor = System.Drawing.Color.Azure;
            this.lblDataSource.Location = new System.Drawing.Point(9, 14);
            this.lblDataSource.MaximumSize = new System.Drawing.Size(421, 112);
            this.lblDataSource.MinimumSize = new System.Drawing.Size(421, 112);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(421, 112);
            this.lblDataSource.TabIndex = 0;
            this.lblDataSource.Text = resources.GetString("lblDataSource.Text");
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Azure;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblDataSource);
            this.panelControl1.Controls.Add(this.cmbServerName);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Location = new System.Drawing.Point(12, 69);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Azure;
            this.panelControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Azure;
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(442, 173);
            this.panelControl1.TabIndex = 10;
            // 
            // frm_KetNoiCSDL
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 670);
            this.Controls.Add(this.lblSyncStatus);
            this.Controls.Add(this.pnlConnectionInfo);
            this.Name = "frm_KetNoiCSDL";
            this.Text = "Kết Nối CSDL";
            this.groupBox1.ResumeLayout(false);
            this.grbDatabaseConnection.ResumeLayout(false);
            this.grbDatabaseConnection.PerformLayout();
            this.grbLogOn.ResumeLayout(false);
            this.grbLogOn.PerformLayout();
            this.pnlConnectionInfo.ResumeLayout(false);
            this.pnlConnectionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbWindowsAuthentication;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoMoiDuLieuMau;
        private System.Windows.Forms.RadioButton rdbServerAuthentication;
        private System.Windows.Forms.GroupBox grbDatabaseConnection;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewDB;
        private System.Windows.Forms.ComboBox cmbDbName;
        private System.Windows.Forms.Label lblSelectDbName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckbRemeberPass;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSyncStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grbLogOn;
        private System.Windows.Forms.Panel pnlConnectionInfo;
        private System.Windows.Forms.Label lblDataSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}