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
    public partial class journalAudit : Form
    {
        public journalAudit()
        {
            InitializeComponent();
        }

        private void journalAudit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okatutreasureDataSet9.AuditLog' table. You can move, or remove it, as needed.
            this.auditLogTableAdapter.Fill(this.okatutreasureDataSet9.AuditLog);

        }
    }
}
