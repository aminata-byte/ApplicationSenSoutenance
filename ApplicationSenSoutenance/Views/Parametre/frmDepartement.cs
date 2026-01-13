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
    public partial class frmDepartement : Form
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
        public frmDepartement()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();


        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Departement departement = new Departement();
            departement.LibelleDepartement = txtLibelle.Text;
           

            //  Ajout du PROFESSEUR dans la table PROFESSEURS
            db.departements.Add(departement);
            db.SaveChanges();

            Effacer();
        }
        private void Effacer()
        {
            txtLibelle.Clear();
         
            dgDepartement.DataSource = db.departements.ToList();
         

        }

        private void frmDepartement_Load(object sender, EventArgs e)
        {
            dgDepartement.DataSource = db.departements.ToList();

            dgDepartement.Columns["IdDepartement"].Visible = false;

            //permet de cacher



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int? id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            Departement departement = db.departements.Find(id);
            departement.LibelleDepartement = txtLibelle.Text;
       
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;

            int id = Convert.ToInt32(
                dgDepartement.CurrentRow.Cells["IdDepartement"].Value
            );

            Departement departement = db.departements.Find(id);
            db.departements.Remove(departement);
            db.SaveChanges();

            Effacer();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {


            int id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            Departement departement = db.departements.Find(id);

            // Charger les données dans les champs (SÉLECTION)
            txtLibelle.Text = departement.LibelleDepartement;
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.departements.ToList();

            
            if (!string.IsNullOrEmpty(txtRdepartement.Text))
            {
                liste = liste
                    .Where(p => p.LibelleDepartement.Contains(txtRdepartement.Text))
                    .ToList();
            }

            dgDepartement.DataSource = liste;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRdepartement_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
