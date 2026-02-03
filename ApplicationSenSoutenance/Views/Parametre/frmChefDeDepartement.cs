using ApplicationSenSoutenance.Models;
using ApplicationSenSoutenance.Shared;
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

namespace ApplicationSenSoutenance.Views.Parametre
{
    public partial class frmChefDeDepartement : Form
    {
        public frmChefDeDepartement()
        {
            InitializeComponent();
        }
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FilerList filer = new FilerList();

        private void Effacer()
        {
            txtConfirm.Clear();
            txtPrenom.Clear();
            txtNom.Clear();
            txtEmail.Clear();
            txtMdp.Clear();
            txtTel.Clear();
            cbbADepartement.SelectedIndex = -1;
            
            // Recharger le DataGridView avec projection (IMPORTANT)
            dgChefDep.DataSource = db.chefDepartements
                .Include("ChefDepartement")
                .ToList()
                .Select(s => new
                {
                    s.IdUtilisateur,
                    s.PrenomUtilisateur,
                    s.NomUtilisateur,
                    s.EmailUtilisateur,
                    s.TelUtilisateur,
                    departement = s.Departement?.LibelleDepartement ?? "",
                    s.IdDepartement,
                })
                .ToList();

            // Masquer les colonnes ID
            dgChefDep.Columns["IdUtilisateur"].Visible = false;
            dgChefDep.Columns["IdDepartement"].Visible = false;

            cbbADepartement.DataSource = filer.FillDepartement();
            cbbADepartement.DisplayMember = "Text";
            cbbADepartement.ValueMember = "Value";
            txtPrenom.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPrenom.Text.Trim() != ""
                && txtNom.Text.Trim() != ""
                && txtEmail.Text.Trim() != ""
                && txtMdp.Text.Trim() != ""
                && txtConfirm.Text.Trim() != ""
                && txtTel.Text.Trim() != ""
                && cbbADepartement.SelectedValue != null
                )
            {
               
                ChefDepartement chefDepartement = new ChefDepartement();
                
                chefDepartement.NomUtilisateur = txtNom.Text;
                chefDepartement.EmailUtilisateur = txtEmail.Text;
                chefDepartement.TelUtilisateur = txtTel.Text;
                chefDepartement.PrenomUtilisateur = txtPrenom.Text;
                chefDepartement.MotDePasse = txtMdp.Text;

                chefDepartement.IdDepartement = int.Parse(cbbADepartement.SelectedValue.ToString());


                db.chefDepartements.Add(chefDepartement);
           
                db.SaveChanges();
                Effacer();
            }
            else
            {
                MessageBox.Show("Erreur ! Veuillez remplir correctement les champs");
            }
        }
         public bool btnSlectPresse = true;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnSlectPresse == true)
            {

                if (txtPrenom.Text.Trim() != "" 
                    && cbbADepartement.Text.Trim() != ""
                    && txtNom.Text.Trim() != "" 
                    && txtEmail.Text.Trim() != "" 
                    && txtTel.Text.Trim() != ""
                    && txtMdp.Text.Trim() != ""
                    && txtConfirm.Text.Trim() != "")
                {
                    int id = (int)dgChefDep.CurrentRow.Cells["Id"].Value;
                    ChefDepartement chefdepartement = db.chefDepartements.Find(id);
                    
                    chefdepartement.PrenomUtilisateur = txtPrenom.Text;
                    chefdepartement.NomUtilisateur= txtNom.Text;
                    chefdepartement.EmailUtilisateur = txtEmail.Text;
                    chefdepartement.TelUtilisateur = txtTel.Text;
                    if(txtMdp == txtConfirm)
                    {
                        chefdepartement.MotDePasse = txtMdp.Text;
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe non identique");
                    }
                    chefdepartement.IdDepartement = int.Parse(cbbADepartement.SelectedValue.ToString());

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

            if (dgChefDep.CurrentRow != null)
            {
                int id = (int)dgChefDep.CurrentRow.Cells["IdUtilisateur"].Value;
                ChefDepartement chefDepartement = db.chefDepartements.Find(id);
                db.chefDepartements.Remove(chefDepartement);
                db.SaveChanges();
                Effacer();
            }
            else
            {
                MessageBox.Show("Erreur ! Tableau Vide ");
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {


            btnSlectPresse = true;
            if (dgChefDep.CurrentRow != null)
            {
                //
                int? id = int.Parse(dgChefDep.CurrentRow.Cells[0].Value.ToString());
                ChefDepartement chefDepartement = db.chefDepartements.Find(id);
                txtPrenom.Text = chefDepartement.PrenomUtilisateur;
                txtNom.Text = chefDepartement.NomUtilisateur;
                txtTel.Text = chefDepartement.TelUtilisateur;
                txtEmail.Text = chefDepartement.EmailUtilisateur;
                txtMdp.Text = chefDepartement.MotDePasse;

                cbbADepartement.SelectedValue = chefDepartement.IdDepartement;
            }
            else
            {
                MessageBox.Show("Erreur ! Aucune ligne selectionee ");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Récupère toutes les sessions avec leur année académique
            var liste = db.chefDepartements.Include("Departement").AsQueryable();

            // Filtre par session si le champ n'est pas vide
            if (!string.IsNullOrEmpty(txtRPrenom.Text))
            {
                liste = liste.Where(s => s.PrenomUtilisateur.Contains(txtRPrenom.Text));
            }
            if (!string.IsNullOrEmpty(txtRNom.Text))
            {
                liste = liste.Where(s => s.NomUtilisateur.Contains(txtRNom.Text));
            }
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                liste = liste.Where(s => s.EmailUtilisateur.Contains(txtEmail.Text));
            }
            if (!string.IsNullOrEmpty(txtTel.Text))
            {
                liste = liste.Where(s => s.TelUtilisateur.Contains(txtTel.Text));
            }
            // Filtre par année académique si le champ n'est pas vide
            if (!string.IsNullOrEmpty(txtDepartement.Text))
            {
                liste = liste.Where(s => s.Departement.LibelleDepartement.Contains(txtDepartement.Text));
            }
            
            // Affiche la liste filtrée avec projection
            dgChefDep.DataSource = liste
                .ToList()
                .Select(s => new
                {
                    s.IdUtilisateur,
                    s.PrenomUtilisateur,
                    s.NomUtilisateur,
                    s.EmailUtilisateur,
                    s.TelUtilisateur,
                    s.MotDePasse,
                    Departement = s.Departement?.LibelleDepartement ?? "",
                    s.IdDepartement
                })
                .ToList();

            // Masquer les colonnes ID
            dgChefDep.Columns["IdUtilisateur"].Visible = false;
            dgChefDep.Columns["IdDepartement"].Visible = false;
        }
    }
}
