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
    public partial class ModifierManga : Form
    {
        public ModifierManga()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=okatutreasure;Integrated Security=False;Encrypt=False");




        public ModifierManga(string mangaTitre, string mangaNom, string mangaEditeur, string mangaGenre, string mangaLangue, string mangaNumeroVolume, string mangaIsbn, string mangaDateSortie, string mangaDateAchat, string mangaFournisseur, string mangaPrix, string mangaQuantite, string mangaEtat, string mangaId)
        {
            InitializeComponent();

            LoadData(mangaTitre, mangaNom, mangaEditeur, mangaGenre, mangaLangue, mangaNumeroVolume, mangaIsbn, mangaDateSortie, mangaDateAchat, mangaFournisseur, mangaPrix, mangaQuantite, mangaEtat,mangaId);
        }

        private void LoadData(string mangaTitre, string mangaNomAuteur, string mangaEditeur, string mangaGenre, string mangaLangue, string mangaNumeroVolume, string mangaIsbn, string mangaDateSortie, string mangaDateAchat, string mangaFournisseur, string mangaPrix, string mangaQuantite, string mangaEtat, string mangaId)
        {
            // Assuming you have text boxes or labels to display these properties, set their values here
            txtMangaTitre.Text = mangaTitre;
            txtMangaNomAuteur.Text = mangaNomAuteur;
            txtMangaEditeur.Text = mangaEditeur;
            txtMangaGenre.Text = mangaGenre;
            txtMangaLangue.Text = mangaLangue;
            txtNumeroVolume.Text = mangaNumeroVolume;
            txtIsbn.Text = mangaIsbn;
            txtDateSortie.Text = mangaDateSortie;
            txtDateAchat.Text = mangaDateAchat;
            txtFournisseur.Text = mangaFournisseur;
            txtPrix.Text = mangaPrix;
            txtQuantite.Text = mangaQuantite;
            txtEtat.Text = mangaEtat;
            txtId.Text = mangaId;
        }


        private void ModifierManga_Load(object sender, EventArgs e)
        {
            
            
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifierProduit_Click(object sender, EventArgs e)
        {
            string titre = txtMangaTitre.Text;
            string auteur = txtMangaNomAuteur.Text;
            string editeur = txtMangaEditeur.Text;
            string genre = txtMangaGenre.Text;
            string langue = txtMangaLangue.Text;
            int numeroVolume = int.Parse(txtNumeroVolume.Text); // assuming it's an integer
            string isbn = txtIsbn.Text;
            DateTime dateSortie = DateTime.Parse(txtDateSortie.Text); // assuming it's a date
            DateTime dateAchat = DateTime.Parse(txtDateAchat.Text); // assuming it's a date
            string fournisseur = txtFournisseur.Text;
            decimal prix = decimal.Parse(txtPrix.Text); // assuming it's a decimal number
            int quantite = int.Parse(txtQuantite.Text); // assuming it's an integer
            string etat = txtEtat.Text;
            string mangaId = txtId.Text;


           
            string updateQuery = @"UPDATE Produits SET 
                            Titre = @titre, 
                            Auteur = @auteur, 
                            Editeur = @editeur, 
                            Genre = @genre, 
                            Langue = @langue, 
                            NumeroDeVolume = @numeroVolume, 
                            ISBN = @isbn, 
                            DateDESortir = @dateSortie, 
                            DateAchat = @dateAchat, 
                            Founisseur = @fournisseur, 
                            Prix = @prix, 
                            QuantiteEnStock = @quantite, 
                            Etat = @etat
                          WHERE IdProduit = @mangaId";

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this manga?", "Confirm Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    // Open the connection to the database
                    con.Open();

                    // Create the SQL command
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        // Add the parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@titre", titre);
                        cmd.Parameters.AddWithValue("@auteur", auteur);
                        cmd.Parameters.AddWithValue("@editeur", editeur);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@langue", langue);
                        cmd.Parameters.AddWithValue("@numeroVolume", numeroVolume);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@dateSortie", dateSortie);
                        cmd.Parameters.AddWithValue("@dateAchat", dateAchat);
                        cmd.Parameters.AddWithValue("@fournisseur", fournisseur);
                        cmd.Parameters.AddWithValue("@prix", prix);
                        cmd.Parameters.AddWithValue("@quantite", quantite);
                        cmd.Parameters.AddWithValue("@etat", etat);
                        cmd.Parameters.AddWithValue("@mangaId", mangaId);

                        // Execute the SQL command
                        

                        int result = cmd.ExecuteNonQuery();

                        // Check if the update was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Manga updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the manga.", "No Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    con.Close();
                }
            }
            else
            {
                // The user decided not to proceed with the update
                MessageBox.Show("Update canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            private void txtMangaTitre_TextChanged(object sender, EventArgs e)
            {

            } 
    }
}
