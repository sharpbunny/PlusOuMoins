namespace Plus_Ou_Moins
{
	partial class wfPlusOuMoins
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
			this.buttonExit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonPlay = new System.Windows.Forms.Button();
			this.buttonOptions = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(93, 311);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(128, 51);
			this.buttonExit.TabIndex = 0;
			this.buttonExit.Text = "Quitter";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox1.Location = new System.Drawing.Point(0, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(311, 108);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// buttonPlay
			// 
			this.buttonPlay.Location = new System.Drawing.Point(93, 144);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(128, 51);
			this.buttonPlay.TabIndex = 2;
			this.buttonPlay.Text = "Jouer";
			this.buttonPlay.UseVisualStyleBackColor = true;
			// 
			// buttonOptions
			// 
			this.buttonOptions.Location = new System.Drawing.Point(93, 227);
			this.buttonOptions.Name = "buttonOptions";
			this.buttonOptions.Size = new System.Drawing.Size(128, 51);
			this.buttonOptions.TabIndex = 3;
			this.buttonOptions.Text = "Options";
			this.buttonOptions.UseVisualStyleBackColor = true;
			// 
			// wfPlusOuMoins
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 374);
			this.Controls.Add(this.buttonOptions);
			this.Controls.Add(this.buttonPlay);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonExit);
			this.Name = "wfPlusOuMoins";
			this.Text = "Plus Ou Moins";
			this.Load += new System.EventHandler(this.wfPlusOuMoins_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonPlay;
		private System.Windows.Forms.Button buttonOptions;
	}
}