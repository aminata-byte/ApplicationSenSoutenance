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
            dgChefDep.Columns["IdSession"].Visible = false;
            dgChefDep.Columns["IdAnneeAcademique"].Visible = false;

            cbbADepartement.DataSource = filer.FillDepartement();
            cbbADepartement.DisplayMember = "Text";
            cbbADepartement.ValueMember = "Value";
            txtPrenom.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPrenom.Text.Trim() != "" && txtNom.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtMdp.Text.Trim() != "" && txtConfirm.Text.Trim() != "" && txtTel.Text.Trim() != "")
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
    }
}
