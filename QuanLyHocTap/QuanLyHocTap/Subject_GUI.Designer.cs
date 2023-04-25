
namespace QuanLyHocTap
{
    partial class Subject_GUI
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
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.btAddSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.lbCre = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnSearchSubject = new System.Windows.Forms.Button();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.cbbCredits = new System.Windows.Forms.ComboBox();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.gbItem.SuspendLayout();
            this.gbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Location = new System.Drawing.Point(1025, 430);
            this.btnSaveSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(83, 60);
            this.btnSaveSubject.TabIndex = 4;
            this.btnSaveSubject.Text = "Lưu";
            this.btnSaveSubject.UseVisualStyleBackColor = true;
            this.btnSaveSubject.Click += new System.EventHandler(this.btnSaveSubject_Click);
            // 
            // btAddSubject
            // 
            this.btAddSubject.Location = new System.Drawing.Point(867, 430);
            this.btAddSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btAddSubject.Name = "btAddSubject";
            this.btAddSubject.Size = new System.Drawing.Size(83, 60);
            this.btAddSubject.TabIndex = 3;
            this.btAddSubject.Text = "Thêm";
            this.btAddSubject.UseVisualStyleBackColor = true;
            this.btAddSubject.Click += new System.EventHandler(this.btAddSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(867, 547);
            this.btnDeleteSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(83, 60);
            this.btnDeleteSubject.TabIndex = 5;
            this.btnDeleteSubject.Text = "Xóa";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(31, 167);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(283, 27);
            this.txtSubjectName.TabIndex = 2;
            this.txtSubjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubjectID_KeyPress);
            // 
            // dgvSubject
            // 
            this.dgvSubject.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.GridColor = System.Drawing.Color.Teal;
            this.dgvSubject.Location = new System.Drawing.Point(16, 98);
            this.dgvSubject.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSubject.MultiSelect = false;
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.RowHeadersWidth = 51;
            this.dgvSubject.RowTemplate.Height = 24;
            this.dgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubject.Size = new System.Drawing.Size(733, 568);
            this.dgvSubject.TabIndex = 0;
            this.dgvSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellClick);
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectID.Location = new System.Drawing.Point(31, 84);
            this.txtSubjectID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(283, 27);
            this.txtSubjectID.TabIndex = 1;
            this.txtSubjectID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubjectID_KeyPress);
            // 
            // lbCre
            // 
            this.lbCre.AutoSize = true;
            this.lbCre.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCre.Location = new System.Drawing.Point(27, 237);
            this.lbCre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCre.Name = "lbCre";
            this.lbCre.Size = new System.Drawing.Size(119, 20);
            this.lbCre.TabIndex = 0;
            this.lbCre.Text = "Số tín chỉ:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(27, 143);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(129, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên môn học:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(27, 54);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(119, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã môn học:";
            // 
            // btnSearchSubject
            // 
            this.btnSearchSubject.Location = new System.Drawing.Point(516, 34);
            this.btnSearchSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSubject.Name = "btnSearchSubject";
            this.btnSearchSubject.Size = new System.Drawing.Size(86, 42);
            this.btnSearchSubject.TabIndex = 8;
            this.btnSearchSubject.Text = "Tìm";
            this.btnSearchSubject.UseVisualStyleBackColor = true;
            this.btnSearchSubject.Click += new System.EventHandler(this.btnSearchSubject_Click);
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchSubject.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSubject.Location = new System.Drawing.Point(99, 43);
            this.txtSearchSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(368, 28);
            this.txtSearchSubject.TabIndex = 7;
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.cbbCredits);
            this.gbItem.Controls.Add(this.txtSubjectName);
            this.gbItem.Controls.Add(this.txtSubjectID);
            this.gbItem.Controls.Add(this.lbCre);
            this.gbItem.Controls.Add(this.lbName);
            this.gbItem.Controls.Add(this.lbID);
            this.gbItem.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItem.ForeColor = System.Drawing.Color.Maroon;
            this.gbItem.Location = new System.Drawing.Point(809, 13);
            this.gbItem.Margin = new System.Windows.Forms.Padding(4);
            this.gbItem.Name = "gbItem";
            this.gbItem.Padding = new System.Windows.Forms.Padding(4);
            this.gbItem.Size = new System.Drawing.Size(346, 329);
            this.gbItem.TabIndex = 4;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Thông tin chi tiết";
            // 
            // cbbCredits
            // 
            this.cbbCredits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCredits.FormattingEnabled = true;
            this.cbbCredits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "3",
            "4"});
            this.cbbCredits.Location = new System.Drawing.Point(31, 260);
            this.cbbCredits.Name = "cbbCredits";
            this.cbbCredits.Size = new System.Drawing.Size(110, 28);
            this.cbbCredits.TabIndex = 2;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnSearchSubject);
            this.gbList.Controls.Add(this.txtSearchSubject);
            this.gbList.Controls.Add(this.dgvSubject);
            this.gbList.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.ForeColor = System.Drawing.Color.Maroon;
            this.gbList.Location = new System.Drawing.Point(34, 9);
            this.gbList.Margin = new System.Windows.Forms.Padding(4);
            this.gbList.Name = "gbList";
            this.gbList.Padding = new System.Windows.Forms.Padding(4);
            this.gbList.Size = new System.Drawing.Size(767, 674);
            this.gbList.TabIndex = 3;
            this.gbList.TabStop = false;
            this.gbList.Text = "Danh sách";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1025, 547);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 60);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Subject_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1193, 696);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveSubject);
            this.Controls.Add(this.btAddSubject);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbList);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Subject_GUI";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            this.Click += new System.EventHandler(this.Subject_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.Button btAddSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.Label lbCre;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSearchSubject;
        private System.Windows.Forms.TextBox txtSearchSubject;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbCredits;
    }
}