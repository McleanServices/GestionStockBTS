namespace okatutreasure
{
    partial class ModifierManga
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
            this.txtMangaTitre = new System.Windows.Forms.TextBox();
            this.txtMangaNomAuteur = new System.Windows.Forms.TextBox();
            this.txtMangaEditeur = new System.Windows.Forms.TextBox();
            this.txtMangaGenre = new System.Windows.Forms.TextBox();
            this.txtMangaLangue = new System.Windows.Forms.TextBox();
            this.txtNumeroVolume = new System.Windows.Forms.TextBox();
            this.txtFournisseur = new System.Windows.Forms.TextBox();
            this.txtDateAchat = new System.Windows.Forms.TextBox();
            this.txtDateSortie = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtEtat = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.ModifierProduit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMangaTitre
            // 
            this.txtMangaTitre.Location = new System.Drawing.Point(164, 68);
            this.txtMangaTitre.Name = "txtMangaTitre";
            this.txtMangaTitre.Size = new System.Drawing.Size(100, 20);
            this.txtMangaTitre.TabIndex = 0;
            this.txtMangaTitre.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // txtMangaNomAuteur
            // 
            this.txtMangaNomAuteur.Location = new System.Drawing.Point(164, 129);
            this.txtMangaNomAuteur.Name = "txtMangaNomAuteur";
            this.txtMangaNomAuteur.Size = new System.Drawing.Size(100, 20);
            this.txtMangaNomAuteur.TabIndex = 1;
            // 
            // txtMangaEditeur
            // 
            this.txtMangaEditeur.Location = new System.Drawing.Point(164, 192);
            this.txtMangaEditeur.Name = "txtMangaEditeur";
            this.txtMangaEditeur.Size = new System.Drawing.Size(100, 20);
            this.txtMangaEditeur.TabIndex = 2;
            // 
            // txtMangaGenre
            // 
            this.txtMangaGenre.Location = new System.Drawing.Point(164, 259);
            this.txtMangaGenre.Name = "txtMangaGenre";
            this.txtMangaGenre.Size = new System.Drawing.Size(100, 20);
            this.txtMangaGenre.TabIndex = 3;
            // 
            // txtMangaLangue
            // 
            this.txtMangaLangue.Location = new System.Drawing.Point(164, 322);
            this.txtMangaLangue.Name = "txtMangaLangue";
            this.txtMangaLangue.Size = new System.Drawing.Size(100, 20);
            this.txtMangaLangue.TabIndex = 4;
            // 
            // txtNumeroVolume
            // 
            this.txtNumeroVolume.Location = new System.Drawing.Point(329, 68);
            this.txtNumeroVolume.Name = "txtNumeroVolume";
            this.txtNumeroVolume.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroVolume.TabIndex = 5;
            // 
            // txtFournisseur
            // 
            this.txtFournisseur.Location = new System.Drawing.Point(329, 322);
            this.txtFournisseur.Name = "txtFournisseur";
            this.txtFournisseur.Size = new System.Drawing.Size(100, 20);
            this.txtFournisseur.TabIndex = 6;
            // 
            // txtDateAchat
            // 
            this.txtDateAchat.Location = new System.Drawing.Point(329, 259);
            this.txtDateAchat.Name = "txtDateAchat";
            this.txtDateAchat.Size = new System.Drawing.Size(100, 20);
            this.txtDateAchat.TabIndex = 7;
            // 
            // txtDateSortie
            // 
            this.txtDateSortie.Location = new System.Drawing.Point(329, 189);
            this.txtDateSortie.Name = "txtDateSortie";
            this.txtDateSortie.Size = new System.Drawing.Size(100, 20);
            this.txtDateSortie.TabIndex = 8;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(329, 129);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtIsbn.TabIndex = 9;
            // 
            // txtEtat
            // 
            this.txtEtat.Location = new System.Drawing.Point(464, 189);
            this.txtEtat.Name = "txtEtat";
            this.txtEtat.Size = new System.Drawing.Size(100, 20);
            this.txtEtat.TabIndex = 10;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(464, 129);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(100, 20);
            this.txtQuantite.TabIndex = 11;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(464, 68);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 12;
            // 
            // ModifierProduit
            // 
            this.ModifierProduit.Location = new System.Drawing.Point(495, 322);
            this.ModifierProduit.Name = "ModifierProduit";
            this.ModifierProduit.Size = new System.Drawing.Size(75, 23);
            this.ModifierProduit.TabIndex = 13;
            this.ModifierProduit.Text = "button1";
            this.ModifierProduit.UseVisualStyleBackColor = true;
            this.ModifierProduit.Click += new System.EventHandler(this.ModifierProduit_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(470, 259);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 14;
            
            // 
            // ModifierManga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.ModifierProduit);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtEtat);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtDateSortie);
            this.Controls.Add(this.txtDateAchat);
            this.Controls.Add(this.txtFournisseur);
            this.Controls.Add(this.txtNumeroVolume);
            this.Controls.Add(this.txtMangaLangue);
            this.Controls.Add(this.txtMangaGenre);
            this.Controls.Add(this.txtMangaEditeur);
            this.Controls.Add(this.txtMangaNomAuteur);
            this.Controls.Add(this.txtMangaTitre);
            this.Name = "ModifierManga";
            this.Text = "ModifierManga";
            this.Load += new System.EventHandler(this.ModifierManga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMangaTitre;
        private System.Windows.Forms.TextBox txtMangaNomAuteur;
        private System.Windows.Forms.TextBox txtMangaEditeur;
        private System.Windows.Forms.TextBox txtMangaGenre;
        private System.Windows.Forms.TextBox txtMangaLangue;
        private System.Windows.Forms.TextBox txtNumeroVolume;
        private System.Windows.Forms.TextBox txtFournisseur;
        private System.Windows.Forms.TextBox txtDateAchat;
        private System.Windows.Forms.TextBox txtDateSortie;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtEtat;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Button ModifierProduit;
        private System.Windows.Forms.TextBox txtId;
    }
}