namespace DoanCaoNhatHa_Lab6
{
	partial class Server
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
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.lbText = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtConnection = new System.Windows.Forms.TextBox();
			this.lbxServer = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(51, 34);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start Server";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(218, 34);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 0;
			this.btnStop.Text = "Stop Server";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lbText
			// 
			this.lbText.AutoSize = true;
			this.lbText.Location = new System.Drawing.Point(48, 81);
			this.lbText.Name = "lbText";
			this.lbText.Size = new System.Drawing.Size(120, 13);
			this.lbText.TabIndex = 1;
			this.lbText.Text = "Text receive from client:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 263);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Connection Status:";
			// 
			// txtConnection
			// 
			this.txtConnection.Location = new System.Drawing.Point(151, 260);
			this.txtConnection.Name = "txtConnection";
			this.txtConnection.Size = new System.Drawing.Size(224, 20);
			this.txtConnection.TabIndex = 3;
			// 
			// lbxServer
			// 
			this.lbxServer.FormattingEnabled = true;
			this.lbxServer.Location = new System.Drawing.Point(51, 109);
			this.lbxServer.Name = "lbxServer";
			this.lbxServer.Size = new System.Drawing.Size(324, 121);
			this.lbxServer.TabIndex = 4;
			// 
			// Server
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 308);
			this.Controls.Add(this.lbxServer);
			this.Controls.Add(this.txtConnection);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbText);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Name = "Server";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Server";
			this.Load += new System.EventHandler(this.Server_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lbText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtConnection;
		private System.Windows.Forms.ListBox lbxServer;
	}
}