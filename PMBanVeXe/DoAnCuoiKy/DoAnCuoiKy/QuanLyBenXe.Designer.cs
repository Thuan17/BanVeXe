namespace DoAnCuoiKy
{
    partial class QuanLyBenXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyBenXe));
            this.Txt_Tinh = new System.Windows.Forms.TextBox();
            this.dataBenXe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQLLX_Save = new System.Windows.Forms.Button();
            this.btnLX_return = new System.Windows.Forms.Button();
            this.btnLX_reset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_TenBenXe = new System.Windows.Forms.ComboBox();
            this.rd_SuaBen = new System.Windows.Forms.CheckBox();
            this.ck_ThemBenMoi = new System.Windows.Forms.CheckBox();
            this.btnQLLX_TCXe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TCXe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XemToanBo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtThemBenXe = new System.Windows.Forms.TextBox();
            this.label_Tinh = new System.Windows.Forms.Label();
            this.txtThemTinh = new System.Windows.Forms.TextBox();
            this.label_TenBen = new System.Windows.Forms.Label();
            this.gThemBen = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBenXe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gThemBen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Tinh
            // 
            this.Txt_Tinh.Enabled = false;
            this.Txt_Tinh.ForeColor = System.Drawing.Color.Black;
            this.Txt_Tinh.Location = new System.Drawing.Point(128, 86);
            this.Txt_Tinh.Name = "Txt_Tinh";
            this.Txt_Tinh.Size = new System.Drawing.Size(298, 31);
            this.Txt_Tinh.TabIndex = 0;
            // 
            // dataBenXe
            // 
            this.dataBenXe.AllowUserToAddRows = false;
            this.dataBenXe.AllowUserToOrderColumns = true;
            this.dataBenXe.AllowUserToResizeColumns = false;
            this.dataBenXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBenXe.Location = new System.Drawing.Point(6, 25);
            this.dataBenXe.Name = "dataBenXe";
            this.dataBenXe.ReadOnly = true;
            this.dataBenXe.Size = new System.Drawing.Size(698, 166);
            this.dataBenXe.TabIndex = 4;
            this.dataBenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBenXe_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQLLX_Save);
            this.groupBox1.Controls.Add(this.btnLX_return);
            this.groupBox1.Controls.Add(this.btnLX_reset);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(569, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnQLLX_Save
            // 
            this.btnQLLX_Save.Enabled = false;
            this.btnQLLX_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLX_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQLLX_Save.Image = ((System.Drawing.Image)(resources.GetObject("btnQLLX_Save.Image")));
            this.btnQLLX_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLX_Save.Location = new System.Drawing.Point(16, 42);
            this.btnQLLX_Save.Name = "btnQLLX_Save";
            this.btnQLLX_Save.Size = new System.Drawing.Size(113, 50);
            this.btnQLLX_Save.TabIndex = 7;
            this.btnQLLX_Save.Text = "Lưu";
            this.btnQLLX_Save.UseVisualStyleBackColor = true;
            this.btnQLLX_Save.Click += new System.EventHandler(this.btnQLLX_Save_Click);
            // 
            // btnLX_return
            // 
            this.btnLX_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLX_return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLX_return.Image = ((System.Drawing.Image)(resources.GetObject("btnLX_return.Image")));
            this.btnLX_return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLX_return.Location = new System.Drawing.Point(16, 149);
            this.btnLX_return.Name = "btnLX_return";
            this.btnLX_return.Size = new System.Drawing.Size(113, 45);
            this.btnLX_return.TabIndex = 12;
            this.btnLX_return.Text = "Trở Lại";
            this.btnLX_return.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLX_return.UseVisualStyleBackColor = true;
            this.btnLX_return.Click += new System.EventHandler(this.btnLX_return_Click);
            // 
            // btnLX_reset
            // 
            this.btnLX_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLX_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLX_reset.Image = ((System.Drawing.Image)(resources.GetObject("btnLX_reset.Image")));
            this.btnLX_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLX_reset.Location = new System.Drawing.Point(16, 102);
            this.btnLX_reset.Name = "btnLX_reset";
            this.btnLX_reset.Size = new System.Drawing.Size(113, 41);
            this.btnLX_reset.TabIndex = 13;
            this.btnLX_reset.TabStop = false;
            this.btnLX_reset.Text = "Reset";
            this.btnLX_reset.UseVisualStyleBackColor = true;
            this.btnLX_reset.Click += new System.EventHandler(this.btnLX_reset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_TenBenXe);
            this.groupBox2.Controls.Add(this.rd_SuaBen);
            this.groupBox2.Controls.Add(this.ck_ThemBenMoi);
            this.groupBox2.Controls.Add(this.btnQLLX_TCXe);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Txt_Tinh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 208);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbx_TenBenXe
            // 
            this.cbx_TenBenXe.FormattingEnabled = true;
            this.cbx_TenBenXe.Location = new System.Drawing.Point(128, 32);
            this.cbx_TenBenXe.Name = "cbx_TenBenXe";
            this.cbx_TenBenXe.Size = new System.Drawing.Size(298, 33);
            this.cbx_TenBenXe.TabIndex = 19;
            // 
            // rd_SuaBen
            // 
            this.rd_SuaBen.AutoSize = true;
            this.rd_SuaBen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_SuaBen.ForeColor = System.Drawing.Color.Black;
            this.rd_SuaBen.Location = new System.Drawing.Point(232, 137);
            this.rd_SuaBen.Name = "rd_SuaBen";
            this.rd_SuaBen.Size = new System.Drawing.Size(129, 24);
            this.rd_SuaBen.TabIndex = 17;
            this.rd_SuaBen.Text = "Sửa Đổi Bến";
            this.rd_SuaBen.UseVisualStyleBackColor = true;
            this.rd_SuaBen.CheckedChanged += new System.EventHandler(this.rd_SuaBen_CheckedChanged);
            // 
            // ck_ThemBenMoi
            // 
            this.ck_ThemBenMoi.AutoSize = true;
            this.ck_ThemBenMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_ThemBenMoi.ForeColor = System.Drawing.Color.Black;
            this.ck_ThemBenMoi.Location = new System.Drawing.Point(60, 137);
            this.ck_ThemBenMoi.Name = "ck_ThemBenMoi";
            this.ck_ThemBenMoi.Size = new System.Drawing.Size(142, 24);
            this.ck_ThemBenMoi.TabIndex = 16;
            this.ck_ThemBenMoi.Text = "Thêm Bến Mới";
            this.ck_ThemBenMoi.UseVisualStyleBackColor = true;
            this.ck_ThemBenMoi.CheckedChanged += new System.EventHandler(this.ck_ThemBenMoi_CheckedChanged);
            // 
            // btnQLLX_TCXe
            // 
            this.btnQLLX_TCXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLX_TCXe.ForeColor = System.Drawing.Color.Black;
            this.btnQLLX_TCXe.Image = ((System.Drawing.Image)(resources.GetObject("btnQLLX_TCXe.Image")));
            this.btnQLLX_TCXe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLLX_TCXe.Location = new System.Drawing.Point(446, 30);
            this.btnQLLX_TCXe.Name = "btnQLLX_TCXe";
            this.btnQLLX_TCXe.Size = new System.Drawing.Size(89, 35);
            this.btnQLLX_TCXe.TabIndex = 11;
            this.btnQLLX_TCXe.Text = "Tìm";
            this.btnQLLX_TCXe.UseVisualStyleBackColor = true;
            this.btnQLLX_TCXe.Click += new System.EventHandler(this.btnQLLX_TCXe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tỉnh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bến Xe:";
            // 
            // btn_TCXe
            // 
            this.btn_TCXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TCXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TCXe.Image = ((System.Drawing.Image)(resources.GetObject("btn_TCXe.Image")));
            this.btn_TCXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TCXe.Location = new System.Drawing.Point(135, 82);
            this.btn_TCXe.Name = "btn_TCXe";
            this.btn_TCXe.Size = new System.Drawing.Size(222, 42);
            this.btn_TCXe.TabIndex = 15;
            this.btn_TCXe.TabStop = false;
            this.btn_TCXe.Text = "Thêm Chuyến Xe";
            this.btn_TCXe.UseVisualStyleBackColor = true;
            this.btn_TCXe.Visible = false;
            this.btn_TCXe.Click += new System.EventHandler(this.btn_TCXe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(227, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản Lý Bến Xe";
            // 
            // btn_XemToanBo
            // 
            this.btn_XemToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemToanBo.Location = new System.Drawing.Point(12, 268);
            this.btn_XemToanBo.Name = "btn_XemToanBo";
            this.btn_XemToanBo.Size = new System.Drawing.Size(130, 25);
            this.btn_XemToanBo.TabIndex = 8;
            this.btn_XemToanBo.Text = "Xem Toàn Bộ Bến";
            this.btn_XemToanBo.UseVisualStyleBackColor = true;
            this.btn_XemToanBo.Click += new System.EventHandler(this.btn_XemToanBo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataBenXe);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 197);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bến Xe";
            // 
            // txtThemBenXe
            // 
            this.txtThemBenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThemBenXe.Location = new System.Drawing.Point(88, 19);
            this.txtThemBenXe.Name = "txtThemBenXe";
            this.txtThemBenXe.Size = new System.Drawing.Size(250, 26);
            this.txtThemBenXe.TabIndex = 20;
            this.txtThemBenXe.Visible = false;
            // 
            // label_Tinh
            // 
            this.label_Tinh.AutoSize = true;
            this.label_Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tinh.ForeColor = System.Drawing.Color.Black;
            this.label_Tinh.Location = new System.Drawing.Point(19, 54);
            this.label_Tinh.Name = "label_Tinh";
            this.label_Tinh.Size = new System.Drawing.Size(53, 20);
            this.label_Tinh.TabIndex = 21;
            this.label_Tinh.Text = "Tỉnh :";
            this.label_Tinh.Visible = false;
            // 
            // txtThemTinh
            // 
            this.txtThemTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThemTinh.ForeColor = System.Drawing.Color.Black;
            this.txtThemTinh.Location = new System.Drawing.Point(88, 51);
            this.txtThemTinh.Name = "txtThemTinh";
            this.txtThemTinh.Size = new System.Drawing.Size(250, 26);
            this.txtThemTinh.TabIndex = 20;
            // 
            // label_TenBen
            // 
            this.label_TenBen.AutoSize = true;
            this.label_TenBen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenBen.ForeColor = System.Drawing.Color.Black;
            this.label_TenBen.Location = new System.Drawing.Point(6, 22);
            this.label_TenBen.Name = "label_TenBen";
            this.label_TenBen.Size = new System.Drawing.Size(76, 20);
            this.label_TenBen.TabIndex = 20;
            this.label_TenBen.Text = "Tên Bến";
            this.label_TenBen.Visible = false;
            // 
            // gThemBen
            // 
            this.gThemBen.Controls.Add(this.label_TenBen);
            this.gThemBen.Controls.Add(this.label_Tinh);
            this.gThemBen.Controls.Add(this.txtThemBenXe);
            this.gThemBen.Controls.Add(this.txtThemTinh);
            this.gThemBen.Controls.Add(this.btn_TCXe);
            this.gThemBen.Location = new System.Drawing.Point(111, 268);
            this.gThemBen.Name = "gThemBen";
            this.gThemBen.Size = new System.Drawing.Size(382, 130);
            this.gThemBen.TabIndex = 22;
            this.gThemBen.TabStop = false;
            this.gThemBen.Text = "Thêm Bến";
            this.gThemBen.Visible = false;
            // 
            // QuanLyBenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Controls.Add(this.gThemBen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_XemToanBo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "QuanLyBenXe";
            this.Text = "Quản Lý Bến Xe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyBenXe_FormClosing);
            this.Load += new System.EventHandler(this.QuanLyBenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBenXe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gThemBen.ResumeLayout(false);
            this.gThemBen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Tinh;
        private System.Windows.Forms.DataGridView dataBenXe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLLX_TCXe;
        private System.Windows.Forms.Button btnQLLX_Save;
        private System.Windows.Forms.Button btnLX_return;
        private System.Windows.Forms.Button btnLX_reset;
        private System.Windows.Forms.Button btn_XemToanBo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_TCXe;
        private System.Windows.Forms.CheckBox ck_ThemBenMoi;
        private System.Windows.Forms.CheckBox rd_SuaBen;
        private System.Windows.Forms.ComboBox cbx_TenBenXe;
        private System.Windows.Forms.TextBox txtThemBenXe;
        private System.Windows.Forms.Label label_Tinh;
        private System.Windows.Forms.TextBox txtThemTinh;
        private System.Windows.Forms.Label label_TenBen;
        private System.Windows.Forms.GroupBox gThemBen;
    }
}