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
            this.buttonStats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.titreDuJeu)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(93, 290);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(128, 36);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Quitter";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(93, 122);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(128, 36);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Jouer";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(93, 206);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(128, 36);
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
            this.buttonComputer.Location = new System.Drawing.Point(93, 164);
            this.buttonComputer.Name = "buttonComputer";
            this.buttonComputer.Size = new System.Drawing.Size(128, 36);
            this.buttonComputer.TabIndex = 4;
            this.buttonComputer.Text = "L\'ordinateur joue";
            this.buttonComputer.UseVisualStyleBackColor = true;
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(93, 248);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(128, 36);
            this.buttonStats.TabIndex = 5;
            this.buttonStats.Text = "Statistiques";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Facile : 0 à 100";
            // 
            // wfPlusOuMoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Plus_Ou_Moins.Properties.Resources.espace1;
            this.ClientSize = new System.Drawing.Size(310, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStats);
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
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.PictureBox titreDuJeu;
		private System.Windows.Forms.Button buttonPlay;
		private System.Windows.Forms.Button buttonOptions;
		private System.Windows.Forms.Button buttonComputer;
        private System.Windows.Forms.Button buttonStats;
        public System.Windows.Forms.Label label1;
    }
}