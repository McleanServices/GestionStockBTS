using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okatutreasure
{
    public partial class ChoixTypeUtilisateurForm : Form
    {
        public ChoixTypeUtilisateurForm()
        {
            InitializeComponent();
        }

        private void buttonInviter_Click(object sender, EventArgs e)
        {
            Produits a = new Produits();
            a.Show();
            this.Hide();
        }

        private void buttonEditeur_Click(object sender, EventArgs e)
        {
            //open form 1
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
