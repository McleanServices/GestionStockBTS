namespace okatutreasure
{
    partial class Founisseur
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.okatutreasureDataSet6 = new okatutreasure.okatutreasureDataSet6();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.okatutreasureDataSet8 = new okatutreasure.okatutreasureDataSet8();
            this.fournisseursTableAdapter = new okatutreasure.okatutreasureDataSet8TableAdapters.fournisseursTableAdapter();
            this.okatutreasureDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAjouterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneFournisseurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "fournisseurs";
            this.bindingSource1.DataSource = this.okatutreasureDataSet8;
            // 
            // okatutreasureDataSet6
            // 
            this.okatutreasureDataSet6.DataSetName = "okatutreasureDataSet6";
            this.okatutreasureDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumnName,
            this.nomDataGridViewTextBoxColumn,
            this.dateAjouterDataGridViewTextBoxColumn,
            this.adresseFournisseurDataGridViewTextBoxColumn,
            this.telephoneFournisseurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(311, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 441);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(951, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::okatutreasure.Properties.Resources.Frame_8;
            this.pictureBox1.Location = new System.Drawing.Point(-28, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 768);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1133, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // okatutreasureDataSet8
            // 
            this.okatutreasureDataSet8.DataSetName = "okatutreasureDataSet8";
            this.okatutreasureDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fournisseursTableAdapter
            // 
            this.fournisseursTableAdapter.ClearBeforeFill = true;
            // 
            // okatutreasureDataSet8BindingSource
            // 
            this.okatutreasureDataSet8BindingSource.DataSource = this.okatutreasureDataSet8;
            this.okatutreasureDataSet8BindingSource.Position = 0;
            // 
            // IdColumnName
            // 
            this.IdColumnName.DataPropertyName = "idFourniseur";
            this.IdColumnName.HeaderText = "idFourniseur";
            this.IdColumnName.Name = "IdColumnName";
            this.IdColumnName.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // dateAjouterDataGridViewTextBoxColumn
            // 
            this.dateAjouterDataGridViewTextBoxColumn.DataPropertyName = "dateAjouter";
            this.dateAjouterDataGridViewTextBoxColumn.HeaderText = "dateAjouter";
            this.dateAjouterDataGridViewTextBoxColumn.Name = "dateAjouterDataGridViewTextBoxColumn";
            // 
            // adresseFournisseurDataGridViewTextBoxColumn
            // 
            this.adresseFournisseurDataGridViewTextBoxColumn.DataPropertyName = "AdresseFournisseur";
            this.adresseFournisseurDataGridViewTextBoxColumn.HeaderText = "AdresseFournisseur";
            this.adresseFournisseurDataGridViewTextBoxColumn.Name = "adresseFournisseurDataGridViewTextBoxColumn";
            // 
            // telephoneFournisseurDataGridViewTextBoxColumn
            // 
            this.telephoneFournisseurDataGridViewTextBoxColumn.DataPropertyName = "TelephoneFournisseur";
            this.telephoneFournisseurDataGridViewTextBoxColumn.HeaderText = "TelephoneFournisseur";
            this.telephoneFournisseurDataGridViewTextBoxColumn.Name = "telephoneFournisseurDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(968, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "recharge";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Founisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Founisseur";
            this.Text = "Founisseur";
            this.Load += new System.EventHandler(this.Founisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okatutreasureDataSet8BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private okatutreasureDataSet6 okatutreasureDataSet6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private okatutreasureDataSet8 okatutreasureDataSet8;
        private okatutreasureDataSet8TableAdapters.fournisseursTableAdapter fournisseursTableAdapter;
        private System.Windows.Forms.BindingSource okatutreasureDataSet8BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAjouterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneFournisseurDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}