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
    public partial class frmSoutenance : Form
    {
        public frmSoutenance()
        {
            InitializeComponent();
        }

        // Instance du contexte Entity Framework pour accéder à la base de données
        BdSenSoutenanceContext bd = new BdSenSoutenanceContext();


        //  AFFICHER : charger les soutenances dans le DataGridView
        private void Afficher()
        {
            // Récupération des soutenances avec jointure sur Mémoire
            dgSoutenances.DataSource = bd.soutenances
                .Select(s => new
                {
                    s.IdSoutenance,                 // ID soutenance
                    s.DateSoutenance,               // Date de soutenance
                    s.LieuSoutenance,               // Lieu
                    s.ResultatSoutenance,           // Résultat
                    s.MentionSoutenance,            // Mention
                    s.ObservationsSoutenance,       // Observations
                    s.IdMemoire,                    // Clé étrangère
                    Memoire = s.Memoire.SujetMemoire // Sujet du mémoire associé
                })
                .ToList();

            // Masquer les colonnes techniques
            dgSoutenances.Columns["IdSoutenance"].Visible = false;
            dgSoutenances.Columns["IdMemoire"].Visible = false;
        }

        //  EFFACER : réinitialiser les champs du formulaire

        private void Effacer()
        {
            dtpDateSoutenance.Value = DateTime.Now; // Date actuelle
            txtLieu.Clear();                        // Vider le champ lieu
            cmbResultat.SelectedIndex = -1;         // Aucune sélection
            cmbMention.SelectedIndex = -1;
            txtObservation.Clear();                 // Vider observations
            cmbMemoire.SelectedIndex = -1;
            txtLieu.Focus();                        // Curseur sur le champ lieu
        }

        private void frmSoutenance_Load(object sender, EventArgs e)
        {
            // Charger les mémoires dans le ComboBox
            cmbMemoire.DataSource = bd.memoires.ToList();
            cmbMemoire.DisplayMember = "SujetMemoire";
            cmbMemoire.ValueMember = "IdMemoire";
            cmbMemoire.SelectedIndex = -1;

            // Charger les valeurs fixes
            cmbResultat.Items.AddRange(new string[] { "Admis", "Ajourné", "Refusé" });
            cmbMention.Items.AddRange(new string[]
            {
                "Passable", "Assez Bien", "Bien", "Très Bien", "Excellent"
            });

            // Afficher les soutenances existantes
            Afficher();
        }

        private void panelContenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est bien sélectionnée dans le DataGridView
            if (dgSoutenances.CurrentRow != null)
            {
                // Récupère la date de soutenance depuis la colonne "DateSoutenance"
                // et l'affecte au DateTimePicker
                dtpDateSoutenance.Value =
                    Convert.ToDateTime(dgSoutenances.CurrentRow.Cells["DateSoutenance"].Value);

                // Récupère le lieu de la soutenance et l'affecte au champ texte
                txtLieu.Text =
                    dgSoutenances.CurrentRow.Cells["LieuSoutenance"].Value?.ToString();

                // Récupère le résultat de la soutenance et l'affiche dans la ComboBox
                cmbResultat.Text =
                    dgSoutenances.CurrentRow.Cells["ResultatSoutenance"].Value?.ToString();

                // Récupère la mention obtenue et l'affiche dans la ComboBox
                cmbMention.Text =
                    dgSoutenances.CurrentRow.Cells["MentionSoutenance"].Value?.ToString();

                // Récupère les observations de la soutenance et les affiche dans le champ texte
                txtObservation.Text =
                    dgSoutenances.CurrentRow.Cells["ObservationsSoutenance"].Value?.ToString();

                // Récupère l'identifiant du mémoire sélectionné
                // et le définit comme valeur sélectionnée dans la ComboBox
                cmbMemoire.SelectedValue =
                    dgSoutenances.CurrentRow.Cells["IdMemoire"].Value;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification du lieu
                if (string.IsNullOrWhiteSpace(txtLieu.Text))
                {
                    MessageBox.Show("Veuillez saisir le lieu de soutenance !");
                    return;
                }

                // Vérification du mémoire sélectionné
                if (cmbMemoire.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner un mémoire !");
                    return;
                }

                // Création de l'objet Soutenance
                Soutenance s = new Soutenance
                {
                    DateSoutenance = dtpDateSoutenance.Value,
                    LieuSoutenance = txtLieu.Text,
                    ResultatSoutenance = cmbResultat.Text,
                    MentionSoutenance = cmbMention.Text,
                    ObservationsSoutenance = txtObservation.Text,
                    IdMemoire = (int)cmbMemoire.SelectedValue
                };

                // Ajout dans la base de données
                bd.soutenances.Add(s);
                bd.SaveChanges();

                // Réinitialiser le formulaire et rafraîchir la liste
                Effacer();
                Afficher();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur ajout : " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier qu'une ligne est sélectionnée
                if (dgSoutenances.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner une soutenance !");
                    return;
                }

                // Récupérer l'ID de la soutenance
                int id = int.Parse(dgSoutenances.CurrentRow.Cells["IdSoutenance"].Value.ToString());

                // Rechercher la soutenance dans la base
                Soutenance s = bd.soutenances.Find(id);

                // Mise à jour des champs
                s.DateSoutenance = dtpDateSoutenance.Value;
                s.LieuSoutenance = txtLieu.Text;
                s.ResultatSoutenance = cmbResultat.Text;
                s.MentionSoutenance = cmbMention.Text;
                s.ObservationsSoutenance = txtObservation.Text;
                s.IdMemoire = (int)cmbMemoire.SelectedValue;

                // Sauvegarder les modifications
                bd.SaveChanges();

                Effacer();
                Afficher();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur modification : " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier qu'une ligne est sélectionnée
                if (dgSoutenances.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner une soutenance !");
                    return;
                }

                // Récupérer l'ID
                int id = int.Parse(dgSoutenances.CurrentRow.Cells["IdSoutenance"].Value.ToString());

                // Rechercher la soutenance
                Soutenance s = bd.soutenances.Find(id);

                // Supprimer de la base
                bd.soutenances.Remove(s);
                bd.SaveChanges();

                Effacer();
                Afficher();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur suppression : " + ex.Message);
            }
        }

        private void cmbResultat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgSoutenances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}