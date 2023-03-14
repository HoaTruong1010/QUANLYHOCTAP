
namespace QuanLyHocTap
{
    partial class GiangDay
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
            this.cbbTeacher = new System.Windows.Forms.ComboBox();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.txtTeachingID = new System.Windows.Forms.TextBox();
            this.lbRegisterDate = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSearchTeaching = new System.Windows.Forms.Button();
            this.txtSearchTeaching = new System.Windows.Forms.TextBox();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvTeaching = new System.Windows.Forms.DataGridView();
            this.btAddTeaching = new System.Windows.Forms.Button();
            this.btnDeleteTeaching = new System.Windows.Forms.Button();
            this.btnSaveTeaching = new System.Windows.Forms.Button();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.gbItem.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeaching)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1073, 677);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 48);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // cbbTeacher
            // 
            this.cbbTeacher.FormattingEnabled = true;
            this.cbbTeacher.Location = new System.Drawing.Point(764, 83);
            this.cbbTeacher.Name = "cbbTeacher";
            this.cbbTeacher.Size = new System.Drawing.Size(273, 32);
            this.cbbTeacher.TabIndex = 3;
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Location = new System.Drawing.Point(571, 92);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(161, 24);
            this.lbTeacher.TabIndex = 0;
            this.lbTeacher.Text = "Giảng viên phụ trách:";
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.dtpRegisterDate);
            this.gbItem.Controls.Add(this.cbSubject);
            this.gbItem.Controls.Add(this.cbbTeacher);
            this.gbItem.Controls.Add(this.txtTeachingID);
            this.gbItem.Controls.Add(this.lbTeacher);
            this.gbItem.Controls.Add(this.lbRegisterDate);
            this.gbItem.Controls.Add(this.lbSubject);
            this.gbItem.Controls.Add(this.lbID);
            this.gbItem.Font = new System.Drawing.Font("iCiel Cucho", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItem.ForeColor = System.Drawing.Color.Maroon;
            this.gbItem.Location = new System.Drawing.Point(26, 514);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(1132, 139);
            this.gbItem.TabIndex = 16;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Thông tin chi tiết";
            // 
            // txtTeachingID
            // 
            this.txtTeachingID.Location = new System.Drawing.Point(199, 40);
            this.txtTeachingID.Name = "txtTeachingID";
            this.txtTeachingID.Size = new System.Drawing.Size(290, 25);
            this.txtTeachingID.TabIndex = 1;
            // 
            // lbRegisterDate
            // 
            this.lbRegisterDate.AutoSize = true;
            this.lbRegisterDate.Location = new System.Drawing.Point(56, 92);
            this.lbRegisterDate.Name = "lbRegisterDate";
            this.lbRegisterDate.Size = new System.Drawing.Size(120, 24);
            this.lbRegisterDate.TabIndex = 0;
            this.lbRegisterDate.Text = "Tổng sinh viên:";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(571, 43);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(71, 24);
            this.lbSubject.TabIndex = 0;
            this.lbSubject.Text = "Môn học:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(56, 44);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(106, 24);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã giảng dạy:";
            // 
            // btnSearchTeaching
            // 
            this.btnSearchTeaching.Location = new System.Drawing.Point(715, 20);
            this.btnSearchTeaching.Name = "btnSearchTeaching";
            this.btnSearchTeaching.Size = new System.Drawing.Size(73, 48);
            this.btnSearchTeaching.TabIndex = 2;
            this.btnSearchTeaching.Text = "Tìm";
            this.btnSearchTeaching.UseVisualStyleBackColor = true;
            // 
            // txtSearchTeaching
            // 
            this.txtSearchTeaching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchTeaching.Location = new System.Drawing.Point(379, 32);
            this.txtSearchTeaching.Name = "txtSearchTeaching";
            this.txtSearchTeaching.Size = new System.Drawing.Size(295, 25);
            this.txtSearchTeaching.TabIndex = 1;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnSearchTeaching);
            this.gbList.Controls.Add(this.txtSearchTeaching);
            this.gbList.Controls.Add(this.dgvTeaching);
            this.gbList.Font = new System.Drawing.Font("iCiel Cucho", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.ForeColor = System.Drawing.Color.Maroon;
            this.gbList.Location = new System.Drawing.Point(26, 7);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(1132, 489);
            this.gbList.TabIndex = 15;
            this.gbList.TabStop = false;
            this.gbList.Text = "Danh sách";
            // 
            // dgvTeaching
            // 
            this.dgvTeaching.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvTeaching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeaching.GridColor = System.Drawing.Color.Teal;
            this.dgvTeaching.Location = new System.Drawing.Point(13, 78);
            this.dgvTeaching.Name = "dgvTeaching";
            this.dgvTeaching.RowHeadersWidth = 51;
            this.dgvTeaching.RowTemplate.Height = 24;
            this.dgvTeaching.Size = new System.Drawing.Size(1100, 405);
            this.dgvTeaching.TabIndex = 0;
            // 
            // btAddTeaching
            // 
            this.btAddTeaching.Location = new System.Drawing.Point(789, 677);
            this.btAddTeaching.Name = "btAddTeaching";
            this.btAddTeaching.Size = new System.Drawing.Size(66, 48);
            this.btAddTeaching.TabIndex = 20;
            this.btAddTeaching.Text = "Thêm";
            this.btAddTeaching.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTeaching
            // 
            this.btnDeleteTeaching.Location = new System.Drawing.Point(884, 677);
            this.btnDeleteTeaching.Name = "btnDeleteTeaching";
            this.btnDeleteTeaching.Size = new System.Drawing.Size(66, 48);
            this.btnDeleteTeaching.TabIndex = 21;
            this.btnDeleteTeaching.Text = "Xóa";
            this.btnDeleteTeaching.UseVisualStyleBackColor = true;
            // 
            // btnSaveTeaching
            // 
            this.btnSaveTeaching.Location = new System.Drawing.Point(979, 677);
            this.btnSaveTeaching.Name = "btnSaveTeaching";
            this.btnSaveTeaching.Size = new System.Drawing.Size(66, 48);
            this.btnSaveTeaching.TabIndex = 18;
            this.btnSaveTeaching.Text = "Lưu";
            this.btnSaveTeaching.UseVisualStyleBackColor = true;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.Location = new System.Drawing.Point(199, 93);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(290, 25);
            this.dtpRegisterDate.TabIndex = 4;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(763, 35);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(273, 32);
            this.cbSubject.TabIndex = 3;
            // 
            // GiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 737);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.btAddTeaching);
            this.Controls.Add(this.btnDeleteTeaching);
            this.Controls.Add(this.btnSaveTeaching);
            this.Name = "GiangDay";
            this.Text = "Giảng dạy";
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeaching)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbTeacher;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.TextBox txtTeachingID;
        private System.Windows.Forms.Label lbRegisterDate;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSearchTeaching;
        private System.Windows.Forms.TextBox txtSearchTeaching;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgvTeaching;
        private System.Windows.Forms.Button btAddTeaching;
        private System.Windows.Forms.Button btnDeleteTeaching;
        private System.Windows.Forms.Button btnSaveTeaching;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.ComboBox cbSubject;
    }
}