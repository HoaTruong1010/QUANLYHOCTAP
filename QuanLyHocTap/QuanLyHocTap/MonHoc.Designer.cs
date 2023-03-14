
namespace QuanLyHocTap
{
    partial class MonHoc
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
            this.btTeacherView = new System.Windows.Forms.Button();
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
            this.nbuSubjectCredit = new System.Windows.Forms.NumericUpDown();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuSubjectCredit)).BeginInit();
            this.gbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Location = new System.Drawing.Point(1004, 675);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(66, 48);
            this.btnSaveSubject.TabIndex = 5;
            this.btnSaveSubject.Text = "Lưu";
            this.btnSaveSubject.UseVisualStyleBackColor = true;
            // 
            // btTeacherView
            // 
            this.btTeacherView.Location = new System.Drawing.Point(697, 675);
            this.btTeacherView.Name = "btTeacherView";
            this.btTeacherView.Size = new System.Drawing.Size(94, 48);
            this.btTeacherView.TabIndex = 6;
            this.btTeacherView.Text = "Xem giảng viên phụ trách";
            this.btTeacherView.UseVisualStyleBackColor = true;
            // 
            // btAddSubject
            // 
            this.btAddSubject.Location = new System.Drawing.Point(820, 675);
            this.btAddSubject.Name = "btAddSubject";
            this.btAddSubject.Size = new System.Drawing.Size(66, 48);
            this.btAddSubject.TabIndex = 7;
            this.btAddSubject.Text = "Thêm";
            this.btAddSubject.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(915, 675);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(66, 48);
            this.btnDeleteSubject.TabIndex = 8;
            this.btnDeleteSubject.Text = "Xóa";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(521, 48);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(310, 25);
            this.txtSubjectName.TabIndex = 1;
            // 
            // dgvSubject
            // 
            this.dgvSubject.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.GridColor = System.Drawing.Color.Teal;
            this.dgvSubject.Location = new System.Drawing.Point(13, 78);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.RowHeadersWidth = 51;
            this.dgvSubject.RowTemplate.Height = 24;
            this.dgvSubject.Size = new System.Drawing.Size(1100, 444);
            this.dgvSubject.TabIndex = 0;
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(164, 50);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(165, 25);
            this.txtSubjectID.TabIndex = 1;
            // 
            // lbCre
            // 
            this.lbCre.AutoSize = true;
            this.lbCre.Location = new System.Drawing.Point(906, 53);
            this.lbCre.Name = "lbCre";
            this.lbCre.Size = new System.Drawing.Size(82, 24);
            this.lbCre.TabIndex = 0;
            this.lbCre.Text = "Số tín chỉ:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(395, 51);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(103, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên môn học:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(38, 51);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(96, 24);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã môn học:";
            // 
            // btnSearchSubject
            // 
            this.btnSearchSubject.Location = new System.Drawing.Point(715, 20);
            this.btnSearchSubject.Name = "btnSearchSubject";
            this.btnSearchSubject.Size = new System.Drawing.Size(73, 48);
            this.btnSearchSubject.TabIndex = 2;
            this.btnSearchSubject.Text = "Tìm";
            this.btnSearchSubject.UseVisualStyleBackColor = true;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchSubject.Location = new System.Drawing.Point(379, 32);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(295, 25);
            this.txtSearchSubject.TabIndex = 1;
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.nbuSubjectCredit);
            this.gbItem.Controls.Add(this.txtSubjectName);
            this.gbItem.Controls.Add(this.txtSubjectID);
            this.gbItem.Controls.Add(this.lbCre);
            this.gbItem.Controls.Add(this.lbName);
            this.gbItem.Controls.Add(this.lbID);
            this.gbItem.Font = new System.Drawing.Font("iCiel Cucho", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItem.ForeColor = System.Drawing.Color.Maroon;
            this.gbItem.Location = new System.Drawing.Point(27, 542);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(1132, 112);
            this.gbItem.TabIndex = 4;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Thông tin chi tiết";
            // 
            // nbuSubjectCredit
            // 
            this.nbuSubjectCredit.Location = new System.Drawing.Point(1009, 49);
            this.nbuSubjectCredit.Name = "nbuSubjectCredit";
            this.nbuSubjectCredit.Size = new System.Drawing.Size(63, 25);
            this.nbuSubjectCredit.TabIndex = 2;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnSearchSubject);
            this.gbList.Controls.Add(this.txtSearchSubject);
            this.gbList.Controls.Add(this.dgvSubject);
            this.gbList.Font = new System.Drawing.Font("iCiel Cucho", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.ForeColor = System.Drawing.Color.Maroon;
            this.gbList.Location = new System.Drawing.Point(27, 8);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(1132, 528);
            this.gbList.TabIndex = 3;
            this.gbList.TabStop = false;
            this.gbList.Text = "Danh sách";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1093, 675);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1200, 748);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveSubject);
            this.Controls.Add(this.btTeacherView);
            this.Controls.Add(this.btAddSubject);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.gbItem);
            this.Controls.Add(this.gbList);
            this.Name = "MonHoc";
            this.Text = "Môn học";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbuSubjectCredit)).EndInit();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.Button btTeacherView;
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
        private System.Windows.Forms.NumericUpDown nbuSubjectCredit;
        private System.Windows.Forms.Button btnExit;
    }
}