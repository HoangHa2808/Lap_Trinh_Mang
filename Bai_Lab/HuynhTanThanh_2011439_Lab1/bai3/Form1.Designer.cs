namespace Bai03
{
    partial class Form1
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
            this.txtTenMien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhanGiai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTenMien = new System.Windows.Forms.Label();
            this.lblDiaChiIP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenMien
            // 
            this.txtTenMien.Location = new System.Drawing.Point(96, 12);
            this.txtTenMien.Name = "txtTenMien";
            this.txtTenMien.Size = new System.Drawing.Size(380, 20);
            this.txtTenMien.TabIndex = 0;
            this.txtTenMien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenMien_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên miền";
            // 
            // btnPhanGiai
            // 
            this.btnPhanGiai.Location = new System.Drawing.Point(210, 58);
            this.btnPhanGiai.Name = "btnPhanGiai";
            this.btnPhanGiai.Size = new System.Drawing.Size(75, 23);
            this.btnPhanGiai.TabIndex = 2;
            this.btnPhanGiai.Text = "Phân giải";
            this.btnPhanGiai.UseVisualStyleBackColor = true;
            this.btnPhanGiai.Click += new System.EventHandler(this.btnPhanGiai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiaChiIP);
            this.groupBox1.Controls.Add(this.lblTenMien);
            this.groupBox1.Location = new System.Drawing.Point(15, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả phân giải tên miền";
            // 
            // lblTenMien
            // 
            this.lblTenMien.AutoSize = true;
            this.lblTenMien.Location = new System.Drawing.Point(18, 27);
            this.lblTenMien.Name = "lblTenMien";
            this.lblTenMien.Size = new System.Drawing.Size(0, 13);
            this.lblTenMien.TabIndex = 0;
            // 
            // lblDiaChiIP
            // 
            this.lblDiaChiIP.AutoSize = true;
            this.lblDiaChiIP.Location = new System.Drawing.Point(18, 50);
            this.lblDiaChiIP.Name = "lblDiaChiIP";
            this.lblDiaChiIP.Size = new System.Drawing.Size(0, 13);
            this.lblDiaChiIP.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPhanGiai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenMien);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân giải tên miền";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenMien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPhanGiai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiaChiIP;
        private System.Windows.Forms.Label lblTenMien;
    }
}

