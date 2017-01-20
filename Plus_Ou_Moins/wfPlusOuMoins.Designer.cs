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
			this.buttonPlay = new System.Windows.Forms.Button();
			this.buttonOptions = new System.Windows.Forms.Button();
			this.titreDuJeu = new System.Windows.Forms.PictureBox();
			this.buttonComputer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.titreDuJeu)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(93, 293);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(128, 51);
			this.buttonExit.TabIndex = 0;
			this.buttonExit.Text = "Quitter";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonPlay
			// 
			this.buttonPlay.Location = new System.Drawing.Point(93, 122);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(128, 51);
			this.buttonPlay.TabIndex = 2;
			this.buttonPlay.Text = "Jouer";
			this.buttonPlay.UseVisualStyleBackColor = true;
			// 
			// buttonOptions
			// 
			this.buttonOptions.Location = new System.Drawing.Point(93, 236);
			this.buttonOptions.Name = "buttonOptions";
			this.buttonOptions.Size = new System.Drawing.Size(128, 51);
			this.buttonOptions.TabIndex = 3;
			this.buttonOptions.Text = "Options";
			this.buttonOptions.UseVisualStyleBackColor = true;
			this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
			// 
			// titreDuJeu
			// 
			this.titreDuJeu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.titreDuJeu.BackgroundImage = global::Plus_Ou_Moins.Properties.Resources.Titre_Du_Jeu1;
			this.titreDuJeu.Location = new System.Drawing.Point(0, 0);
			this.titreDuJeu.Name = "titreDuJeu";
			this.titreDuJeu.Size = new System.Drawing.Size(310, 100);
			this.titreDuJeu.TabIndex = 1;
			this.titreDuJeu.TabStop = false;
			// 
			// buttonComputer
			// 
			this.buttonComputer.Location = new System.Drawing.Point(93, 179);
			this.buttonComputer.Name = "buttonComputer";
			this.buttonComputer.Size = new System.Drawing.Size(128, 51);
			this.buttonComputer.TabIndex = 4;
			this.buttonComputer.Text = "L\'ordinateur joue";
			this.buttonComputer.UseVisualStyleBackColor = true;
			// 
			// wfPlusOuMoins
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 374);
			this.Controls.Add(this.buttonComputer);
			this.Controls.Add(this.buttonOptions);
			this.Controls.Add(this.buttonPlay);
			this.Controls.Add(this.titreDuJeu);
			this.Controls.Add(this.buttonExit);
			this.Name = "wfPlusOuMoins";
			this.Text = "Plus Ou Moins";
			this.Load += new System.EventHandler(this.wfPlusOuMoins_Load);
			((System.ComponentModel.ISupportInitialize)(this.titreDuJeu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.PictureBox titreDuJeu;
		private System.Windows.Forms.Button buttonPlay;
		private System.Windows.Forms.Button buttonOptions;
		private System.Windows.Forms.Button buttonComputer;
	}
}