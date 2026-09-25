using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace okatutreasure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=okatutreasure;Integrated Security=False;Encrypt=False");

        private void textBoxIndentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string identifiant = textBoxIndentifiant.Text;
            string motdepasse = textBoxMotDePasse.Text; // This should be hashed!

            try
            {
                con.Open();
                string query = "SELECT RoleUtilisateur FROM Utilisateurs WHERE Email = @identifiant AND MotDePasse = @motdepasse";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@identifiant", identifiant);
                    command.Parameters.AddWithValue("@motdepasse", motdepasse); // Hash this password before checking

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string roleUtilisateur = reader.GetString(0); // Assuming role is the first column
                            Produits accueil = new Produits();
                            accueil.Show();
                            this.Hide();

                            accueil.SetUserRoleAndPermissions(roleUtilisateur);
                        }
                        else
                        {
                            MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxIndentifiant.Clear();
                            textBoxMotDePasse.Clear();
                            textBoxIndentifiant.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
