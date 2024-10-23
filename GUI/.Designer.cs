namespace GUI
{
    partial class FrmQL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.picBoxAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.txtDiemTrungBinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvQuanLiSV = new System.Windows.Forms.DataGridView();
            this.checkBoxChuaDKCN = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnhDaiDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddUpdate);
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.picBoxAnhDaiDien);
            this.groupBox1.Controls.Add(this.txtDiemTrungBinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 36);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(25, 565);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(124, 36);
            this.btnAddUpdate.TabIndex = 34;
            this.btnAddUpdate.Text = "Add / Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(97, 120);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(296, 24);
            this.cboKhoa.TabIndex = 33;
            // 
            // picBoxAnhDaiDien
            // 
            this.picBoxAnhDaiDien.InitialImage = null;
            this.picBoxAnhDaiDien.Location = new System.Drawing.Point(97, 228);
            this.picBoxAnhDaiDien.Name = "picBoxAnhDaiDien";
            this.picBoxAnhDaiDien.Size = new System.Drawing.Size(330, 301);
            this.picBoxAnhDaiDien.TabIndex = 32;
            this.picBoxAnhDaiDien.TabStop = false;
            // 
            // txtDiemTrungBinh
            // 
            this.txtDiemTrungBinh.Location = new System.Drawing.Point(97, 168);
            this.txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            this.txtDiemTrungBinh.Size = new System.Drawing.Size(296, 22);
            this.txtDiemTrungBinh.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "ĐTB";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(97, 72);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(296, 22);
            this.txtHoTen.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Khoa";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(97, 24);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(296, 22);
            this.txtMaSV.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mã SV";
            // 
            // dgvQuanLiSV
            // 
            this.dgvQuanLiSV.AllowUserToAddRows = false;
            this.dgvQuanLiSV.AllowUserToDeleteRows = false;
            this.dgvQuanLiSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiSV.Location = new System.Drawing.Point(451, 110);
            this.dgvQuanLiSV.Name = "dgvQuanLiSV";
            this.dgvQuanLiSV.ReadOnly = true;
            this.dgvQuanLiSV.RowHeadersWidth = 51;
            this.dgvQuanLiSV.RowTemplate.Height = 24;
            this.dgvQuanLiSV.Size = new System.Drawing.Size(921, 536);
            this.dgvQuanLiSV.TabIndex = 1;
            this.dgvQuanLiSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLiSV_CellClick);
            // 
            // checkBoxChuaDKCN
            // 
            this.checkBoxChuaDKCN.AutoSize = true;
            this.checkBoxChuaDKCN.Location = new System.Drawing.Point(1158, 61);
            this.checkBoxChuaDKCN.Name = "checkBoxChuaDKCN";
            this.checkBoxChuaDKCN.Size = new System.Drawing.Size(200, 20);
            this.checkBoxChuaDKCN.TabIndex = 2;
            this.checkBoxChuaDKCN.Text = "Chưa Đăng Kí Chuyên Ngành";
            this.checkBoxChuaDKCN.UseVisualStyleBackColor = true;
            this.checkBoxChuaDKCN.CheckedChanged += new System.EventHandler(this.checkBoxChuaDKCN_CheckedChanged);
            // 
            // FrmQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 736);
            this.Controls.Add(this.checkBoxChuaDKCN);
            this.Controls.Add(this.dgvQuanLiSV);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQL";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnhDaiDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvQuanLiSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBoxAnhDaiDien;
        private System.Windows.Forms.TextBox txtDiemTrungBinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox checkBoxChuaDKCN;
    }
}

