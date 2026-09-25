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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace okatutreasure
{
    public partial class AjouterFourniseur : Form
    {
        public AjouterFourniseur()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=okatutreasure;Integrated Security=False;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO dbo.fournisseurs (nom, dateAjouter, AdresseFournisseur, TelephoneFournisseur) VALUES (@NomFournisseur, @DateAjouter, @AdresseFournisseur, @TelephoneFournisseur)", con))
                {
                    cmd.Parameters.AddWithValue("@NomFournisseur", nomFournisseur.Text); // Replace with actual TextBox names
                    cmd.Parameters.AddWithValue("@DateAjouter", DateTime.Today);
                    // Make sure the format is correct for SQL
                    cmd.Parameters.AddWithValue("@AdresseFournisseur", adresseFournisseur.Text); // Replace with actual TextBox names
                    cmd.Parameters.AddWithValue("@TelephoneFournisseur", telephoneFournisseur.Text); // Replace with actual TextBox names

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
                        MessageBox.Show("Fournisseur ajouté avec succès !");
                    }
                    else
                    {
                        
                        MessageBox.Show("Aucun fournisseur n'a été ajouté. Veuillez vérifier vos saisies et réessayer.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is always closed, even if an error occurs
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }



        private void AjouterFourniseur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okatutreasureDataSet7.fournisseurs' table. You can move, or remove it, as needed.
            this.fournisseursTableAdapter.Fill(this.okatutreasureDataSet7.fournisseurs);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void telephoneFournisseur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
