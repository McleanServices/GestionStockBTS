using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okatutreasure
{
    public partial class Founisseur : Form
    {
        public Founisseur()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=okatutreasure;Integrated Security=False;Encrypt=False");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Founisseur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okatutreasureDataSet8.fournisseurs' table. You can move, or remove it, as needed.
            this.fournisseursTableAdapter.Fill(this.okatutreasureDataSet8.fournisseurs);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            



            
            

            // Example: Let's say your DataGridView has a Delete button in the last column.
            var senderGrid = (DataGridView)sender;

            // Check if the click is on the Delete button cell.
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // Confirm the deletion with the user
                if (MessageBox.Show("Are you sure you want to delete this row?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Assuming the first column contains the identifier for deletion.
                    int idToDelete = Convert.ToInt32(senderGrid[0, e.RowIndex].Value);

                    // TODO: Replace with your actual connection string.
                    string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=okatutreasure;Integrated Security=False;Encrypt=False";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string deleteQuery = "DELETE FROM dbo.fournisseurs WHERE IdFournisseur = @IdFournisseur";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@IdFournisseur", idToDelete);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Remove the row from the DataGridView.
                    senderGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Confirm the deletion with the user
                if (MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Get the primary key value of the first selected row.
                    int idToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdColumnName"].Value);

                    // TODO: Replace with your actual connection string.
              

                    using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=okatutreasure;Integrated Security=False;Encrypt=False"))
                    {
                        string deleteQuery = "DELETE FROM dbo.fournisseurs WHERE idFourniseur = @IdFournisseur";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@IdFournisseur", idToDelete);
                            conn.Open();
                            int result = cmd.ExecuteNonQuery();
                            // Check if any row is deleted, if yes then remove from DataGridView as well
                            if (result > 0)
                            {
                                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                            }
                            else
                            {
                                MessageBox.Show("The row could not be deleted.", "Deletion Failed");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open form to add fournisseur
            AjouterFourniseur addFournisseur = new AjouterFourniseur();
            addFournisseur.ShowDialog();

        }

        private void rechargebdd_Click(object sender, EventArgs e)
        {
            //refresh the data grid view
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //refresh the data grid view
            this.fournisseursTableAdapter.Fill(this.okatutreasureDataSet8.fournisseurs);

        }

        private void buttonProduits_Click(object sender, EventArgs e)
        {
            Produits a = new Produits();
            a.Show();
            this.Hide();
        }
    }
}
