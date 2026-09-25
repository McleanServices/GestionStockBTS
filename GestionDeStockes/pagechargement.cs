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
    public partial class pagechargement : Form
    {
        public pagechargement()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 800)
            {
                timer1.Stop();
                ChoixTypeUtilisateurForm c = new ChoixTypeUtilisateurForm();
                c.Show();
                this.Hide();
            }
        }

        private void pagechargement_Load(object sender, EventArgs e)
        {

        }
    }
}
