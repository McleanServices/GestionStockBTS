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




        public ModifierManga(string mangaTitre, string mangaNom, string mangaEditeur, string mangaGenre, string mangaLangue, string mangaNumeroVolume, string mangaIsbn, string mangaDateSortie, string mangaDateAchat, string mangaFournisseur, string mangaPrix, string mangaQuantite, string mangaEtat, int mangaId)
        {
            InitializeComponent();

            LoadData(mangaTitre, mangaNom, mangaEditeur, mangaGenre, mangaLangue, mangaNumeroVolume, mangaIsbn, mangaDateSortie, mangaDateAchat, mangaFournisseur, mangaPrix, mangaQuantite, mangaEtat);
        }

        private void LoadData(string mangaTitre, string mangaNomAuteur, string mangaEditeur, string mangaGenre, string mangaLangue, string mangaNumeroVolume, string mangaIsbn, string mangaDateSortie, string mangaDateAchat, string mangaFournisseur, string mangaPrix, string mangaQuantite, string mangaEtat)
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
        }


        private void ModifierManga_Load(object sender, EventArgs e)
        {
            
            
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifierProduit_Click(object sender, EventArgs e)
        {

        }

        private void txtMangaTitre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
