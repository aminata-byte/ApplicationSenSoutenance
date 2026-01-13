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
            try
            {
                // Vérifier qu'une ligne est sélectionnée
                if (dgAnneeAcademique.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner une année académique à supprimer!",
                                    "Attention",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Récupérer l'ID de l'année académique à supprimer
                int id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());

                // Vérifier si des mémoires utilisent cette année académique
                bool hasMemoires = bd.memoires.Any(m => m.IdAnneeAcademique == id);

                if (hasMemoires)
                {
                    MessageBox.Show("Impossible de supprimer cette année académique car elle est utilisée par des mémoires!",
                                    "Attention",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Si aucun mémoire n'utilise cette année, on peut supprimer
                AnneeAcademique anneeAcademique = bd.anneeAcademiques.Find(id);
                bd.anneeAcademiques.Remove(anneeAcademique);
                bd.SaveChanges();

                MessageBox.Show("Année académique supprimée avec succès!",
                                "Succès",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Effacer();
            }
            // Capture toute exception pouvant survenir lors de la suppression
            // et affiche un message d'erreur à l'utilisateur
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression: " + ex.Message,// Message détaillant l'erreur
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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
            // Création d’un nouvel objet AnneeAcademique
            // et affectation des valeurs saisies dans le formulaire
            AnneeAcademique anneeAcademique = new AnneeAcademique()
            {
                // Libellé de l'année académique saisi par l'utilisateur
                LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text,

                // Valeur numérique de l'année académique
                AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text)
            };

            // Ajout de la nouvelle année académique dans la base de données
            bd.anneeAcademiques.Add(anneeAcademique);

            // Enregistrement des données dans la base
            bd.SaveChanges();

            // Réinitialisation des champs du formulaire après l'ajout
            Effacer();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Récupère l'identifiant de l'année académique sélectionnée
            // à partir de la première colonne du DataGridView
            int id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());

            // Recherche dans la base de données l'année académique
            // correspondant à l'identifiant récupéré
            AnneeAcademique anneeAcademique = bd.anneeAcademiques.Find(id);

            // Met à jour le libellé de l'année académique
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;

            // Met à jour la valeur numérique de l'année académique
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);

            // Enregistre les modifications dans la base de données
            bd.SaveChanges();

            // Vide les champs du formulaire après la mise à jour
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}