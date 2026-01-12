namespace ApplicationSenSoutenance.Views.Parametre
{
    partial class frmAnneeAcademique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnRemove;
            this.dgAnneeAcademique = new System.Windows.Forms.DataGridView();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.txtTexte = new System.Windows.Forms.Label();
            this.txtLibelleAnneeAcademique = new System.Windows.Forms.TextBox();
            this.txtAnneeAcademiqueVal = new System.Windows.Forms.TextBox();
            this.txtValeur = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelContenu = new System.Windows.Forms.Panel();
            btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).BeginInit();
            this.panelContenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.BackColor = System.Drawing.Color.DarkRed;
            btnRemove.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRemove.ForeColor = System.Drawing.Color.LavenderBlush;
            btnRemove.Location = new System.Drawing.Point(675, 138);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(108, 37);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "&Supprimer";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgAnneeAcademique
            // 
            this.dgAnneeAcademique.AllowUserToAddRows = false;
            this.dgAnneeAcademique.AllowUserToDeleteRows = false;
            this.dgAnneeAcademique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnneeAcademique.BackgroundColor = System.Drawing.Color.White;
            this.dgAnneeAcademique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnneeAcademique.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgAnneeAcademique.Location = new System.Drawing.Point(0, 204);
            this.dgAnneeAcademique.Name = "dgAnneeAcademique";
            this.dgAnneeAcademique.ReadOnly = true;
            this.dgAnneeAcademique.RowHeadersVisible = false;
            this.dgAnneeAcademique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnneeAcademique.Size = new System.Drawing.Size(819, 246);
            this.dgAnneeAcademique.TabIndex = 0;
            this.dgAnneeAcademique.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnneeAcademique_CellContentClick);
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSelect.Location = new System.Drawing.Point(259, 139);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(110, 36);
            this.BtnSelect.TabIndex = 3;
            this.BtnSelect.Text = "&Selectionner";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // txtTexte
            // 
            this.txtTexte.AutoSize = true;
            this.txtTexte.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexte.Location = new System.Drawing.Point(278, 53);
            this.txtTexte.Name = "txtTexte";
            this.txtTexte.Size = new System.Drawing.Size(51, 19);
            this.txtTexte.TabIndex = 2;
            this.txtTexte.Text = "Texte";
            this.txtTexte.Click += new System.EventHandler(this.txtTexte_Click);
            // 
            // txtLibelleAnneeAcademique
            // 
            this.txtLibelleAnneeAcademique.Location = new System.Drawing.Point(278, 83);
            this.txtLibelleAnneeAcademique.Name = "txtLibelleAnneeAcademique";
            this.txtLibelleAnneeAcademique.Size = new System.Drawing.Size(164, 20);
            this.txtLibelleAnneeAcademique.TabIndex = 1;
            this.txtLibelleAnneeAcademique.TextChanged += new System.EventHandler(this.txtLibelleAnneeAcademique_TextChanged);
            // 
            // txtAnneeAcademiqueVal
            // 
            this.txtAnneeAcademiqueVal.Location = new System.Drawing.Point(489, 83);
            this.txtAnneeAcademiqueVal.Name = "txtAnneeAcademiqueVal";
            this.txtAnneeAcademiqueVal.Size = new System.Drawing.Size(164, 20);
            this.txtAnneeAcademiqueVal.TabIndex = 2;
            this.txtAnneeAcademiqueVal.TextChanged += new System.EventHandler(this.txtAnneeAcademiqueVal_TextChanged);
            // 
            // txtValeur
            // 
            this.txtValeur.AutoSize = true;
            this.txtValeur.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeur.Location = new System.Drawing.Point(489, 53);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(58, 19);
            this.txtValeur.TabIndex = 4;
            this.txtValeur.Text = "Valeur";
            this.txtValeur.Click += new System.EventHandler(this.txtValeur_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(399, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(537, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 39);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelContenu
            // 
            this.panelContenu.BackColor = System.Drawing.Color.White;
            this.panelContenu.Controls.Add(this.txtLibelleAnneeAcademique);
            this.panelContenu.Controls.Add(btnRemove);
            this.panelContenu.Controls.Add(this.dgAnneeAcademique);
            this.panelContenu.Controls.Add(this.btnEdit);
            this.panelContenu.Controls.Add(this.txtTexte);
            this.panelContenu.Controls.Add(this.btnAdd);
            this.panelContenu.Controls.Add(this.BtnSelect);
            this.panelContenu.Controls.Add(this.txtAnneeAcademiqueVal);
            this.panelContenu.Controls.Add(this.txtValeur);
            this.panelContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenu.Location = new System.Drawing.Point(0, 0);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Size = new System.Drawing.Size(819, 450);
            this.panelContenu.TabIndex = 8;
            this.panelContenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenu_Paint);
            // 
            // frmAnneeAcademique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenu);
            this.Name = "frmAnneeAcademique";
            this.Text = "AnneeAcademique";
            this.Load += new System.EventHandler(this.frmAnneeAcademique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).EndInit();
            this.panelContenu.ResumeLayout(false);
            this.panelContenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAnneeAcademique;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label txtTexte;
        private System.Windows.Forms.TextBox txtLibelleAnneeAcademique;
        private System.Windows.Forms.TextBox txtAnneeAcademiqueVal;
        private System.Windows.Forms.Label txtValeur;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelContenu;
    }
}