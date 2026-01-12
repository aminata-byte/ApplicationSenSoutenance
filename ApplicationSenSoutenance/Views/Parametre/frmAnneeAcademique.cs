using ApplicationSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
            
        }
        
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();
        
        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = bd.anneeAcademiques.Find(id); // ✅ Ajouté id
            bd.anneeAcademiques.Remove(anneeAcademique);
            bd.SaveChanges();
            Effacer();
        }

        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            dgAnneeAcademique.DataSource = bd.anneeAcademiques.ToList();

            // On force l'affichage des deux colonnes importantes
            if (dgAnneeAcademique.Columns["IdAnneeAcademique"] != null)
                dgAnneeAcademique.Columns["IdAnneeAcademique"].Visible = false;

            if (dgAnneeAcademique.Columns["LibelleAnneeAcademique"] != null)
            {
                dgAnneeAcademique.Columns["LibelleAnneeAcademique"].Visible = true;
                dgAnneeAcademique.Columns["LibelleAnneeAcademique"].Width = 350;      // ← colonne plus large
            }

            if (dgAnneeAcademique.Columns["AnneeAcademiqueVal"] != null)
            {
                dgAnneeAcademique.Columns["AnneeAcademiqueVal"].Visible = true;
                dgAnneeAcademique.Columns["AnneeAcademiqueVal"].Width = 150;
            }

            // Améliorations bonus (optionnel mais très utile)
            dgAnneeAcademique.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAnneeAcademique.RowHeadersVisible = false;
            dgAnneeAcademique.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAnneeAcademique.AllowUserToAddRows = false;
        }

        public void Effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
            dgAnneeAcademique.DataSource = bd.anneeAcademiques.ToList();
            txtLibelleAnneeAcademique.Focus();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AnneeAcademique anneeAcademique = new AnneeAcademique()
            {
                LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text,
                AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text)
            };
            bd.anneeAcademiques.Add(anneeAcademique);  
            bd.SaveChanges(); 
            Effacer();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = bd.anneeAcademiques.Find(id);
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);
            bd.SaveChanges();
            Effacer();
        }
        
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            txtLibelleAnneeAcademique.Text = dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();
            txtAnneeAcademiqueVal.Text = dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgAnneeAcademique_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTexte_Click(object sender, EventArgs e)
        {

        }

        private void txtLibelleAnneeAcademique_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnneeAcademiqueVal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValeur_Click(object sender, EventArgs e)
        {

        }

        private void lblTitreMenu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // On n'ouvre PAS depuis frmAnneeAcademique directement
            // On demande à frmMDI d'ouvrir la page Mémoire
            frmMDI mdiParent = this.MdiParent as frmMDI;

            if (mdiParent != null)
            {
                mdiParent.fermer();  // Ferme les autres pages enfants 

                frmMemoire f = new frmMemoire();
                f.MdiParent = mdiParent;  // ← IMPORTANT : parent = frmMDI, PAS this
                f.Show();
                f.WindowState = FormWindowState.Maximized;
            }
        }
    }
}