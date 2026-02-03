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
    public partial class frmMemoire : Form
    {
        public frmMemoire()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();

        private void Sujet_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier qu'une ligne est sélectionnée
                if (dgMemoires.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner un mémoire à modifier!", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Vérifier que les champs sont remplis
                if (string.IsNullOrWhiteSpace(txtSujetMemoire.Text))
                {
                    MessageBox.Show("Veuillez saisir le sujet du mémoire!", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbAnneeAcademique.SelectedValue == null || cmbSession.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez remplir tous les champs!", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Récupérer l'ID et modifier
                int id = int.Parse(dgMemoires.CurrentRow.Cells[0].Value.ToString());
                Memoire memoire = bd.memoires.Find(id);

                memoire.SujetMemoire = txtSujetMemoire.Text;
                memoire.IdAnneeAcademique = int.Parse(cmbAnneeAcademique.SelectedValue.ToString());
                memoire.IdSession = int.Parse(cmbSession.SelectedValue.ToString());

                bd.SaveChanges();



                Effacer();
                Afficher(); // Rafraîchir le DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification: " + ex.Message, "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Effacer()
        {
            txtSujetMemoire.Clear();
            cmbAnneeAcademique.SelectedIndex = -1;
            cmbSession.SelectedIndex = -1;
            txtSujetMemoire.Focus();
        }


        private void Afficher()
        {
            dgMemoires.DataSource = bd.memoires
                .Select(m => new
                {
                    m.IdMemoire,
                    m.SujetMemoire,
                    m.IdAnneeAcademique,
                    AnneeAcademique = m.AnneeAcademique.LibelleAnneeAcademique,
                    m.IdSession,
                    Session = m.Session.LibelleSession
                })
                .ToList();

            // Masquer les colonnes ID
            dgMemoires.Columns["IdMemoire"].Visible = false;
            dgMemoires.Columns["IdAnneeAcademique"].Visible = false;
            dgMemoires.Columns["IdSession"].Visible = false;
        }
        private void BtnSelect_Click(object sender, EventArgs e)
        {

        }



        private void BtnSelect_Click_1(object sender, EventArgs e)
        {
            if (dgMemoires.CurrentRow != null)
            {
                // Récupérer les valeurs par nom de colonne au lieu d'index
                txtSujetMemoire.Text = dgMemoires.CurrentRow.Cells["SujetMemoire"].Value?.ToString() ?? "";

                // Pour l'Année Académique
                if (dgMemoires.CurrentRow.Cells["IdAnneeAcademique"].Value != null)
                {
                    cmbAnneeAcademique.SelectedValue = dgMemoires.CurrentRow.Cells["IdAnneeAcademique"].Value;
                }

                // Pour la Session
                if (dgMemoires.CurrentRow.Cells["IdSession"].Value != null)
                {
                    cmbSession.SelectedValue = dgMemoires.CurrentRow.Cells["IdSession"].Value;
                }
            }
        }

        private void frmMemoire_Load(object sender, EventArgs e)
        {
            // Charger les années académiques dans le ComboBox
            cmbAnneeAcademique.DataSource = bd.anneeAcademiques.ToList();
            cmbAnneeAcademique.DisplayMember = "LibelleAnneeAcademique";
            cmbAnneeAcademique.ValueMember = "IdAnneeAcademique";
            cmbAnneeAcademique.SelectedIndex = -1; // Aucune sélection par défaut

            // Charger les sessions dans le ComboBox
            cmbSession.DataSource = bd.sessions.ToList();
            cmbSession.DisplayMember = "LibelleSession";
            cmbSession.ValueMember = "IdSession";
            cmbSession.SelectedIndex = -1; // Aucune sélection par défaut

            // Charger les données dans le DataGridView
            Afficher();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier que les champs sont remplis
                if (string.IsNullOrWhiteSpace(txtSujetMemoire.Text))
                {
                    MessageBox.Show("Veuillez saisir le sujet du mémoire!", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSujetMemoire.Focus();
                    return;
                }

                if (cmbAnneeAcademique.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner une année académique!", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbAnneeAcademique.Focus();
                    return;
                }

                if (cmbSession.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner une session!", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSession.Focus();
                    return;
                }

                // Créer un nouveau mémoire
                Memoire memoire = new Memoire();
                memoire.SujetMemoire = txtSujetMemoire.Text;
                memoire.IdAnneeAcademique = int.Parse(cmbAnneeAcademique.SelectedValue.ToString());
                memoire.IdSession = int.Parse(cmbSession.SelectedValue.ToString());

                // Ajouter à la base de données
                bd.memoires.Add(memoire);
                bd.SaveChanges();



                Effacer();
                Afficher(); // Rafraîchir le DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout: " + ex.Message, "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier qu'une ligne est sélectionnée dans le DataGridView
                if (dgMemoires.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner un mémoire à supprimer!", "Attention",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Récupérer l'ID du mémoire depuis la première colonne (index 0)
                int id = int.Parse(dgMemoires.CurrentRow.Cells[0].Value.ToString());

                // Rechercher le mémoire dans la base de données par son ID
                Memoire memoire = bd.memoires.Find(id);

                // Supprimer le mémoire de la base de données
                bd.memoires.Remove(memoire);

                // Sauvegarder les modifications dans la base de données
                bd.SaveChanges();

                // Afficher un message de succès
                // MessageBox.Show("Mémoire supprimé avec succès!", "Succès",
                //MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Vider les champs du formulaire
                Effacer();

                // Rafraîchir le DataGridView pour afficher les données mises à jour
                Afficher();
            }
            catch (Exception ex)
            {
                // En cas d'erreur, afficher un message avec les détails de l'erreur
                MessageBox.Show("Erreur lors de la suppression: " + ex.Message, "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSujetMemoire_TextChanged(object sender, EventArgs e)
        {

        }
    }
}