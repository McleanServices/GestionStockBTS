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
    public partial class Utilisateurs : Form
    {
        public Utilisateurs()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Utilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okatutreasureUtilisateursDataSet11.Utilisateurs' table. You can move, or remove it, as needed.
            this.utilisateursTableAdapter.Fill(this.okatutreasureUtilisateursDataSet11.Utilisateurs);

        }
    }
}
