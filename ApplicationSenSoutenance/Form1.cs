using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSenSoutenance
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
            // Plein écran
            //this.WindowState = FormWindowState.Maximized;

            // Garder les bordures mais maximiser
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmMDI f = new frmMDI();
            f.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
