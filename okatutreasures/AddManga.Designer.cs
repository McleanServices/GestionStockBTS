namespace okatutreasure
{
    partial class AddManga
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
            this.components = new System.ComponentModel.Container();
            this.titre = new System.Windows.Forms.TextBox();
            this.auteur = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editeur = new System.Windows.Forms.TextBox();
            this.langue = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.quantitestock = new System.Windows.Forms.TextBox();
            this.etat = new System.Windows.Forms.TextBox();
            this.volume = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.datesortie = new System.Windows.Forms.TextBox();
            this.dateachat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.okatutreasureDataSet3 = new okatutreasure.okatutreasureDataSet3();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fournisseur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresTableAdapter = new okatutreasure.okatutreasureDataSet3TableAdapters.GenresTableAdapter();
            this.produitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitsTableAdapter = new okatutreasure.okatutreasureDataSet3TableAdapters.ProduitsTableAdapter();
            this.genresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genre = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(2, 3);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(204, 22);
            this.titre.TabIndex = 5;
            this.titre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // auteur
            // 
            this.auteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.auteur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auteur.Location = new System.Drawing.Point(258, 181);
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(207, 29);
            this.auteur.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.titre);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(258, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 28);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // editeur
            // 
            this.editeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editeur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeur.Location = new System.Drawing.Point(257, 227);
            this.editeur.Name = "editeur";
            this.editeur.Size = new System.Drawing.Size(207, 29);
            this.editeur.TabIndex = 8;
            // 
            // langue
            // 
            this.langue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.langue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langue.Location = new System.Drawing.Point(257, 315);
            this.langue.Name = "langue";
            this.langue.Size = new System.Drawing.Size(207, 29);
            this.langue.TabIndex = 10;
            // 
            // prix
            // 
            this.prix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prix.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.Location = new System.Drawing.Point(50, 409);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(120, 29);
            this.prix.TabIndex = 11;
            // 
            // quantitestock
            // 
            this.quantitestock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantitestock.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitestock.Location = new System.Drawing.Point(189, 409);
            this.quantitestock.Name = "quantitestock";
            this.quantitestock.Size = new System.Drawing.Size(120, 29);
            this.quantitestock.TabIndex = 12;
            // 
            // etat
            // 
            this.etat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etat.Location = new System.Drawing.Point(327, 409);
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(137, 29);
            this.etat.TabIndex = 13;
            // 
            // volume
            // 
            this.volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volume.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.Location = new System.Drawing.Point(540, 137);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(207, 29);
            this.volume.TabIndex = 14;
            // 
            // isbn
            // 
            this.isbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isbn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.Location = new System.Drawing.Point(540, 181);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(207, 29);
            this.isbn.TabIndex = 15;
            // 
            // datesortie
            // 
            this.datesortie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datesortie.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesortie.Location = new System.Drawing.Point(538, 227);
            this.datesortie.Name = "datesortie";
            this.datesortie.Size = new System.Drawing.Size(207, 29);
            this.datesortie.TabIndex = 16;
            // 
            // dateachat
            // 
            this.dateachat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateachat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateachat.Location = new System.Drawing.Point(539, 272);
            this.dateachat.Name = "dateachat";
            this.dateachat.Size = new System.Drawing.Size(207, 29);
            this.dateachat.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Titre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "Auteur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Editeur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Genre:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // genresBindingSource2
            // 
            this.genresBindingSource2.DataMember = "Genres";
            this.genresBindingSource2.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.okatutreasureDataSet3;
            this.bindingSource1.Position = 0;
            // 
            // okatutreasureDataSet3
            // 
            this.okatutreasureDataSet3.DataSetName = "okatutreasureDataSet3";
            this.okatutreasureDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(542, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "Numero de volume:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "Langue:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(542, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 14);
            this.label8.TabIndex = 26;
            this.label8.Text = "ISBN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(542, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 14);
            this.label9.TabIndex = 27;
            this.label9.Text = "Date de sortie:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(542, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 28;
            this.label10.Text = "Date d\'achat:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 14);
            this.label11.TabIndex = 29;
            this.label11.Text = "Prix:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(194, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 14);
            this.label12.TabIndex = 30;
            this.label12.Text = "Quantite en stock:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(330, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 14);
            this.label13.TabIndex = 31;
            this.label13.Text = "Etat:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(536, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 41);
            this.button1.TabIndex = 32;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(50, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 234);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::okatutreasure.Properties.Resources.v2AjouterProduit;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(799, 448);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // fournisseur
            // 
            this.fournisseur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fournisseur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fournisseur.Location = new System.Drawing.Point(539, 315);
            this.fournisseur.Name = "fournisseur";
            this.fournisseur.Size = new System.Drawing.Size(207, 29);
            this.fournisseur.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fournisseur:";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.bindingSource1;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // produitsBindingSource
            // 
            this.produitsBindingSource.DataMember = "Produits";
            this.produitsBindingSource.DataSource = this.bindingSource1;
            // 
            // produitsTableAdapter
            // 
            this.produitsTableAdapter.ClearBeforeFill = true;
            // 
            // genresBindingSource1
            // 
            this.genresBindingSource1.DataMember = "Genres";
            this.genresBindingSource1.DataSource = this.bindingSource1;
            // 
            // genre
            // 
            this.genre.DataSource = this.genresBindingSource2;
            this.genre.DisplayMember = "Genre";
            this.genre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.FormattingEnabled = true;
            this.genre.Location = new System.Drawing.Point(257, 272);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(207, 29);
            this.genre.TabIndex = 35;
            // 
            // AddManga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fournisseur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateachat);
            this.Controls.Add(this.datesortie);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.etat);
            this.Controls.Add(this.quantitestock);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.langue);
            this.Controls.Add(this.editeur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.auteur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AddManga";
            this.Text = "AddManga";
            this.Load += new System.EventHandler(this.AddManga_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox titre;
        private System.Windows.Forms.TextBox auteur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox editeur;
        private System.Windows.Forms.TextBox langue;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.TextBox quantitestock;
        private System.Windows.Forms.TextBox etat;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox datesortie;
        private System.Windows.Forms.TextBox dateachat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private okatutreasureDataSet3 okatutreasureDataSet3;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private okatutreasureDataSet3TableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.BindingSource produitsBindingSource;
        private okatutreasureDataSet3TableAdapters.ProduitsTableAdapter produitsTableAdapter;
        private System.Windows.Forms.BindingSource genresBindingSource1;
        private System.Windows.Forms.BindingSource genresBindingSource2;
        private System.Windows.Forms.ComboBox genre;
    }
}