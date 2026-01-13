namespace ApplicationSenSoutenance.Views.Parametre
{
    partial class frmSoutenance
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
            this.panelContenu = new System.Windows.Forms.Panel();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.dgMemoires = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMention = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbResultat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.Sujet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateSoutenance = new System.Windows.Forms.DateTimePicker();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMemoire = new System.Windows.Forms.ComboBox();
            btnRemove = new System.Windows.Forms.Button();
            this.panelContenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoires)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenu
            // 
            this.panelContenu.BackColor = System.Drawing.Color.White;
            this.panelContenu.Controls.Add(this.cmbMemoire);
            this.panelContenu.Controls.Add(this.label5);
            this.panelContenu.Controls.Add(this.txtObservation);
            this.panelContenu.Controls.Add(this.label4);
            this.panelContenu.Controls.Add(this.dtpDateSoutenance);
            this.panelContenu.Controls.Add(this.label3);
            this.panelContenu.Controls.Add(this.BtnSelect);
            this.panelContenu.Controls.Add(this.dgMemoires);
            this.panelContenu.Controls.Add(btnRemove);
            this.panelContenu.Controls.Add(this.btnEdit);
            this.panelContenu.Controls.Add(this.btnAdd);
            this.panelContenu.Controls.Add(this.cmbMention);
            this.panelContenu.Controls.Add(this.label2);
            this.panelContenu.Controls.Add(this.cmbResultat);
            this.panelContenu.Controls.Add(this.label1);
            this.panelContenu.Controls.Add(this.txtLieu);
            this.panelContenu.Controls.Add(this.Sujet);
            this.panelContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenu.Location = new System.Drawing.Point(0, 0);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Size = new System.Drawing.Size(1219, 450);
            this.panelContenu.TabIndex = 1;
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSelect.Location = new System.Drawing.Point(268, 173);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(110, 36);
            this.BtnSelect.TabIndex = 4;
            this.BtnSelect.Text = "&Selectionner";
            this.BtnSelect.UseVisualStyleBackColor = false;
            // 
            // dgMemoires
            // 
            this.dgMemoires.AllowUserToAddRows = false;
            this.dgMemoires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMemoires.BackgroundColor = System.Drawing.Color.White;
            this.dgMemoires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemoires.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgMemoires.Location = new System.Drawing.Point(0, 209);
            this.dgMemoires.Name = "dgMemoires";
            this.dgMemoires.ReadOnly = true;
            this.dgMemoires.RowHeadersVisible = false;
            this.dgMemoires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMemoires.Size = new System.Drawing.Size(1219, 241);
            this.dgMemoires.TabIndex = 8;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = System.Drawing.Color.DarkRed;
            btnRemove.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRemove.ForeColor = System.Drawing.Color.LavenderBlush;
            btnRemove.Location = new System.Drawing.Point(674, 172);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(108, 37);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "&Supprimer";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(536, 170);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 39);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(398, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbMention
            // 
            this.cmbMention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMention.FormattingEnabled = true;
            this.cmbMention.Items.AddRange(new object[] {
            "Passable",
            "Assez Bien",
            "Bien",
            "Très Bien",
            "Excellent"});
            this.cmbMention.Location = new System.Drawing.Point(558, 69);
            this.cmbMention.Name = "cmbMention";
            this.cmbMention.Size = new System.Drawing.Size(170, 21);
            this.cmbMention.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "MentionSoutenance";
            // 
            // cmbResultat
            // 
            this.cmbResultat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultat.FormattingEnabled = true;
            this.cmbResultat.Items.AddRange(new object[] {
            "Admis",
            "Ajourné",
            "Refusé"});
            this.cmbResultat.Location = new System.Drawing.Point(363, 69);
            this.cmbResultat.Name = "cmbResultat";
            this.cmbResultat.Size = new System.Drawing.Size(170, 21);
            this.cmbResultat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ResultatSoutenance";
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(177, 61);
            this.txtLieu.Multiline = true;
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(170, 30);
            this.txtLieu.TabIndex = 1;
            // 
            // Sujet
            // 
            this.Sujet.AutoSize = true;
            this.Sujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sujet.Location = new System.Drawing.Point(174, 19);
            this.Sujet.Name = "Sujet";
            this.Sujet.Size = new System.Drawing.Size(128, 18);
            this.Sujet.TabIndex = 0;
            this.Sujet.Text = "LieuSoutenance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "DateSoutenance";
            // 
            // dtpDateSoutenance
            // 
            this.dtpDateSoutenance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSoutenance.Location = new System.Drawing.Point(12, 71);
            this.dtpDateSoutenance.Name = "dtpDateSoutenance";
            this.dtpDateSoutenance.Size = new System.Drawing.Size(144, 20);
            this.dtpDateSoutenance.TabIndex = 10;
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(757, 60);
            this.txtObservation.MaxLength = 5000;
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservation.Size = new System.Drawing.Size(170, 30);
            this.txtObservation.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(754, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "ObservationsSoutenance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(972, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mémoire";
            // 
            // cmbMemoire
            // 
            this.cmbMemoire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoire.FormattingEnabled = true;
            this.cmbMemoire.Location = new System.Drawing.Point(975, 69);
            this.cmbMemoire.Name = "cmbMemoire";
            this.cmbMemoire.Size = new System.Drawing.Size(121, 21);
            this.cmbMemoire.TabIndex = 14;
            // 
            // frmSoutenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenu);
            this.Name = "frmSoutenance";
            this.Text = "frmSoutenance";
            this.Load += new System.EventHandler(this.frmSoutenance_Load);
            this.panelContenu.ResumeLayout(false);
            this.panelContenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.DataGridView dgMemoires;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbMention;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label Sujet;
        private System.Windows.Forms.DateTimePicker dtpDateSoutenance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMemoire;
        private System.Windows.Forms.Label label5;
    }
}