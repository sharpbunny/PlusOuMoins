namespace Plus_Ou_Moins
{
    partial class Jeu
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
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Plus_Ou_Moins.Properties.Resources.espace1;
            this.ClientSize = new System.Drawing.Size(310, 374);
            this.Controls.Add(this.titreDuJeu);
            this.Name = "Jeu";
            this.Text = "Plus Ou Moins";
            ((System.ComponentModel.ISupportInitialize)(this.titreDuJeu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox titreDuJeu;
    }
}