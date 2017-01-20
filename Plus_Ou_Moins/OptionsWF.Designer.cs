namespace Plus_Ou_Moins
{
	partial class OptionsWF
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
			this.titreDuJeu = new System.Windows.Forms.PictureBox();
			this.buttonMenu = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.labelDifficult = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.titreDuJeu)).BeginInit();
			this.SuspendLayout();
			// 
			// titreDuJeu
			// 
			this.titreDuJeu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.titreDuJeu.BackgroundImage = global::Plus_Ou_Moins.Properties.Resources.Titre_Du_Jeu1;
			this.titreDuJeu.Location = new System.Drawing.Point(0, 0);
			this.titreDuJeu.Name = "titreDuJeu";
			this.titreDuJeu.Size = new System.Drawing.Size(310, 100);
			this.titreDuJeu.TabIndex = 2;
			this.titreDuJeu.TabStop = false;
			// 
			// buttonMenu
			// 
			this.buttonMenu.Location = new System.Drawing.Point(91, 311);
			this.buttonMenu.Name = "buttonMenu";
			this.buttonMenu.Size = new System.Drawing.Size(128, 51);
			this.buttonMenu.TabIndex = 3;
			this.buttonMenu.Text = "Retour au menu";
			this.buttonMenu.UseVisualStyleBackColor = true;
			this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Novice : 0 à 10",
            "Facile : 0 à 100",
            "Normal : 0 à 500",
            "Difficile : 0 à 1000",
            "Extrême : 0 à 5000",
            "God : 0 à 5000 et nombre de coups limités"});
			this.comboBox1.Location = new System.Drawing.Point(50, 132);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(211, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// labelDifficult
			// 
			this.labelDifficult.AutoSize = true;
			this.labelDifficult.Location = new System.Drawing.Point(105, 116);
			this.labelDifficult.Name = "labelDifficult";
			this.labelDifficult.Size = new System.Drawing.Size(91, 13);
			this.labelDifficult.TabIndex = 5;
			this.labelDifficult.Text = "Mode de difficulté";
			// 
			// OptionsWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 374);
			this.Controls.Add(this.labelDifficult);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.buttonMenu);
			this.Controls.Add(this.titreDuJeu);
			this.Name = "OptionsWF";
			this.Text = "OptionsWF";
			((System.ComponentModel.ISupportInitialize)(this.titreDuJeu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox titreDuJeu;
		private System.Windows.Forms.Button buttonMenu;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label labelDifficult;
	}
}