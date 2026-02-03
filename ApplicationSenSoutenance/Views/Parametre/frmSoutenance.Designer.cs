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
            this.btnRemove = new System.Windows.Forms.Button();
            this.panelContenu = new System.Windows.Forms.Panel();
            this.cmbMemoire = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateSoutenance = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.dgSoutenances = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMention = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbResultat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.Sujet = new System.Windows.Forms.Label();
            this.panelContenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenances)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnRemove.Location = new System.Drawing.Point(1199, 266);
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
            this.panelContenu.Controls.Add(this.cmbMemoire);
            this.panelContenu.Controls.Add(this.label5);
            this.panelContenu.Controls.Add(this.txtObservation);
            this.panelContenu.Controls.Add(this.label4);
            this.panelContenu.Controls.Add(this.dtpDateSoutenance);
            this.panelContenu.Controls.Add(this.label3);
            this.panelContenu.Controls.Add(this.BtnSelect);
            this.panelContenu.Controls.Add(this.dgSoutenances);
            this.panelContenu.Controls.Add(this.btnRemove);
            this.panelContenu.Controls.Add(this.btnEdit);
            this.panelContenu.Controls.Add(this.btnAdd);
            this.panelContenu.Controls.Add(this.cmbMention);
            this.panelContenu.Controls.Add(this.label2);
            this.panelContenu.Controls.Add(this.cmbResultat);
            this.panelContenu.Controls.Add(this.label1);
            this.panelContenu.Controls.Add(this.txtLieu);
            this.panelContenu.Controls.Add(this.Sujet);
            this.panelContenu.Location = new System.Drawing.Point(0, 0);
            this.panelContenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContenu.Name = "panelContenu";
            this.panelContenu.Size = new System.Drawing.Size(1917, 692);
            this.panelContenu.TabIndex = 1;
            this.panelContenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenu_Paint);
            // 
            // cmbMemoire
            // 
            this.cmbMemoire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemoire.FormattingEnabled = true;
            this.cmbMemoire.Location = new System.Drawing.Point(1454, 266);
            this.cmbMemoire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMemoire.Name = "cmbMemoire";
            this.cmbMemoire.Size = new System.Drawing.Size(100, 28);
            this.cmbMemoire.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1449, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mémoire";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(1554, 102);
            this.txtObservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservation.MaxLength = 5000;
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservation.Size = new System.Drawing.Size(253, 44);
            this.txtObservation.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1549, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "ObservationsSoutenance";
            // 
            // dtpDateSoutenance
            // 
            this.dtpDateSoutenance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSoutenance.Location = new System.Drawing.Point(537, 285);
            this.dtpDateSoutenance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateSoutenance.Name = "dtpDateSoutenance";
            this.dtpDateSoutenance.Size = new System.Drawing.Size(214, 26);
            this.dtpDateSoutenance.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "DateSoutenance";
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSelect.Location = new System.Drawing.Point(823, 200);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(165, 55);
            this.BtnSelect.TabIndex = 4;
            this.BtnSelect.Text = "&Selectionner";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // dgSoutenances
            // 
            this.dgSoutenances.AllowUserToAddRows = false;
            this.dgSoutenances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSoutenances.BackgroundColor = System.Drawing.Color.White;
            this.dgSoutenances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoutenances.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSoutenances.Location = new System.Drawing.Point(0, 503);
            this.dgSoutenances.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgSoutenances.Name = "dgSoutenances";
            this.dgSoutenances.ReadOnly = true;
            this.dgSoutenances.RowHeadersVisible = false;
            this.dgSoutenances.RowHeadersWidth = 62;
            this.dgSoutenances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSoutenances.Size = new System.Drawing.Size(1917, 189);
            this.dgSoutenances.TabIndex = 8;
            this.dgSoutenances.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSoutenances_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(1199, 196);
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
            this.btnAdd.Location = new System.Drawing.Point(826, 268);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbMention
            // 
            this.cmbMention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMention.FormattingEnabled = true;
            this.cmbMention.Location = new System.Drawing.Point(1255, 116);
            this.cmbMention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMention.Name = "cmbMention";
            this.cmbMention.Size = new System.Drawing.Size(253, 28);
            this.cmbMention.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1250, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "MentionSoutenance";
            // 
            // cmbResultat
            // 
            this.cmbResultat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultat.FormattingEnabled = true;
            this.cmbResultat.Location = new System.Drawing.Point(962, 116);
            this.cmbResultat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbResultat.Name = "cmbResultat";
            this.cmbResultat.Size = new System.Drawing.Size(253, 28);
            this.cmbResultat.TabIndex = 2;
            this.cmbResultat.SelectedIndexChanged += new System.EventHandler(this.cmbResultat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(958, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ResultatSoutenance";
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(684, 104);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLieu.Multiline = true;
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(253, 44);
            this.txtLieu.TabIndex = 1;
            // 
            // Sujet
            // 
            this.Sujet.AutoSize = true;
            this.Sujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sujet.Location = new System.Drawing.Point(679, 39);
            this.Sujet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sujet.Name = "Sujet";
            this.Sujet.Size = new System.Drawing.Size(201, 29);
            this.Sujet.TabIndex = 0;
            this.Sujet.Text = "LieuSoutenance";
            // 
            // frmSoutenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSoutenance";
            this.Text = "frmSoutenance";
            this.Load += new System.EventHandler(this.frmSoutenance_Load);
            this.panelContenu.ResumeLayout(false);
            this.panelContenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenu;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.DataGridView dgSoutenances;
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
        private System.Windows.Forms.Button btnRemove;
    }
}