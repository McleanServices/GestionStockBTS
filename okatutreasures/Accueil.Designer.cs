namespace okatutreasure
{
    partial class Accueil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produitsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.okatutreasureDataSet2 = new okatutreasure.okatutreasureDataSet2();
            this.produitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okatutreasureDataSet1 = new okatutreasure.okatutreasureDataSet1();
            this.okatutreasureDataSet = new okatutreasure.okatutreasureDataSet();
            this.produitsTableAdapter = new okatutreasure.okatutreasureDataSet1TableAdapters.ProduitsTableAdapter();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.produitsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produitsTableAdapter1 = new okatutreasure.okatutreasureDataSet2TableAdapters.ProduitsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modifierproduit = new System.Windows.Forms.Button();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editeurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDeVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDESortirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAchatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.founisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteEnStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rechercheProduit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1145, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "+ Nouveau manga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(325, 611);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(924, 24);
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titreDataGridViewTextBoxColumn,
            this.auteurDataGridViewTextBoxColumn,
            this.editeurDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.langueDataGridViewTextBoxColumn,
            this.numeroDeVolumeDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.dateDESortirDataGridViewTextBoxColumn,
            this.dateAchatDataGridViewTextBoxColumn,
            this.founisseurDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.quantiteEnStockDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn,
            this.IdProduit});
            this.dataGridView1.DataSource = this.produitsBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(325, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 452);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // produitsBindingSource2
            // 
            this.produitsBindingSource2.DataMember = "Produits";
            this.produitsBindingSource2.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.okatutreasureDataSet2;
            this.bindingSource1.Position = 0;
            // 
            // okatutreasureDataSet2
            // 
            this.okatutreasureDataSet2.DataSetName = "okatutreasureDataSet2";
            this.okatutreasureDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitsBindingSource
            // 
            this.produitsBindingSource.DataSource = this.bindingSource1;
            this.produitsBindingSource.Position = 0;
            // 
            // okatutreasureDataSet1
            // 
            this.okatutreasureDataSet1.DataSetName = "okatutreasureDataSet1";
            this.okatutreasureDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // okatutreasureDataSet
            // 
            this.okatutreasureDataSet.DataSetName = "okatutreasureDataSet";
            this.okatutreasureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitsTableAdapter
            // 
            this.produitsTableAdapter.ClearBeforeFill = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // produitsBindingSource1
            // 
            this.produitsBindingSource1.DataMember = "Produits";
            this.produitsBindingSource1.DataSource = this.bindingSource1;
            // 
            // produitsTableAdapter1
            // 
            this.produitsTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1032, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Filtrer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "REACTUALISER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(42, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "Produits";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(42, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 34);
            this.button5.TabIndex = 8;
            this.button5.Text = "Fournisseurs";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::okatutreasure.Properties.Resources.Accueil;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1351, 767);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // modifierproduit
            // 
            this.modifierproduit.Location = new System.Drawing.Point(1263, 222);
            this.modifierproduit.Name = "modifierproduit";
            this.modifierproduit.Size = new System.Drawing.Size(75, 23);
            this.modifierproduit.TabIndex = 9;
            this.modifierproduit.Text = "modifier";
            this.modifierproduit.UseVisualStyleBackColor = true;
            this.modifierproduit.Click += new System.EventHandler(this.modifierproduit_Click);
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            // 
            // auteurDataGridViewTextBoxColumn
            // 
            this.auteurDataGridViewTextBoxColumn.DataPropertyName = "Auteur";
            this.auteurDataGridViewTextBoxColumn.HeaderText = "Auteur";
            this.auteurDataGridViewTextBoxColumn.Name = "auteurDataGridViewTextBoxColumn";
            // 
            // editeurDataGridViewTextBoxColumn
            // 
            this.editeurDataGridViewTextBoxColumn.DataPropertyName = "Editeur";
            this.editeurDataGridViewTextBoxColumn.HeaderText = "Editeur";
            this.editeurDataGridViewTextBoxColumn.Name = "editeurDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // langueDataGridViewTextBoxColumn
            // 
            this.langueDataGridViewTextBoxColumn.DataPropertyName = "Langue";
            this.langueDataGridViewTextBoxColumn.HeaderText = "Langue";
            this.langueDataGridViewTextBoxColumn.Name = "langueDataGridViewTextBoxColumn";
            // 
            // numeroDeVolumeDataGridViewTextBoxColumn
            // 
            this.numeroDeVolumeDataGridViewTextBoxColumn.DataPropertyName = "NumeroDeVolume";
            this.numeroDeVolumeDataGridViewTextBoxColumn.HeaderText = "NumeroDeVolume";
            this.numeroDeVolumeDataGridViewTextBoxColumn.Name = "numeroDeVolumeDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // dateDESortirDataGridViewTextBoxColumn
            // 
            this.dateDESortirDataGridViewTextBoxColumn.DataPropertyName = "DateDESortir";
            this.dateDESortirDataGridViewTextBoxColumn.HeaderText = "DateDESortir";
            this.dateDESortirDataGridViewTextBoxColumn.Name = "dateDESortirDataGridViewTextBoxColumn";
            // 
            // dateAchatDataGridViewTextBoxColumn
            // 
            this.dateAchatDataGridViewTextBoxColumn.DataPropertyName = "DateAchat";
            this.dateAchatDataGridViewTextBoxColumn.HeaderText = "DateAchat";
            this.dateAchatDataGridViewTextBoxColumn.Name = "dateAchatDataGridViewTextBoxColumn";
            // 
            // founisseurDataGridViewTextBoxColumn
            // 
            this.founisseurDataGridViewTextBoxColumn.DataPropertyName = "Founisseur";
            this.founisseurDataGridViewTextBoxColumn.HeaderText = "Founisseur";
            this.founisseurDataGridViewTextBoxColumn.Name = "founisseurDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // quantiteEnStockDataGridViewTextBoxColumn
            // 
            this.quantiteEnStockDataGridViewTextBoxColumn.DataPropertyName = "QuantiteEnStock";
            this.quantiteEnStockDataGridViewTextBoxColumn.HeaderText = "QuantiteEnStock";
            this.quantiteEnStockDataGridViewTextBoxColumn.Name = "quantiteEnStockDataGridViewTextBoxColumn";
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "Etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            // 
            // IdProduit
            // 
            this.IdProduit.DataPropertyName = "IdProduit";
            this.IdProduit.HeaderText = "IdProduit";
            this.IdProduit.Name = "IdProduit";
            this.IdProduit.ReadOnly = true;
            // 
            // rechercheProduit
            // 
            this.rechercheProduit.Location = new System.Drawing.Point(479, 176);
            this.rechercheProduit.Name = "rechercheProduit";
            this.rechercheProduit.Size = new System.Drawing.Size(475, 20);
            this.rechercheProduit.TabIndex = 10;
            this.rechercheProduit.TextChanged += new System.EventHandler(this.rechercheProduit_TextChanged);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.rechercheProduit);
            this.Controls.Add(this.modifierproduit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private okatutreasureDataSet1 okatutreasureDataSet1;
        private okatutreasureDataSet okatutreasureDataSet;
        private System.Windows.Forms.BindingSource produitsBindingSource;
        private okatutreasureDataSet1TableAdapters.ProduitsTableAdapter produitsTableAdapter;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private okatutreasureDataSet2 okatutreasureDataSet2;
        private System.Windows.Forms.BindingSource produitsBindingSource1;
        private System.Windows.Forms.BindingSource produitsBindingSource2;
        private okatutreasureDataSet2TableAdapters.ProduitsTableAdapter produitsTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button modifierproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editeurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDeVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDESortirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAchatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn founisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteEnStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduit;
        private System.Windows.Forms.TextBox rechercheProduit;
    }
}