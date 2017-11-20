namespace BTL
{
    partial class ThemHang
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
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.dtphansudung = new System.Windows.Forms.DateTimePicker();
            this.dtpngaysanxuat = new System.Windows.Forms.DateTimePicker();
            this.nudgia = new System.Windows.Forms.NumericUpDown();
            this.nudsoluong = new System.Windows.Forms.NumericUpDown();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbloai);
            this.groupBox1.Controls.Add(this.dtphansudung);
            this.groupBox1.Controls.Add(this.dtpngaysanxuat);
            this.groupBox1.Controls.Add(this.nudgia);
            this.groupBox1.Controls.Add(this.nudsoluong);
            this.groupBox1.Controls.Add(this.txttenhang);
            this.groupBox1.Controls.Add(this.txtmahang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Hàng";
            // 
            // cbloai
            // 
            this.cbloai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Items.AddRange(new object[] {
            "Điện Thoại",
            "Xe Máy",
            "Thức Ăn"});
            this.cbloai.Location = new System.Drawing.Point(544, 156);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(161, 30);
            this.cbloai.TabIndex = 5;
            // 
            // dtphansudung
            // 
            this.dtphansudung.CustomFormat = "dd/MM/yyyy";
            this.dtphansudung.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtphansudung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphansudung.Location = new System.Drawing.Point(544, 95);
            this.dtphansudung.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtphansudung.Name = "dtphansudung";
            this.dtphansudung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtphansudung.Size = new System.Drawing.Size(161, 30);
            this.dtphansudung.TabIndex = 4;
            // 
            // dtpngaysanxuat
            // 
            this.dtpngaysanxuat.CustomFormat = "dd/MM/yyyy";
            this.dtpngaysanxuat.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaysanxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaysanxuat.Location = new System.Drawing.Point(544, 33);
            this.dtpngaysanxuat.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpngaysanxuat.Name = "dtpngaysanxuat";
            this.dtpngaysanxuat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpngaysanxuat.Size = new System.Drawing.Size(161, 30);
            this.dtpngaysanxuat.TabIndex = 4;
            // 
            // nudgia
            // 
            this.nudgia.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgia.Location = new System.Drawing.Point(128, 221);
            this.nudgia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudgia.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudgia.Name = "nudgia";
            this.nudgia.Size = new System.Drawing.Size(194, 30);
            this.nudgia.TabIndex = 3;
            this.nudgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudgia.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nudsoluong
            // 
            this.nudsoluong.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudsoluong.Location = new System.Drawing.Point(128, 156);
            this.nudsoluong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudsoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudsoluong.Name = "nudsoluong";
            this.nudsoluong.Size = new System.Drawing.Size(96, 30);
            this.nudsoluong.TabIndex = 2;
            this.nudsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(128, 95);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(194, 30);
            this.txttenhang.TabIndex = 1;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(128, 33);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(194, 30);
            this.txtmahang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hạn sử dụng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sản xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(565, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThemHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ThemHang";
            this.Text = "Thêm Hàng";
            this.Load += new System.EventHandler(this.ThemHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudsoluong;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbloai;
        private System.Windows.Forms.DateTimePicker dtphansudung;
        private System.Windows.Forms.DateTimePicker dtpngaysanxuat;
        private System.Windows.Forms.NumericUpDown nudgia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}