using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okatutreasure
{
    public partial class AddManga : Form
    {
        public AddManga()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=okatutreasure;Integrated Security=False;Encrypt=False");

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Add image from file
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Get the image path
                string imgPath = ofd.FileName;

                // Execute the Python script
                var psi = new ProcessStartInfo();
                psi.FileName = @"C:\Users\tyrec\pythonProject2\Scripts\python.exe"; // Adjust the path to your Python interpreter
                psi.Arguments = $"\"C:\\Users\\tyrec\\PycharmProjects\\pythonProject2\\main.py\" \"{imgPath}\"";
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;

                var process = Process.Start(psi);

                // Capture the output from the Python script
                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();

                process.WaitForExit();

                

               

                if (!string.IsNullOrEmpty(errors))
                {
                    MessageBox.Show($"Errors: {errors}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (titre.Text == "")
            {
                titre.Text = "Titre";
                titre.ForeColor = Color.Gray;
                
            }
            
            
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {

            panel1.BackColor = Color.LightBlue;

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
            panel1.BackColor = SystemColors.Control;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void AddManga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okatutreasureDataSet3.Produits' table. You can move, or remove it, as needed.
            this.produitsTableAdapter.Fill(this.okatutreasureDataSet3.Produits);
            // TODO: This line of code loads data into the 'okatutreasureDataSet3.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.okatutreasureDataSet3.Genres);
            titre.Enter += textBox1_Enter;
            titre.Leave += textBox1_Leave;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Titre, Auteur, Editeur, Genre, Langue, NumeroDeVolume, ISBN, DateDESortir, DateAchat, Fournisseur, Etat;
            
            Titre = titre.Text;
            Auteur = auteur.Text;
            Editeur = editeur.Text;
            Genre = genre.Text;
            Langue = langue.Text;
            NumeroDeVolume = volume.Text;
            ISBN = isbn.Text;
            DateDESortir = datesortie.Text;
            DateAchat = dateachat.Text;
            Fournisseur = fournisseur.Text;
            Etat = etat.Text;
            

            try
            {
                con.Open();
                String Query = "INSERT INTO Produits (Titre, Auteur, Editeur, Genre, Langue, NumeroDeVolume, ISBN, DateDESortir, DateAchat, Founisseur, Etat, Prix, QuantiteEnstock) VALUES ('" + Titre + "','" + Auteur + "','" + Editeur + "','" + Genre + "','" + Langue + "','" + NumeroDeVolume + "','" + ISBN + "','2023-01-01','2023-01-01','" + Fournisseur + "', '" + Etat + "',1 ,5)";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Manga ajouté avec succès", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                titre.Clear();
                auteur.Clear();
                editeur.Clear();
                genre.Text = "";
                langue.Clear();
                volume.Clear();
                isbn.Clear();
                datesortie.Clear();
                dateachat.Clear();
                fournisseur.Clear();
                etat.Clear();
                prix.Clear();
                quantitestock.Clear();
                
            }
            catch (Exception ex)
            {
                button1.BackColor = Color.Red;
                MessageBox.Show("Erreur lors de l'insertion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();

            }








        }
    }
}
