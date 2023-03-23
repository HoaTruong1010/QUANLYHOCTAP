
namespace QuanLyHocTap
{
    partial class Teaching
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
            this.btnExit = new System.Windows.Forms.Button();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.gbTeacherInfo = new System.Windows.Forms.GroupBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.lbTeacherName = new System.Windows.Forms.Label();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.lbTeacherID = new System.Windows.Forms.Label();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.lbRegisterDate = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.btnSearchTeaching = new System.Windows.Forms.Button();
            this.txtSearchTeaching = new System.Windows.Forms.TextBox();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvTeaching = new System.Windows.Forms.DataGridView();
            this.btAddTeaching = new System.Windows.Forms.Button();
            this.btnDeleteTeaching = new System.Windows.Forms.Button();
            this.btnSaveTeaching = new System.Windows.Forms.Button();
            this.gbItem.SuspendLayout();
            this.gbTeacherInfo.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeaching)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(1103, 564);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 48);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbItem
            // 
            this.gbItem.BackColor = System.Drawing.Color.Transparent;
            this.gbItem.Controls.Add(this.gbTeacherInfo);
            this.gbItem.Controls.Add(this.dtpRegisterDate);
            this.gbItem.Controls.Add(this.cbSubject);
            this.gbItem.Controls.Add(this.lbRegisterDate);
            this.gbItem.Controls.Add(this.lbSubject);
            this.gbItem.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItem.ForeColor = System.Drawing.Color.Maroon;
            this.gbItem.Location = new System.Drawing.Point(746, 85);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(442, 449);
            this.gbItem.TabIndex = 16;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Thông tin chi tiết";
            // 
            // gbTeacherInfo
            // 
            this.gbTeacherInfo.Controls.Add(this.txtTeacherName);
            this.gbTeacherInfo.Controls.Add(this.lbTeacherName);
            this.gbTeacherInfo.Controls.Add(this.txtTeacherID);
            this.gbTeacherInfo.Controls.Add(this.lbTeacherID);
            this.gbTeacherInfo.ForeColor = System.Drawing.Color.Maroon;
            this.gbTeacherInfo.Location = new System.Drawing.Point(24, 235);
            this.gbTeacherInfo.Name = "gbTeacherInfo";
            this.gbTeacherInfo.Size = new System.Drawing.Size(390, 190);
            this.gbTeacherInfo.TabIndex = 6;
            this.gbTeacherInfo.TabStop = false;
            this.gbTeacherInfo.Text = "Thông tin giảng viên";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Enabled = false;
            this.txtTeacherName.Location = new System.Drawing.Point(27, 136);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(324, 27);
            this.txtTeacherName.TabIndex = 22;
            // 
            // lbTeacherName
            // 
            this.lbTeacherName.AutoSize = true;
            this.lbTeacherName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacherName.Location = new System.Drawing.Point(23, 113);
            this.lbTeacherName.Name = "lbTeacherName";
            this.lbTeacherName.Size = new System.Drawing.Size(109, 20);
            this.lbTeacherName.TabIndex = 0;
            this.lbTeacherName.Text = "Họ và tên:";
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Enabled = false;
            this.txtTeacherID.Location = new System.Drawing.Point(27, 64);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(324, 27);
            this.txtTeacherID.TabIndex = 22;
            // 
            // lbTeacherID
            // 
            this.lbTeacherID.AutoSize = true;
            this.lbTeacherID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacherID.Location = new System.Drawing.Point(23, 41);
            this.lbTeacherID.Name = "lbTeacherID";
            this.lbTeacherID.Size = new System.Drawing.Size(179, 20);
            this.lbTeacherID.TabIndex = 0;
            this.lbTeacherID.Text = "Mã số giảng viên:";
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Enabled = false;
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegisterDate.Location = new System.Drawing.Point(51, 78);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(324, 27);
            this.dtpRegisterDate.TabIndex = 4;
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(51, 174);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(324, 28);
            this.cbSubject.TabIndex = 3;
            // 
            // lbRegisterDate
            // 
            this.lbRegisterDate.AutoSize = true;
            this.lbRegisterDate.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegisterDate.Location = new System.Drawing.Point(47, 39);
            this.lbRegisterDate.Name = "lbRegisterDate";
            this.lbRegisterDate.Size = new System.Drawing.Size(139, 20);
            this.lbRegisterDate.TabIndex = 0;
            this.lbRegisterDate.Text = "Ngày đăng ký:";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.Location = new System.Drawing.Point(47, 142);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(89, 20);
            this.lbSubject.TabIndex = 0;
            this.lbSubject.Text = "Môn học:";
            // 
            // btnSearchTeaching
            // 
            this.btnSearchTeaching.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnSearchTeaching.ForeColor = System.Drawing.Color.Maroon;
            this.btnSearchTeaching.Location = new System.Drawing.Point(735, 15);
            this.btnSearchTeaching.Name = "btnSearchTeaching";
            this.btnSearchTeaching.Size = new System.Drawing.Size(73, 48);
            this.btnSearchTeaching.TabIndex = 2;
            this.btnSearchTeaching.Text = "Tìm";
            this.btnSearchTeaching.UseVisualStyleBackColor = true;
            this.btnSearchTeaching.Click += new System.EventHandler(this.btnSearchTeaching_Click);
            // 
            // txtSearchTeaching
            // 
            this.txtSearchTeaching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchTeaching.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTeaching.Location = new System.Drawing.Point(316, 26);
            this.txtSearchTeaching.Name = "txtSearchTeaching";
            this.txtSearchTeaching.Size = new System.Drawing.Size(374, 28);
            this.txtSearchTeaching.TabIndex = 1;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.dgvTeaching);
            this.gbList.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.ForeColor = System.Drawing.Color.Maroon;
            this.gbList.Location = new System.Drawing.Point(12, 85);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(728, 566);
            this.gbList.TabIndex = 15;
            this.gbList.TabStop = false;
            this.gbList.Text = "Danh sách môn đã đăng ký";
            // 
            // dgvTeaching
            // 
            this.dgvTeaching.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvTeaching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeaching.GridColor = System.Drawing.Color.Teal;
            this.dgvTeaching.Location = new System.Drawing.Point(13, 39);
            this.dgvTeaching.Name = "dgvTeaching";
            this.dgvTeaching.RowHeadersWidth = 51;
            this.dgvTeaching.RowTemplate.Height = 24;
            this.dgvTeaching.Size = new System.Drawing.Size(703, 514);
            this.dgvTeaching.TabIndex = 0;
            this.dgvTeaching.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeaching_CellClick);
            // 
            // btAddTeaching
            // 
            this.btAddTeaching.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btAddTeaching.ForeColor = System.Drawing.Color.Maroon;
            this.btAddTeaching.Location = new System.Drawing.Point(759, 564);
            this.btAddTeaching.Name = "btAddTeaching";
            this.btAddTeaching.Size = new System.Drawing.Size(85, 48);
            this.btAddTeaching.TabIndex = 20;
            this.btAddTeaching.Text = "Thêm";
            this.btAddTeaching.UseVisualStyleBackColor = true;
            this.btAddTeaching.Click += new System.EventHandler(this.btAddTeaching_Click);
            // 
            // btnDeleteTeaching
            // 
            this.btnDeleteTeaching.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnDeleteTeaching.ForeColor = System.Drawing.Color.Maroon;
            this.btnDeleteTeaching.Location = new System.Drawing.Point(988, 564);
            this.btnDeleteTeaching.Name = "btnDeleteTeaching";
            this.btnDeleteTeaching.Size = new System.Drawing.Size(85, 48);
            this.btnDeleteTeaching.TabIndex = 21;
            this.btnDeleteTeaching.Text = "Xóa";
            this.btnDeleteTeaching.UseVisualStyleBackColor = true;
            this.btnDeleteTeaching.Click += new System.EventHandler(this.btnDeleteTeaching_Click);
            // 
            // btnSaveTeaching
            // 
            this.btnSaveTeaching.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.btnSaveTeaching.ForeColor = System.Drawing.Color.Maroon;
            this.btnSaveTeaching.Location = new System.Drawing.Point(874, 564);
            this.btnSaveTeaching.Name = "btnSaveTeaching";
            this.btnSaveTeaching.Size = new System.Drawing.Size(85, 48);
            this.btnSaveTeaching.TabIndex = 18;
            this.btnSaveTeaching.Text = "Lưu";
            this.btnSaveTeaching.UseVisualStyleBackColor = true;
            this.btnSaveTeaching.Click += new System.EventHandler(this.btnSaveTeaching_Click);
            // 
            // Teaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1223, 661);
            this.Controls.Add(this.btnSearchTeaching);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearchTeaching);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.btAddTeaching);
            this.Controls.Add(this.btnDeleteTeaching);
            this.Controls.Add(this.btnSaveTeaching);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Teaching";
            this.Text = "Giảng dạy";
            this.Load += new System.EventHandler(this.GiangDay_Load);
            this.Click += new System.EventHandler(this.Teaching_Click);
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.gbTeacherInfo.ResumeLayout(false);
            this.gbTeacherInfo.PerformLayout();
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeaching)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.Label lbRegisterDate;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Button btnSearchTeaching;
        private System.Windows.Forms.TextBox txtSearchTeaching;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgvTeaching;
        private System.Windows.Forms.Button btAddTeaching;
        private System.Windows.Forms.Button btnDeleteTeaching;
        private System.Windows.Forms.Button btnSaveTeaching;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.GroupBox gbTeacherInfo;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label lbTeacherName;
        private System.Windows.Forms.Label lbTeacherID;
    }
}