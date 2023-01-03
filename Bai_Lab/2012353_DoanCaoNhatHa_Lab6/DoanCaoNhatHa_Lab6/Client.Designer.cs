namespace DoanCaoNhatHa_Lab6
{
	partial class Client
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
			this.btn_Connect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtEnter = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lbxClient = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtClient = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_Connect
			// 
			this.btn_Connect.Location = new System.Drawing.Point(44, 32);
			this.btn_Connect.Name = "btn_Connect";
			this.btn_Connect.Size = new System.Drawing.Size(75, 23);
			this.btn_Connect.TabIndex = 0;
			this.btn_Connect.Text = "Connect";
			this.btn_Connect.UseVisualStyleBackColor = true;
			this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(215, 32);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
			this.btnDisconnect.TabIndex = 0;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(289, 97);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtEnter
			// 
			this.txtEnter.AutoSize = true;
			this.txtEnter.Location = new System.Drawing.Point(41, 76);
			this.txtEnter.Name = "txtEnter";
			this.txtEnter.Size = new System.Drawing.Size(55, 13);
			this.txtEnter.TabIndex = 1;
			this.txtEnter.Text = "Enter text:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(44, 100);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(224, 20);
			this.textBox1.TabIndex = 2;
			// 
			// lbxClient
			// 
			this.lbxClient.FormattingEnabled = true;
			this.lbxClient.Location = new System.Drawing.Point(44, 138);
			this.lbxClient.Name = "lbxClient";
			this.lbxClient.Size = new System.Drawing.Size(327, 108);
			this.lbxClient.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 281);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Connection Status";
			// 
			// txtClient
			// 
			this.txtClient.Location = new System.Drawing.Point(141, 278);
			this.txtClient.Name = "txtClient";
			this.txtClient.Size = new System.Drawing.Size(230, 20);
			this.txtClient.TabIndex = 2;
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 322);
			this.Controls.Add(this.lbxClient);
			this.Controls.Add(this.txtClient);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEnter);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.btn_Connect);
			this.Name = "Client";
			this.Text = "Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Connect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label txtEnter;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox lbxClient;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtClient;
	}
}