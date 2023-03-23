
namespace QuanLyHocTap
{
    partial class Teacher
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
            this.btnSaveTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.dtpTeacherDOB = new System.Windows.Forms.DateTimePicker();
            this.txtTeacherCCCD = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtTeacherPN = new System.Windows.Forms.TextBox();
            this.txtTeacherEmail = new System.Windows.Forms.TextBox();
            this.txtSearchTeacher = new System.Windows.Forms.TextBox();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.lbPN = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.cbbCertificate = new System.Windows.Forms.ComboBox();
            this.txtTeacherAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCer = new System.Windows.Forms.Label();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.btAddTeacher = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTeaching = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.gbItem.SuspendLayout();
            this.gbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveTeacher
            // 
            this.btnSaveTeacher.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTeacher.Location = new System.Drawing.Point(1490, 596);
            this.btnSaveTeacher.Name = "btnSaveTeacher";
            this.btnSaveTeacher.Size = new System.Drawing.Size(91, 50);
            this.btnSaveTeacher.TabIndex = 5;
            this.btnSaveTeacher.Text = "Lưu";
            this.btnSaveTeacher.UseVisualStyleBackColor = true;
            this.btnSaveTeacher.Click += new System.EventHandler(this.btnSaveTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeacher.Location = new System.Drawing.Point(1385, 596);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(89, 50);
            this.btnDeleteTeacher.TabIndex = 7;
            this.btnDeleteTeacher.Text = "Xóa";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // dtpTeacherDOB
            // 
            this.dtpTeacherDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTeacherDOB.Location = new System.Drawing.Point(279, 134);
            this.dtpTeacherDOB.Name = "dtpTeacherDOB";
            this.dtpTeacherDOB.Size = new System.Drawing.Size(360, 27);
            this.dtpTeacherDOB.TabIndex = 2;
            this.dtpTeacherDOB.DropDown += new System.EventHandler(this.dtpTeacherDOB_DropDown);
            // 
            // txtTeacherCCCD
            // 
            this.txtTeacherCCCD.Location = new System.Drawing.Point(279, 179);
            this.txtTeacherCCCD.Name = "txtTeacherCCCD";
            this.txtTeacherCCCD.Size = new System.Drawing.Size(360, 27);
            this.txtTeacherCCCD.TabIndex = 1;
            this.txtTeacherCCCD.Click += new System.EventHandler(this.txtTeacherCCCD_Click);
            this.txtTeacherCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeacherCCCD_KeyPress);
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(279, 90);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(360, 27);
            this.txtTeacherName.TabIndex = 1;
            this.txtTeacherName.Click += new System.EventHandler(this.txtTeacherName_Click);
            // 
            // txtTeacherPN
            // 
            this.txtTeacherPN.Location = new System.Drawing.Point(881, 86);
            this.txtTeacherPN.Name = "txtTeacherPN";
            this.txtTeacherPN.Size = new System.Drawing.Size(368, 27);
            this.txtTeacherPN.TabIndex = 1;
            this.txtTeacherPN.Click += new System.EventHandler(this.txtTeacherPN_Click);
            this.txtTeacherPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeacherCCCD_KeyPress);
            // 
            // txtTeacherEmail
            // 
            this.txtTeacherEmail.Location = new System.Drawing.Point(881, 44);
            this.txtTeacherEmail.Name = "txtTeacherEmail";
            this.txtTeacherEmail.Size = new System.Drawing.Size(368, 27);
            this.txtTeacherEmail.TabIndex = 1;
            this.txtTeacherEmail.Click += new System.EventHandler(this.txtTeacherEmail_Click);
            // 
            // txtSearchTeacher
            // 
            this.txtSearchTeacher.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTeacher.Location = new System.Drawing.Point(516, 30);
            this.txtSearchTeacher.Name = "txtSearchTeacher";
            this.txtSearchTeacher.Size = new System.Drawing.Size(411, 30);
            this.txtSearchTeacher.TabIndex = 1;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.GridColor = System.Drawing.Color.White;
            this.dgvTeacher.Location = new System.Drawing.Point(13, 78);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowHeadersWidth = 51;
            this.dgvTeacher.RowTemplate.Height = 24;
            this.dgvTeacher.Size = new System.Drawing.Size(1539, 374);
            this.dgvTeacher.TabIndex = 0;
            this.dgvTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacher_CellClick);
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(279, 44);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(360, 27);
            this.txtTeacherID.TabIndex = 1;
            // 
            // lbPN
            // 
            this.lbPN.AutoSize = true;
            this.lbPN.Location = new System.Drawing.Point(708, 93);
            this.lbPN.Name = "lbPN";
            this.lbPN.Size = new System.Drawing.Size(149, 20);
            this.lbPN.TabIndex = 0;
            this.lbPN.Text = "Số điện thoại:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(708, 51);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(69, 20);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Location = new System.Drawing.Point(38, 182);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(219, 20);
            this.lbCCCD.TabIndex = 0;
            this.lbCCCD.Text = "Số căn cước công dân:";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(38, 136);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(109, 20);
            this.lbDOB.TabIndex = 0;
            this.lbDOB.Text = "Ngày sinh:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(38, 93);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(189, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ tên giảng viên:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(38, 51);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(179, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã số giảng viên:";
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.cbbCertificate);
            this.gbItem.Controls.Add(this.dtpTeacherDOB);
            this.gbItem.Controls.Add(this.txtTeacherCCCD);
            this.gbItem.Controls.Add(this.txtTeacherName);
            this.gbItem.Controls.Add(this.txtTeacherAddress);
            this.gbItem.Controls.Add(this.txtTeacherPN);
            this.gbItem.Controls.Add(this.txtTeacherEmail);
            this.gbItem.Controls.Add(this.lbAddress);
            this.gbItem.Controls.Add(this.txtTeacherID);
            this.gbItem.Controls.Add(this.lbPN);
            this.gbItem.Controls.Add(this.lbCer);
            this.gbItem.Controls.Add(this.lbEmail);
            this.gbItem.Controls.Add(this.lbCCCD);
            this.gbItem.Controls.Add(this.lbDOB);
            this.gbItem.Controls.Add(this.lbName);
            this.gbItem.Controls.Add(this.lbID);
            this.gbItem.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItem.ForeColor = System.Drawing.Color.Maroon;
            this.gbItem.Location = new System.Drawing.Point(27, 497);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(1299, 233);
            this.gbItem.TabIndex = 4;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Thông tin chi tiết";
            // 
            // cbbCertificate
            // 
            this.cbbCertificate.FormattingEnabled = true;
            this.cbbCertificate.Items.AddRange(new object[] {
            "THAC SI",
            "TIEN SI",
            "PHO GIAO SU",
            "GIAO SU"});
            this.cbbCertificate.Location = new System.Drawing.Point(881, 178);
            this.cbbCertificate.Name = "cbbCertificate";
            this.cbbCertificate.Size = new System.Drawing.Size(368, 28);
            this.cbbCertificate.TabIndex = 3;
            this.cbbCertificate.Click += new System.EventHandler(this.cbbCertificate_Click);
            // 
            // txtTeacherAddress
            // 
            this.txtTeacherAddress.Location = new System.Drawing.Point(881, 125);
            this.txtTeacherAddress.Name = "txtTeacherAddress";
            this.txtTeacherAddress.Size = new System.Drawing.Size(368, 27);
            this.txtTeacherAddress.TabIndex = 1;
            this.txtTeacherAddress.Click += new System.EventHandler(this.txtTeacherAddress_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(708, 136);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(89, 20);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // lbCer
            // 
            this.lbCer.AutoSize = true;
            this.lbCer.Location = new System.Drawing.Point(708, 182);
            this.lbCer.Name = "lbCer";
            this.lbCer.Size = new System.Drawing.Size(79, 20);
            this.lbCer.TabIndex = 0;
            this.lbCer.Text = "Học vị:";
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnSearchTeacher);
            this.gbList.Controls.Add(this.txtSearchTeacher);
            this.gbList.Controls.Add(this.dgvTeacher);
            this.gbList.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.ForeColor = System.Drawing.Color.Maroon;
            this.gbList.Location = new System.Drawing.Point(29, 17);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(1569, 458);
            this.gbList.TabIndex = 3;
            this.gbList.TabStop = false;
            this.gbList.Text = "Danh sách";
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTeacher.Location = new System.Drawing.Point(967, 21);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(66, 48);
            this.btnSearchTeacher.TabIndex = 2;
            this.btnSearchTeacher.Text = "Tìm";
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // btAddTeacher
            // 
            this.btAddTeacher.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddTeacher.Location = new System.Drawing.Point(1385, 680);
            this.btAddTeacher.Name = "btAddTeacher";
            this.btAddTeacher.Size = new System.Drawing.Size(89, 50);
            this.btAddTeacher.TabIndex = 7;
            this.btAddTeacher.Text = "Thêm";
            this.btAddTeacher.UseVisualStyleBackColor = true;
            this.btAddTeacher.Click += new System.EventHandler(this.btAddTeacher_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1490, 680);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTeaching
            // 
            this.btnTeaching.Enabled = false;
            this.btnTeaching.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeaching.Location = new System.Drawing.Point(1385, 506);
            this.btnTeaching.Name = "btnTeaching";
            this.btnTeaching.Size = new System.Drawing.Size(196, 50);
            this.btnTeaching.TabIndex = 7;
            this.btnTeaching.Text = "Xem lịch dạy";
            this.btnTeaching.UseVisualStyleBackColor = true;
            this.btnTeaching.Click += new System.EventHandler(this.btnTeaching_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1623, 763);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveTeacher);
            this.Controls.Add(this.btnTeaching);
            this.Controls.Add(this.btAddTeacher);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbList);
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Giảng viên";
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.Click += new System.EventHandler(this.GiangVien_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.DateTimePicker dtpTeacherDOB;
        private System.Windows.Forms.TextBox txtTeacherCCCD;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtTeacherPN;
        private System.Windows.Forms.TextBox txtTeacherEmail;
        private System.Windows.Forms.TextBox txtSearchTeacher;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Label lbPN;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.TextBox txtTeacherAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbCer;
        private System.Windows.Forms.Button btAddTeacher;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTeaching;
        private System.Windows.Forms.ComboBox cbbCertificate;
        private System.Windows.Forms.Button btnSearchTeacher;
    }
}