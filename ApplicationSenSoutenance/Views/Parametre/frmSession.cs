using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
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
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
            
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FilerList filer = new FilerList();

        private void frmSession_Load(object sender, EventArgs e)
        {
            cbbAnneeAcademique.DataSource = filer.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";

            // Charger le DataGridView avec projection
            dgSession.DataSource = db.sessions
                .Include("AnneeAcademique")
                .ToList()
                .Select(s => new
                {
                    s.IdSession,
                    s.LibelleSession,
                    AnneeAcademique = s.AnneeAcademique?.LibelleAnneeAcademique ?? ""
                })
                .ToList();

            // Masquer la colonne ID
            dgSession.Columns["IdSession"].Visible = false;

        }

        private void txtSession_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSession.Text.Trim() != "")
            {
                Session session = new Session();
                session.LibelleSession = txtSession.Text;
                session.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());

                db.sessions.Add(session);
                db.SaveChanges();
                Effacer();
            }
            else
            {
                MessageBox.Show("Erreur ! Veuillez remplir correctement les champs");
            }

           
        }


        private void Effacer()
        {
            txtSession.Clear();
            cbbAnneeAcademique.SelectedIndex = -1;

            // Recharger le DataGridView avec projection (IMPORTANT)
            dgSession.DataSource = db.sessions
                .Include("AnneeAcademique")
                .ToList()
                .Select(s => new
                {
                    s.IdSession,
                    s.LibelleSession,
                    AnneeAcademique = s.AnneeAcademique?.LibelleAnneeAcademique ?? "",
                    s.IdAnneeAcademique
                })
                .ToList();

            // Masquer les colonnes ID
            dgSession.Columns["IdSession"].Visible = false;
            dgSession.Columns["IdAnneeAcademique"].Visible = false;

            cbbAnneeAcademique.DataSource = filer.FillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            txtSession.Focus();
        }
       public bool btnSlectPresse = false;
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            
            
                btnSlectPresse = true;
           if(dgSession.CurrentRow != null)
            {
                //
                int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
                Session session = db.sessions.Find(id);
                txtSession.Text = session.LibelleSession;
                cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
            }
            else
            {
                MessageBox.Show("Erreur ! Aucune ligne selectionee ");
            }
            

            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnSlectPresse==true)
            {

                if (txtSession.Text.Trim()!="" && cbbAnneeAcademique.Text.Trim()!="")
                {
                    int id = (int)dgSession.CurrentRow.Cells["IdSession"].Value;
                    Session session = db.sessions.Find(id);
                    session.LibelleSession = txtSession.Text;
                    session.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
                    db.SaveChanges();
                    Effacer();
                }
                else
                {
                    MessageBox.Show("Erreur ! Veuillez bien remplir les champs ");
                }

               
            }
            else
            {
                MessageBox.Show("Erreur ! Aucue ligne selectionee ");

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           if(dgSession.CurrentRow!=null)
            {
                int id = (int)dgSession.CurrentRow.Cells["IdSession"].Value;
                Session session = db.sessions.Find(id);
                db.sessions.Remove(session);
                db.SaveChanges();
                Effacer();
            }
            else
            {
                MessageBox.Show("Erreur ! Tableau Vide ");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Récupère toutes les sessions avec leur année académique
            var liste = db.sessions.Include("AnneeAcademique").AsQueryable();

            // Filtre par session si le champ n'est pas vide
            if (!string.IsNullOrEmpty(txtRSession.Text))
            {
                liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Text));
            }

            // Filtre par année académique si le champ n'est pas vide
            if (!string.IsNullOrEmpty(txtRanneeAcademique.Text))
            {
                liste = liste.Where(s => s.AnneeAcademique.LibelleAnneeAcademique.Contains(txtRanneeAcademique.Text));
            }

            // Affiche la liste filtrée avec projection
            dgSession.DataSource = liste
                .ToList()
                .Select(s => new
                {
                    s.IdSession,
                    s.LibelleSession,
                    AnneeAcademique = s.AnneeAcademique?.LibelleAnneeAcademique ?? "",
                    s.IdAnneeAcademique
                })
                .ToList();

            // Masquer les colonnes ID
            dgSession.Columns["IdSession"].Visible = false;
            dgSession.Columns["IdAnneeAcademique"].Visible = false;
        }
        private void cbbAnneeAcademique_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgSession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ttx_Click(object sender, EventArgs e)
        {

        }
    }
}
