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
    public partial class Produits : Form
    {
        public Produits()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=okatutreasure;Integrated Security=False;Encrypt=False");
        private void Produits_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okatutreasureProduits.Produits' table. You can move, or remove it, as needed.
            this.produitsTableAdapter.Fill(this.okatutreasureProduits.Produits);

        }

        public void SetUserRoleAndPermissions(string username)
        {

            string userRole = username;


            switch (userRole)
            {
                case "Administrateur":


                    break;
                case "Gestionnaire":

                    founisseurDataGridViewTextBoxColumn.Visible = false;
                    

                    break;
                case "PersonnelVente":


                    break;
                default:
                    // Set default or guest permissions
                    break;
            }
        }

        private void buttonAjouterProduits_Click(object sender, EventArgs e)
        {
            AddManga addManga = new AddManga();
            addManga.Show();

            this.Opacity = 0.9;


            addManga.FormClosed += (s, args) => this.Opacity = 1;
        }

        private void buttonModifierProduits_Click(object sender, EventArgs e)
        {
            
        }

        private void actualiser_Click(object sender, EventArgs e)
        {
            this.produitsTableAdapter.Fill(this.okatutreasureProduits.Produits);

            // Refresh the DataGridView to show the updated data
            dataGridViewProduits.Refresh();
        }

        private void ModifierProduit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduits.SelectedRows.Count > 0)
            {
                string mangaTitre = dataGridViewProduits.SelectedRows[0].Cells[0].Value.ToString();
                string mangaNomAuteur = dataGridViewProduits.SelectedRows[0].Cells[1].Value.ToString();
                string mangaEditeur = dataGridViewProduits.SelectedRows[0].Cells[2].Value.ToString();
                string mangaGenre = dataGridViewProduits.SelectedRows[0].Cells[3].Value.ToString();
                string mangaLangue = dataGridViewProduits.SelectedRows[0].Cells[4].Value.ToString();
                string mangaNumeroVolume = dataGridViewProduits.SelectedRows[0].Cells[5].Value.ToString();
                string mangaIsbn = dataGridViewProduits.SelectedRows[0].Cells[6].Value.ToString();
                string mangaDateSortie = dataGridViewProduits.SelectedRows[0].Cells[7].Value.ToString();
                string mangaDateAchat = dataGridViewProduits.SelectedRows[0].Cells[8].Value.ToString();
                string mangaFournisseur = dataGridViewProduits.SelectedRows[0].Cells[9].Value.ToString();
                string mangaPrix = dataGridViewProduits.SelectedRows[0].Cells[10].Value.ToString();
                string mangaQuantite = dataGridViewProduits.SelectedRows[0].Cells[11].Value.ToString();
                string mangaEtat = dataGridViewProduits.SelectedRows[0].Cells[12].Value.ToString();
                string mangaId = dataGridViewProduits.SelectedRows[0].Cells[13].Value.ToString();

                ModifierManga modifierMangaForm = new ModifierManga(mangaTitre, mangaNomAuteur, mangaEditeur, mangaGenre, mangaLangue, mangaNumeroVolume, mangaIsbn, mangaDateSortie, mangaDateAchat, mangaFournisseur, mangaPrix, mangaQuantite, mangaEtat, mangaId);

                modifierMangaForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to modify.");
            }
        }
    }
}
