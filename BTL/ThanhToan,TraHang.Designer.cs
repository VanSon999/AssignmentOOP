namespace BTL
{
    partial class ThanhToan_TraHang
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvthanhtoantrahang = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntrahang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttonggiati = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(788, 490);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthanhtoan.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.Location = new System.Drawing.Point(605, 490);
            this.btnthanhtoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(143, 49);
            this.btnthanhtoan.TabIndex = 7;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.button4_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Loại";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hạn Sử Dụng";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Sản Xuất";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Hàng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Hàng";
            this.columnHeader1.Width = 80;
            // 
            // lvthanhtoantrahang
            // 
            this.lvthanhtoantrahang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lvthanhtoantrahang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvthanhtoantrahang.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvthanhtoantrahang.FullRowSelect = true;
            this.lvthanhtoantrahang.GridLines = true;
            this.lvthanhtoantrahang.Location = new System.Drawing.Point(16, 36);
            this.lvthanhtoantrahang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvthanhtoantrahang.MultiSelect = false;
            this.lvthanhtoantrahang.Name = "lvthanhtoantrahang";
            this.lvthanhtoantrahang.Size = new System.Drawing.Size(951, 306);
            this.lvthanhtoantrahang.TabIndex = 0;
            this.lvthanhtoantrahang.UseCompatibleStateImageBehavior = false;
            this.lvthanhtoantrahang.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvthanhtoantrahang);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(981, 357);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hàng Hóa Đã Mua";
            // 
            // btntrahang
            // 
            this.btntrahang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btntrahang.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrahang.Location = new System.Drawing.Point(605, 490);
            this.btntrahang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntrahang.Name = "btntrahang";
            this.btntrahang.Size = new System.Drawing.Size(140, 49);
            this.btntrahang.TabIndex = 8;
            this.btntrahang.Text = "Trả Hàng";
            this.btntrahang.UseVisualStyleBackColor = false;
            this.btntrahang.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 433);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng giá trị:";
            // 
            // txttonggiati
            // 
            this.txttonggiati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txttonggiati.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttonggiati.Location = new System.Drawing.Point(688, 430);
            this.txttonggiati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttonggiati.Name = "txttonggiati";
            this.txttonggiati.ReadOnly = true;
            this.txttonggiati.Size = new System.Drawing.Size(272, 31);
            this.txttonggiati.TabIndex = 10;
            this.txttonggiati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ThanhToan_TraHang
            // 
            this.AcceptButton = this.btnthanhtoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1000, 566);
            this.Controls.Add(this.txttonggiati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btntrahang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ThanhToan_TraHang";
            this.Text = "ThanhToan_TraHang";
            this.Load += new System.EventHandler(this.ThanhToan_TraHang_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ThanhToan_TraHang_Paint);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvthanhtoantrahang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntrahang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttonggiati;
    }
}