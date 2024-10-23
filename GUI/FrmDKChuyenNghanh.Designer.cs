namespace GUI
{
    partial class FrmDKChuyenNghanh
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
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChuyenNganh = new System.Windows.Forms.ComboBox();
            this.dgvDangKi = new System.Windows.Forms.DataGridView();
            this.btnDangKi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKi)).BeginInit();
            this.SuspendLayout();
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(228, 106);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(296, 24);
            this.cboKhoa.TabIndex = 35;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Chuyên Ngành";
            // 
            // cboChuyenNganh
            // 
            this.cboChuyenNganh.FormattingEnabled = true;
            this.cboChuyenNganh.Location = new System.Drawing.Point(228, 156);
            this.cboChuyenNganh.Name = "cboChuyenNganh";
            this.cboChuyenNganh.Size = new System.Drawing.Size(296, 24);
            this.cboChuyenNganh.TabIndex = 35;
            // 
            // dgvDangKi
            // 
            this.dgvDangKi.AllowUserToAddRows = false;
            this.dgvDangKi.AllowUserToDeleteRows = false;
            this.dgvDangKi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangKi.Location = new System.Drawing.Point(94, 199);
            this.dgvDangKi.Name = "dgvDangKi";
            this.dgvDangKi.ReadOnly = true;
            this.dgvDangKi.RowHeadersWidth = 51;
            this.dgvDangKi.RowTemplate.Height = 24;
            this.dgvDangKi.Size = new System.Drawing.Size(621, 271);
            this.dgvDangKi.TabIndex = 36;
            this.dgvDangKi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDangKi_CellContentClick);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(94, 493);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(75, 23);
            this.btnDangKi.TabIndex = 37;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // FrmDKChuyenNghanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.dgvDangKi);
            this.Controls.Add(this.cboChuyenNganh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.label2);
            this.Name = "FrmDKChuyenNghanh";
            this.Text = "FrmDKChuyenNghanh";
            this.Load += new System.EventHandler(this.FrmDKChuyenNghanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChuyenNganh;
        private System.Windows.Forms.DataGridView dgvDangKi;
        private System.Windows.Forms.Button btnDangKi;
    }
}