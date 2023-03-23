
namespace QuanLyHocTap
{
    partial class Classes
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
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.btAddClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.lbNumStudent = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSearchClass = new System.Windows.Forms.Button();
            this.txtSearchClass = new System.Windows.Forms.TextBox();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.cbbTeacher = new System.Windows.Forms.ComboBox();
            this.nbuNumStudent = new System.Windows.Forms.NumericUpDown();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuNumStudent)).BeginInit();
            this.gbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClass.Location = new System.Drawing.Point(929, 684);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(88, 48);
            this.btnSaveClass.TabIndex = 11;
            this.btnSaveClass.Text = "Lưu";
            this.btnSaveClass.UseVisualStyleBackColor = true;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // btAddClass
            // 
            this.btAddClass.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddClass.Location = new System.Drawing.Point(661, 684);
            this.btAddClass.Name = "btAddClass";
            this.btAddClass.Size = new System.Drawing.Size(88, 48);
            this.btAddClass.TabIndex = 13;
            this.btAddClass.Text = "Thêm";
            this.btAddClass.UseVisualStyleBackColor = true;
            this.btAddClass.Click += new System.EventHandler(this.btAddClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.Location = new System.Drawing.Point(793, 684);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(88, 48);
            this.btnDeleteClass.TabIndex = 14;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(807, 36);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(273, 27);
            this.txtClassName.TabIndex = 1;
            this.txtClassName.Click += new System.EventHandler(this.txtClassName_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.GridColor = System.Drawing.Color.Teal;
            this.dgvClass.Location = new System.Drawing.Point(13, 78);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(1100, 405);
            this.dgvClass.TabIndex = 0;
            this.dgvClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentClick);
            // 
            // txtClassID
            // 
            this.txtClassID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassID.Location = new System.Drawing.Point(236, 36);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(251, 27);
            this.txtClassID.TabIndex = 1;
            // 
            // lbNumStudent
            // 
            this.lbNumStudent.AutoSize = true;
            this.lbNumStudent.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumStudent.Location = new System.Drawing.Point(56, 92);
            this.lbNumStudent.Name = "lbNumStudent";
            this.lbNumStudent.Size = new System.Drawing.Size(159, 20);
            this.lbNumStudent.TabIndex = 0;
            this.lbNumStudent.Text = "Tổng sinh viên:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(561, 40);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(89, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên lớp:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(56, 44);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(79, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã lớp:";
            // 
            // btnSearchClass
            // 
            this.btnSearchClass.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClass.Location = new System.Drawing.Point(715, 20);
            this.btnSearchClass.Name = "btnSearchClass";
            this.btnSearchClass.Size = new System.Drawing.Size(73, 48);
            this.btnSearchClass.TabIndex = 2;
            this.btnSearchClass.Text = "Tìm";
            this.btnSearchClass.UseVisualStyleBackColor = true;
            this.btnSearchClass.Click += new System.EventHandler(this.btnSearchClass_Click);
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchClass.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClass.Location = new System.Drawing.Point(379, 32);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(295, 28);
            this.txtSearchClass.TabIndex = 1;
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.cbbTeacher);
            this.gbItem.Controls.Add(this.nbuNumStudent);
            this.gbItem.Controls.Add(this.txtClassName);
            this.gbItem.Controls.Add(this.txtClassID);
            this.gbItem.Controls.Add(this.lbTeacher);
            this.gbItem.Controls.Add(this.lbNumStudent);
            this.gbItem.Controls.Add(this.lbName);
            this.gbItem.Controls.Add(this.lbID);
            this.gbItem.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItem.ForeColor = System.Drawing.Color.Maroon;
            this.gbItem.Location = new System.Drawing.Point(36, 524);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(1132, 139);
            this.gbItem.TabIndex = 10;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Thông tin chi tiết";
            // 
            // cbbTeacher
            // 
            this.cbbTeacher.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTeacher.FormattingEnabled = true;
            this.cbbTeacher.Location = new System.Drawing.Point(807, 82);
            this.cbbTeacher.Name = "cbbTeacher";
            this.cbbTeacher.Size = new System.Drawing.Size(273, 28);
            this.cbbTeacher.TabIndex = 3;
            this.cbbTeacher.Click += new System.EventHandler(this.cbbTeacher_Click);
            // 
            // nbuNumStudent
            // 
            this.nbuNumStudent.Enabled = false;
            this.nbuNumStudent.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbuNumStudent.Location = new System.Drawing.Point(236, 85);
            this.nbuNumStudent.Name = "nbuNumStudent";
            this.nbuNumStudent.Size = new System.Drawing.Size(97, 27);
            this.nbuNumStudent.TabIndex = 2;
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher.Location = new System.Drawing.Point(561, 86);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(219, 20);
            this.lbTeacher.TabIndex = 0;
            this.lbTeacher.Text = "Giảng viên chủ nhiệm:";
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnSearchClass);
            this.gbList.Controls.Add(this.txtSearchClass);
            this.gbList.Controls.Add(this.dgvClass);
            this.gbList.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.ForeColor = System.Drawing.Color.Maroon;
            this.gbList.Location = new System.Drawing.Point(36, 17);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(1132, 489);
            this.gbList.TabIndex = 9;
            this.gbList.TabStop = false;
            this.gbList.Text = "Danh sách";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1061, 684);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 48);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1203, 747);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveClass);
            this.Controls.Add(this.btAddClass);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Classes";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.Lop_Load);
            this.Click += new System.EventHandler(this.Classes_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuNumStudent)).EndInit();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.Button btAddClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label lbNumStudent;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSearchClass;
        private System.Windows.Forms.TextBox txtSearchClass;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.NumericUpDown nbuNumStudent;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.ComboBox cbbTeacher;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.Button btnExit;
    }
}