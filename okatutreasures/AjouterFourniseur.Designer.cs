namespace okatutreasure
{
    partial class AjouterFourniseur
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomFournisseur = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.okatutreasureDataSet7 = new okatutreasure.okatutreasureDataSet7();
            this.adresseFournisseur = new System.Windows.Forms.TextBox();
            this.telephoneFournisseur = new System.Windows.Forms.TextBox();
            this.fournisseursTableAdapter = new okatutreasure.okatutreasureDataSet7TableAdapters.fournisseursTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::okatutreasure.Properties.Resources.Frame_9_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 441);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nomFournisseur
            // 
            this.nomFournisseur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomFournisseur.Location = new System.Drawing.Point(50, 140);
            this.nomFournisseur.Name = "nomFournisseur";
            this.nomFournisseur.Size = new System.Drawing.Size(370, 26);
            this.nomFournisseur.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "fournisseurs";
            this.bindingSource1.DataSource = this.okatutreasureDataSet7;
            // 
            // okatutreasureDataSet7
            // 
            this.okatutreasureDataSet7.DataSetName = "okatutreasureDataSet7";
            this.okatutreasureDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adresseFournisseur
            // 
            this.adresseFournisseur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseFournisseur.Location = new System.Drawing.Point(50, 191);
            this.adresseFournisseur.Name = "adresseFournisseur";
            this.adresseFournisseur.Size = new System.Drawing.Size(370, 26);
            this.adresseFournisseur.TabIndex = 5;
            // 
            // telephoneFournisseur
            // 
            this.telephoneFournisseur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneFournisseur.Location = new System.Drawing.Point(48, 234);
            this.telephoneFournisseur.Name = "telephoneFournisseur";
            this.telephoneFournisseur.Size = new System.Drawing.Size(370, 26);
            this.telephoneFournisseur.TabIndex = 6;
            this.telephoneFournisseur.TextChanged += new System.EventHandler(this.telephoneFournisseur_TextChanged);
            // 
            // fournisseursTableAdapter
            // 
            this.fournisseursTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "nom founisseur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "adresse founisseur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "numero de telephone founisseur";
            // 
            // AjouterFourniseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 439);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telephoneFournisseur);
            this.Controls.Add(this.adresseFournisseur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomFournisseur);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AjouterFourniseur";
            this.Text = "AjouterFourniseur";
            this.Load += new System.EventHandler(this.AjouterFourniseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nomFournisseur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private okatutreasureDataSet7 okatutreasureDataSet7;
        private System.Windows.Forms.TextBox adresseFournisseur;
        private System.Windows.Forms.TextBox telephoneFournisseur;
        private okatutreasureDataSet7TableAdapters.fournisseursTableAdapter fournisseursTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}