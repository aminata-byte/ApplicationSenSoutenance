namespace ApplicationSenSoutenance.Views.Parametre
{
    partial class frmMemoire
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.panelContenu = new System.Windows.Forms.Panel();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.dgMemoires = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSujetMemoire = new System.Windows.Forms.TextBox();
            this.Sujet = new System.Windows.Forms.Label();
            this.panelContenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoires)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnRemove.Location = new System.Drawing.Point(1421, 234);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 57);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panelContenu
            // 
            this.panelContenu.BackColor = System.Drawing.Color.White;
            this.panelContenu.Controls.Add(this.BtnSelect);
            this.panelContenu.Controls.Add(this.dgMemoires);
            this.panelContenu.Controls.Add(this.btnRemove);
            this.panelContenu.Controls.Add(this.btnEdit);
            this.panelContenu.Controls.Add(this.btnAdd);
            this.panelContenu.Controls.Add(this.cmbSession);
            this.panelContenu.Controls.Add(this.label2);
            this.panelContenu.Controls.Add(this.cmbAnneeAcademique);
            this.panelContenu.Controls.Add(this.label1);
            this.panelContenu.Controls.Add(this.txtSujetMemoire);
            this.panelContenu.Controls.Add(this.Sujet);
            this.panelContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenu.Location = new System.Drawing.Point(0, 0);
            this.panelContenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Size = new System.Drawing.Size(1744, 692);
            this.panelContenu.TabIndex = 0;
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSelect.Location = new System.Drawing.Point(812, 235);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(165, 55);
            this.BtnSelect.TabIndex = 4;
            this.BtnSelect.Text = "&Selectionner";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click_1);
            // 
            // dgMemoires
            // 
            this.dgMemoires.AllowUserToAddRows = false;
            this.dgMemoires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMemoires.BackgroundColor = System.Drawing.Color.White;
            this.dgMemoires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemoires.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgMemoires.Location = new System.Drawing.Point(0, 321);
            this.dgMemoires.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgMemoires.Name = "dgMemoires";
            this.dgMemoires.ReadOnly = true;
            this.dgMemoires.RowHeadersVisible = false;
            this.dgMemoires.RowHeadersWidth = 62;
            this.dgMemoires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMemoires.Size = new System.Drawing.Size(1744, 371);
            this.dgMemoires.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(1214, 231);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 60);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(1007, 235);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbSession
            // 
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(1350, 127);
            this.cmbSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(253, 28);
            this.cmbSession.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1346, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Session";
            // 
            // cmbAnneeAcademique
            // 
            this.cmbAnneeAcademique.FormattingEnabled = true;
            this.cmbAnneeAcademique.Location = new System.Drawing.Point(1044, 127);
            this.cmbAnneeAcademique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAnneeAcademique.Name = "cmbAnneeAcademique";
            this.cmbAnneeAcademique.Size = new System.Drawing.Size(253, 28);
            this.cmbAnneeAcademique.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1040, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Année Académique";
            // 
            // txtSujetMemoire
            // 
            this.txtSujetMemoire.Location = new System.Drawing.Point(742, 115);
            this.txtSujetMemoire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSujetMemoire.Multiline = true;
            this.txtSujetMemoire.Name = "txtSujetMemoire";
            this.txtSujetMemoire.Size = new System.Drawing.Size(253, 44);
            this.txtSujetMemoire.TabIndex = 1;
            this.txtSujetMemoire.TextChanged += new System.EventHandler(this.txtSujetMemoire_TextChanged);
            // 
            // Sujet
            // 
            this.Sujet.AutoSize = true;
            this.Sujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sujet.Location = new System.Drawing.Point(737, 51);
            this.Sujet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sujet.Name = "Sujet";
            this.Sujet.Size = new System.Drawing.Size(183, 29);
            this.Sujet.TabIndex = 0;
            this.Sujet.Text = "Sujet Mémoire";
            this.Sujet.Click += new System.EventHandler(this.Sujet_Click);
            // 
            // frmMemoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 692);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMemoire";
            this.Text = "frmMemoire";
            this.Load += new System.EventHandler(this.frmMemoire_Load);
            this.panelContenu.ResumeLayout(false);
            this.panelContenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.Label Sujet;
        private System.Windows.Forms.TextBox txtSujetMemoire;
        private System.Windows.Forms.ComboBox cmbAnneeAcademique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgMemoires;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button btnRemove;
    }
}