namespace BTL
{
    partial class SoLuongMua
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudsoluongcanmua = new System.Windows.Forms.NumericUpDown();
            this.btnok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluongcanmua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số lượng cần mua:";
            // 
            // nudsoluongcanmua
            // 
            this.nudsoluongcanmua.Location = new System.Drawing.Point(227, 30);
            this.nudsoluongcanmua.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudsoluongcanmua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudsoluongcanmua.Name = "nudsoluongcanmua";
            this.nudsoluongcanmua.Size = new System.Drawing.Size(185, 26);
            this.nudsoluongcanmua.TabIndex = 2;
            this.nudsoluongcanmua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudsoluongcanmua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnok.Location = new System.Drawing.Point(324, 73);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(88, 35);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // SoLuongMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 120);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.nudsoluongcanmua);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SoLuongMua";
            this.Text = "Số Lượng Cần Mua";
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluongcanmua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudsoluongcanmua;
        private System.Windows.Forms.Button btnok;
    }
}