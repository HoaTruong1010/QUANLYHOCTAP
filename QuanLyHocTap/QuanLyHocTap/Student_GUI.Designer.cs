
namespace QuanLyHocTap
{
    partial class Student_GUI
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
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtSeachStudent = new System.Windows.Forms.TextBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.dtpStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.txtStudentCCCD = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.txtStudentPN = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbPN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.btnViewScore = new System.Windows.Forms.Button();
            this.btAddStudent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gbItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnSearchStudent);
            this.gbList.Controls.Add(this.txtSeachStudent);
            this.gbList.Controls.Add(this.dgvStudent);
            this.gbList.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.ForeColor = System.Drawing.Color.Maroon;
            this.gbList.Location = new System.Drawing.Point(16, 12);
            this.gbList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbList.Name = "gbList";
            this.gbList.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbList.Size = new System.Drawing.Size(1415, 418);
            this.gbList.TabIndex = 0;
            this.gbList.TabStop = false;
            this.gbList.Text = "Danh sách";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(874, 29);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(87, 39);
            this.btnSearchStudent.TabIndex = 2;
            this.btnSearchStudent.Text = "Tìm";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtSeachStudent
            // 
            this.txtSeachStudent.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachStudent.Location = new System.Drawing.Point(417, 40);
            this.txtSeachStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSeachStudent.Name = "txtSeachStudent";
            this.txtSeachStudent.Size = new System.Drawing.Size(420, 28);
            this.txtSeachStudent.TabIndex = 1;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(19, 87);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(1388, 321);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.cbbClass);
            this.gbItem.Controls.Add(this.dtpStudentDOB);
            this.gbItem.Controls.Add(this.txtStudentCCCD);
            this.gbItem.Controls.Add(this.txtStudentName);
            this.gbItem.Controls.Add(this.txtStudentAddress);
            this.gbItem.Controls.Add(this.txtStudentPN);
            this.gbItem.Controls.Add(this.txtStudentEmail);
            this.gbItem.Controls.Add(this.lbAddress);
            this.gbItem.Controls.Add(this.txtStudentID);
            this.gbItem.Controls.Add(this.lbClass);
            this.gbItem.Controls.Add(this.lbPN);
            this.gbItem.Controls.Add(this.label4);
            this.gbItem.Controls.Add(this.lbCCCD);
            this.gbItem.Controls.Add(this.lbDOB);
            this.gbItem.Controls.Add(this.lbName);
            this.gbItem.Controls.Add(this.lbID);
            this.gbItem.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItem.ForeColor = System.Drawing.Color.Maroon;
            this.gbItem.Location = new System.Drawing.Point(16, 436);
            this.gbItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbItem.Name = "gbItem";
            this.gbItem.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbItem.Size = new System.Drawing.Size(1415, 256);
            this.gbItem.TabIndex = 1;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Thông tin chi tiết";
            // 
            // cbbClass
            // 
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(998, 198);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(367, 28);
            this.cbbClass.TabIndex = 10;
            // 
            // dtpStudentDOB
            // 
            this.dtpStudentDOB.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStudentDOB.Location = new System.Drawing.Point(305, 149);
            this.dtpStudentDOB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpStudentDOB.Name = "dtpStudentDOB";
            this.dtpStudentDOB.Size = new System.Drawing.Size(371, 27);
            this.dtpStudentDOB.TabIndex = 5;
            // 
            // txtStudentCCCD
            // 
            this.txtStudentCCCD.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentCCCD.Location = new System.Drawing.Point(305, 199);
            this.txtStudentCCCD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentCCCD.Name = "txtStudentCCCD";
            this.txtStudentCCCD.Size = new System.Drawing.Size(371, 27);
            this.txtStudentCCCD.TabIndex = 6;
            this.txtStudentCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentID_KeyPress);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(305, 100);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(371, 27);
            this.txtStudentName.TabIndex = 4;
            this.txtStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentName_KeyPress);
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentAddress.Location = new System.Drawing.Point(998, 149);
            this.txtStudentAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(367, 27);
            this.txtStudentAddress.TabIndex = 9;
            // 
            // txtStudentPN
            // 
            this.txtStudentPN.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentPN.Location = new System.Drawing.Point(998, 98);
            this.txtStudentPN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentPN.Name = "txtStudentPN";
            this.txtStudentPN.Size = new System.Drawing.Size(367, 27);
            this.txtStudentPN.TabIndex = 8;
            this.txtStudentPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentID_KeyPress);
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail.Location = new System.Drawing.Point(998, 50);
            this.txtStudentEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(367, 27);
            this.txtStudentEmail.TabIndex = 7;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(799, 156);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(89, 20);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(305, 56);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(371, 27);
            this.txtStudentID.TabIndex = 3;
            this.txtStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentID_KeyPress);
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(799, 206);
            this.lbClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(49, 20);
            this.lbClass.TabIndex = 0;
            this.lbClass.Text = "Lớp:";
            // 
            // lbPN
            // 
            this.lbPN.AutoSize = true;
            this.lbPN.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPN.Location = new System.Drawing.Point(799, 103);
            this.lbPN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPN.Name = "lbPN";
            this.lbPN.Size = new System.Drawing.Size(149, 20);
            this.lbPN.TabIndex = 0;
            this.lbPN.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(799, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCCCD.Location = new System.Drawing.Point(35, 202);
            this.lbCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(219, 20);
            this.lbCCCD.TabIndex = 0;
            this.lbCCCD.Text = "Số căn cước công dân:";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOB.Location = new System.Drawing.Point(35, 151);
            this.lbDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(109, 20);
            this.lbDOB.TabIndex = 0;
            this.lbDOB.Text = "Ngày sinh:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(35, 103);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(179, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ tên sinh viên:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(35, 57);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(169, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã số sinh viên:";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(1004, 712);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(94, 53);
            this.btnDeleteStudent.TabIndex = 14;
            this.btnDeleteStudent.Text = "Xóa";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Location = new System.Drawing.Point(1124, 712);
            this.btnSaveStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(94, 53);
            this.btnSaveStudent.TabIndex = 13;
            this.btnSaveStudent.Text = "Lưu";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // btnViewScore
            // 
            this.btnViewScore.Location = new System.Drawing.Point(719, 712);
            this.btnViewScore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewScore.Name = "btnViewScore";
            this.btnViewScore.Size = new System.Drawing.Size(134, 53);
            this.btnViewScore.TabIndex = 11;
            this.btnViewScore.Text = "Danh sách môn học";
            this.btnViewScore.UseVisualStyleBackColor = true;
            this.btnViewScore.Click += new System.EventHandler(this.btnViewScore_Click);
            // 
            // btAddStudent
            // 
            this.btAddStudent.Location = new System.Drawing.Point(883, 712);
            this.btAddStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(94, 53);
            this.btAddStudent.TabIndex = 12;
            this.btAddStudent.Text = "Thêm";
            this.btAddStudent.UseVisualStyleBackColor = true;
            this.btAddStudent.Click += new System.EventHandler(this.btAddStudent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1257, 712);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 53);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Student_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1458, 777);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.btnViewScore);
            this.Controls.Add(this.btAddStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbList);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Student_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            this.Click += new System.EventHandler(this.Student_Click);
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.Label lbPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.DateTimePicker dtpStudentDOB;
        private System.Windows.Forms.TextBox txtStudentCCCD;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentPN;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtSeachStudent;
        private System.Windows.Forms.Button btnViewScore;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Button btAddStudent;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Button btnExit;
    }
}