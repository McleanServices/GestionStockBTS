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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=okatutreasure;Integrated Security=False;Encrypt=False");


        private void Accueil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okatutreasureDataSet2.Produits' table. You can move, or remove it, as needed.
            this.produitsTableAdapter1.Fill(this.okatutreasureDataSet2.Produits);
            // TODO: This line of code loads data into the 'okatutreasureDataSet1.Produits' table. You can move, or remove it, as needed.
            this.produitsTableAdapter.Fill(this.okatutreasureDataSet1.Produits);





        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddManga addManga = new AddManga();
            addManga.Show();

            this.Opacity = 0.9;


            addManga.FormClosed += (s, args) => this.Opacity = 1;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.produitsTableAdapter.Fill(this.okatutreasureDataSet1.Produits);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //open form founisseur
            Founisseur fournisseur = new Founisseur();
            fournisseur.Show();
            this.Hide();



        }

        private void modifierproduit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string mangaTitre = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string mangaNomAuteur = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string mangaEditeur = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string mangaGenre = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string mangaLangue = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string mangaNumeroVolume = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string mangaIsbn = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string mangaDateSortie = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                string mangaDateAchat = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                string mangaFournisseur = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                string mangaPrix = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                string mangaQuantite = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                string mangaEtat = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                int mangaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[13].Value);

                ModifierManga modifierMangaForm = new ModifierManga(mangaTitre, mangaNomAuteur, mangaEditeur, mangaGenre, mangaLangue, mangaNumeroVolume, mangaIsbn, mangaDateSortie, mangaDateAchat, mangaFournisseur, mangaPrix, mangaQuantite, mangaEtat, mangaId);

                modifierMangaForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to modify.");
            }
        }

        public void SetUserRoleAndPermissions(string username)
        {
            // Assume GetUserRole is a method that retrieves the role for a given username
            string userRole = username;

            // Now, based on the role, set the visibility of the buttons/actions
            switch (userRole)
            {
                case "Administrateur":

                    // Set other controls for Administrateur
                    break;
                case "Gestionnaire":
                    founisseurDataGridViewTextBoxColumn.Visible = false;
                    modifierproduit.Visible = false;
                    // Set other controls for Gestionnaire
                    break;
                case "PersonnelVente":

                    // Set other controls for Personnel de vente
                    break;
                default:
                    // Set default or guest permissions
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = this.okatutreasureDataSet2.Produits;
            string searchTerm = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Use the DataTable's DefaultView to filter the results
                dt.DefaultView.RowFilter = string.Format("Titre LIKE '%{0}%' OR Auteur LIKE '%{0}%'", searchTerm.Replace("'", "''"));

                // Set the DataGridView DataSource to the filtered DefaultView
                dataGridView1.DataSource = dt.DefaultView;
            }
            else
            {
                // If the search term is empty, remove the filter to show all data
                dt.DefaultView.RowFilter = string.Empty;
            }
        }
    }
}
