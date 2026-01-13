using ApplicationSenSoutenance.Models;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationSenSoutenance.Shared;

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmProfesseur : Form
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
        public frmProfesseur()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            

            int id = int.Parse(dgProfesseur.CurrentRow.Cells[1].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);

            // Charger les données dans les champs (SÉLECTION)
            txtNom.Text = professeur.NomUtilisateur;
            txtPrenom.Text = professeur.PrenomUtilisateur;
            txtTelephone.Text = professeur.TelUtilisateur;
            txtEmail.Text = professeur.EmailUtilisateur;
            txtMotDePasse.Text = professeur.MotDePasse;
            txtSpecialite.Text = professeur.SpecialiteProfesseur;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.professeurs.ToList();

            if (!string.IsNullOrEmpty(txtRNom.Text))
            {
                liste = liste
                    .Where(p => p.NomUtilisateur.Contains(txtRNom.Text))
                    .ToList();
            }
            else if (!string.IsNullOrEmpty(txtRSpecialite.Text))
            {
                liste = liste
                    .Where(p => p.SpecialiteProfesseur.Contains(txtRSpecialite.Text))
                    .ToList();
            }

            dgProfesseur.DataSource = liste;
        
}

        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            dgProfesseur.DataSource = db.professeurs.ToList();

            //permet de cacher

            dgProfesseur.Columns["IdUtilisateur"].Visible = false;

            dgProfesseur.Columns["MotDePasse"].Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;

            int id = Convert.ToInt32(
                dgProfesseur.CurrentRow.Cells["IdUtilisateur"].Value
            );

            Professeur professeur = db.professeurs.Find(id);
            db.professeurs.Remove(professeur);
            db.SaveChanges();

            Effacer();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Professeur professeur = new Professeur();
            professeur.NomUtilisateur = txtNom.Text;
            professeur.PrenomUtilisateur = txtPrenom.Text;
            professeur.TelUtilisateur = txtTelephone.Text;
            professeur.EmailUtilisateur = txtEmail.Text;
            professeur.MotDePasse = txtMotDePasse.Text;
            professeur.SpecialiteProfesseur = txtSpecialite.Text;

            //  Ajout du PROFESSEUR dans la table PROFESSEURS
            db.professeurs.Add(professeur); 
            db.SaveChanges();

            Effacer();
        }

        private void Effacer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
            txtSpecialite.Clear();
            dgProfesseur.DataSource = db.professeurs.ToList();
            txtNom.Focus();
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProfesseur.CurrentRow.Cells[1].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);
            professeur.NomUtilisateur = txtNom.Text;
            professeur.PrenomUtilisateur = txtPrenom.Text;
            professeur.TelUtilisateur = txtTelephone.Text;
            professeur.EmailUtilisateur = txtEmail.Text;
            professeur.MotDePasse = txtMotDePasse.Text;
            professeur.SpecialiteProfesseur = txtSpecialite.Text;
            db.SaveChanges();
            Effacer();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgProfesseur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void candidatTxt_Click(object sender, EventArgs e)
        {
            fermer();
            // Code à mettre dans l'événement clic de votre menu par exemple
            frmCandidat f = new frmCandidat();
            f.MdiParent = this; // 'this' désigne le formulaire frmMDI (le parent)
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void ProfesseurTxt_Click(object sender, EventArgs e)
        {
            fermer();
            // Code à mettre dans l'événement clic de votre menu par exemple
            frmProfesseur f = new frmProfesseur();
            f.MdiParent = this; // 'this' désigne le formulaire frmMDI (le parent)
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtRSpecialite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    
}
