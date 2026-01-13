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
    public partial class frmCandidat : Form
    {
        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            // Pour chaque formulaire enfant, on le ferme
            foreach (Form chform in charr)
            {
                // chform.WindowState = FormWindowState.Maximized; (optionnel)
                chform.Close();
            }
        }

        public frmCandidat()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void frmCandidat_Load(object sender, EventArgs e)
        {
            dgCandidat.DataSource = db.candidats.ToList();

            //permet de cacher

            dgCandidat.Columns["IdUtilisateur"].Visible = false;

            dgCandidat.Columns["MotDePasse"].Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProfesseurTxt_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Effacer()
        {
            textNom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
            txtMatricule.Clear();
            dgCandidat.DataSource = db.candidats.ToList();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat();
            candidat.MatriculeCandidat = txtMatricule.Text;
            candidat.NomUtilisateur = textNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TelUtilisateur = txtTelephone.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            candidat.MotDePasse = txtMotDePasse.Text;
           

            //  Ajout du PROFESSEUR dans la table PROFESSEURS
            db.candidats.Add(candidat);
            db.SaveChanges();

            Effacer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCandidat.CurrentRow.Cells[1].Value.ToString());
            Candidat candidat = db.candidats.Find(id);
            candidat.NomUtilisateur = textNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TelUtilisateur = txtTelephone.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            candidat.MotDePasse = txtMotDePasse.Text;
            candidat.MatriculeCandidat = txtMatricule.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgCandidat.CurrentRow == null) return;

            int id = Convert.ToInt32(
                dgCandidat.CurrentRow.Cells["IdUtilisateur"].Value
            );

            Candidat candidat = db.candidats.Find(id);
            db.candidats.Remove(candidat);
            db.SaveChanges();

            Effacer();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCandidat.CurrentRow.Cells[1].Value.ToString());
            Candidat candidat = db.candidats.Find(id);

            // Charger les données dans les champs (SÉLECTION)
            textNom.Text = candidat.NomUtilisateur;
            txtPrenom.Text = candidat.PrenomUtilisateur;
            txtTelephone.Text = candidat.TelUtilisateur;
            txtEmail.Text = candidat.EmailUtilisateur;
            txtMotDePasse.Text = candidat.MotDePasse;
            txtMatricule.Text = candidat.MatriculeCandidat;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.candidats.ToList();

            if (!string.IsNullOrEmpty(txtRNom.Text))
            {
                liste = liste
                    .Where(p => p.NomUtilisateur.Contains(txtRNom.Text))
                    .ToList();
            }
            else if (!string.IsNullOrEmpty(txtMatricule.Text))
            {
                liste = liste
                    .Where(p => p.MatriculeCandidat.Contains(txtRSpecialite.Text))
                    .ToList();
            }

            dgCandidat.DataSource = liste;
        }
    }
}
