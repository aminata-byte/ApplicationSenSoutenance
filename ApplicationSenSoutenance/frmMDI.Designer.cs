namespace ApplicationSenSoutenance
{
    partial class frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anneeAcademiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chefDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soutenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMemoire = new System.Windows.Forms.Button();
            this.btnAnneeAcademique = new System.Windows.Forms.Button();
            this.lblTitreMenu = new System.Windows.Forms.Label();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkViolet;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.parametreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet;
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.seDeconnecterToolStripMenuItem.Text = "&Se deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // parametreToolStripMenuItem
            // 
            this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anneeAcademiqueToolStripMenuItem,
            this.sessionToolStripMenuItem,
            this.professeurToolStripMenuItem,
            this.candidatToolStripMenuItem,
            this.chefDepartementToolStripMenuItem,
            this.memoireToolStripMenuItem,
            this.soutenanceToolStripMenuItem,
            this.departementToolStripMenuItem});
            this.parametreToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            this.parametreToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.parametreToolStripMenuItem.Text = "&Parametre";
            this.parametreToolStripMenuItem.Click += new System.EventHandler(this.parametreToolStripMenuItem_Click);
            // 
            // anneeAcademiqueToolStripMenuItem
            // 
            this.anneeAcademiqueToolStripMenuItem.Name = "anneeAcademiqueToolStripMenuItem";
            this.anneeAcademiqueToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.anneeAcademiqueToolStripMenuItem.Text = "&Annee academique";
            this.anneeAcademiqueToolStripMenuItem.Click += new System.EventHandler(this.anneeAcademiqueToolStripMenuItem_Click);
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.sessionToolStripMenuItem.Text = "&Session";
            this.sessionToolStripMenuItem.Click += new System.EventHandler(this.sessionToolStripMenuItem_Click);
            // 
            // professeurToolStripMenuItem
            // 
            this.professeurToolStripMenuItem.Name = "professeurToolStripMenuItem";
            this.professeurToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.professeurToolStripMenuItem.Text = "&Professeur";
            this.professeurToolStripMenuItem.Click += new System.EventHandler(this.professeurToolStripMenuItem_Click);
            // 
            // candidatToolStripMenuItem
            // 
            this.candidatToolStripMenuItem.Name = "candidatToolStripMenuItem";
            this.candidatToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.candidatToolStripMenuItem.Text = "&Candidat";
            this.candidatToolStripMenuItem.Click += new System.EventHandler(this.candidatToolStripMenuItem_Click);
            // 
            // chefDepartementToolStripMenuItem
            // 
            this.chefDepartementToolStripMenuItem.Name = "chefDepartementToolStripMenuItem";
            this.chefDepartementToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.chefDepartementToolStripMenuItem.Text = "&Chef de departement";
            this.chefDepartementToolStripMenuItem.Click += new System.EventHandler(this.chefDepartementToolStripMenuItem_Click);
            // 
            // memoireToolStripMenuItem
            // 
            this.memoireToolStripMenuItem.Name = "memoireToolStripMenuItem";
            this.memoireToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.memoireToolStripMenuItem.Text = "&Memoire";
            this.memoireToolStripMenuItem.Click += new System.EventHandler(this.memoireToolStripMenuItem_Click);
            // 
            // soutenanceToolStripMenuItem
            // 
            this.soutenanceToolStripMenuItem.Name = "soutenanceToolStripMenuItem";
            this.soutenanceToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.soutenanceToolStripMenuItem.Text = "&Soutenance";
            this.soutenanceToolStripMenuItem.Click += new System.EventHandler(this.soutenanceToolStripMenuItem_Click);
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.Name = "departementToolStripMenuItem";
            this.departementToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.departementToolStripMenuItem.Text = "&Departement";
            this.departementToolStripMenuItem.Click += new System.EventHandler(this.departementToolStripMenuItem_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.BtnQuitter);
            this.panelMenu.Controls.Add(this.btnMemoire);
            this.panelMenu.Controls.Add(this.btnAnneeAcademique);
            this.panelMenu.Controls.Add(this.lblTitreMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 29);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 421);
            this.panelMenu.TabIndex = 8;
            // 
            // btnMemoire
            // 
            this.btnMemoire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoire.ForeColor = System.Drawing.Color.White;
            this.btnMemoire.Location = new System.Drawing.Point(0, 59);
            this.btnMemoire.Name = "btnMemoire";
            this.btnMemoire.Size = new System.Drawing.Size(230, 35);
            this.btnMemoire.TabIndex = 3;
            this.btnMemoire.Text = "Memoire";
            this.btnMemoire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemoire.UseVisualStyleBackColor = true;
            this.btnMemoire.Click += new System.EventHandler(this.btnMemoire_Click);
            // 
            // btnAnneeAcademique
            // 
            this.btnAnneeAcademique.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnneeAcademique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnneeAcademique.ForeColor = System.Drawing.Color.White;
            this.btnAnneeAcademique.Location = new System.Drawing.Point(0, 24);
            this.btnAnneeAcademique.Name = "btnAnneeAcademique";
            this.btnAnneeAcademique.Size = new System.Drawing.Size(230, 35);
            this.btnAnneeAcademique.TabIndex = 1;
            this.btnAnneeAcademique.Text = "Année Académique";
            this.btnAnneeAcademique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnneeAcademique.UseVisualStyleBackColor = true;
            this.btnAnneeAcademique.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitreMenu
            // 
            this.lblTitreMenu.AutoSize = true;
            this.lblTitreMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreMenu.ForeColor = System.Drawing.Color.White;
            this.lblTitreMenu.Location = new System.Drawing.Point(0, 0);
            this.lblTitreMenu.Name = "lblTitreMenu";
            this.lblTitreMenu.Size = new System.Drawing.Size(165, 24);
            this.lblTitreMenu.TabIndex = 0;
            this.lblTitreMenu.Text = "Sen Soutenance";
            this.lblTitreMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(72)))), ((int)(((byte)(89)))));
            this.BtnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.ForeColor = System.Drawing.Color.White;
            this.BtnQuitter.Location = new System.Drawing.Point(-11, 384);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(241, 40);
            this.BtnQuitter.TabIndex = 4;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = false;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Soutenance";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Sen Soutenance ::";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anneeAcademiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chefDepartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soutenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departementToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMemoire;
        private System.Windows.Forms.Button btnAnneeAcademique;
        private System.Windows.Forms.Label lblTitreMenu;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button button1;
    }
}