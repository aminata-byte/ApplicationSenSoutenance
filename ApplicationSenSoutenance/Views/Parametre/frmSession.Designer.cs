namespace ApplicationSenSoutenance.Views.Parametre
{
    partial class frmSession
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgSession = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.txtValeur = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.txtTexte = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.txtRSession = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRanneeAcademique = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ttx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSession
            // 
            this.dgSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSession.BackgroundColor = System.Drawing.Color.Linen;
            this.dgSession.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSession.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSession.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSession.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgSession.Location = new System.Drawing.Point(390, 626);
            this.dgSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgSession.Name = "dgSession";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSession.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgSession.RowHeadersWidth = 62;
            this.dgSession.Size = new System.Drawing.Size(1228, 210);
            this.dgSession.TabIndex = 9;
            this.dgSession.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSession_CellContentClick);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(1037, 255);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(285, 70);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(708, 255);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(287, 70);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(390, 255);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(252, 70);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.Gray;
            this.BtnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSelect.Location = new System.Drawing.Point(1364, 255);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(252, 70);
            this.BtnSelect.TabIndex = 6;
            this.BtnSelect.Text = "&Selectionner";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // txtValeur
            // 
            this.txtValeur.AutoSize = true;
            this.txtValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValeur.Location = new System.Drawing.Point(1053, 135);
            this.txtValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(201, 25);
            this.txtValeur.TabIndex = 14;
            this.txtValeur.Text = "Annee Academique";
            // 
            // txtSession
            // 
            this.txtSession.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSession.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSession.Location = new System.Drawing.Point(390, 180);
            this.txtSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(599, 26);
            this.txtSession.TabIndex = 1;
            this.txtSession.TextChanged += new System.EventHandler(this.txtSession_TextChanged);
            // 
            // txtTexte
            // 
            this.txtTexte.AutoSize = true;
            this.txtTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTexte.Location = new System.Drawing.Point(385, 135);
            this.txtTexte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTexte.Name = "txtTexte";
            this.txtTexte.Size = new System.Drawing.Size(90, 25);
            this.txtTexte.TabIndex = 13;
            this.txtTexte.Text = "Session";
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbbAnneeAcademique.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.ItemHeight = 20;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(1058, 178);
            this.cbbAnneeAcademique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(560, 28);
            this.cbbAnneeAcademique.TabIndex = 2;
            this.cbbAnneeAcademique.SelectedIndexChanged += new System.EventHandler(this.cbbAnneeAcademique_SelectedIndexChanged);
            // 
            // txtRSession
            // 
            this.txtRSession.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtRSession.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtRSession.Location = new System.Drawing.Point(887, 571);
            this.txtRSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRSession.Name = "txtRSession";
            this.txtRSession.Size = new System.Drawing.Size(287, 26);
            this.txtRSession.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(882, 536);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Session";
            // 
            // txtRanneeAcademique
            // 
            this.txtRanneeAcademique.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtRanneeAcademique.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtRanneeAcademique.Location = new System.Drawing.Point(1333, 571);
            this.txtRanneeAcademique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRanneeAcademique.Name = "txtRanneeAcademique";
<<<<<<< HEAD
            this.txtRanneeAcademique.Size = new System.Drawing.Size(172, 20);
            this.txtRanneeAcademique.TabIndex = 18;
            this.txtRanneeAcademique.TextChanged += new System.EventHandler(this.txtRanneeAcademique_TextChanged);
=======
            this.txtRanneeAcademique.Size = new System.Drawing.Size(285, 26);
            this.txtRanneeAcademique.TabIndex = 8;
>>>>>>> 32b1f3938606ebae267bcf56615f7003aae5352e
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1328, 536);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Annee Academique";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(390, 536);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(372, 70);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "&Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ttx
            // 
            this.ttx.AutoSize = true;
            this.ttx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ttx.Location = new System.Drawing.Point(879, 18);
            this.ttx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ttx.Name = "ttx";
            this.ttx.Size = new System.Drawing.Size(191, 46);
            this.ttx.TabIndex = 20;
            this.ttx.Text = "Sessions";
            this.ttx.Click += new System.EventHandler(this.ttx_Click);
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1651, 860);
            this.ControlBox = false;
            this.Controls.Add(this.ttx);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRanneeAcademique);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.txtTexte);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgSession);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSession";
            this.Text = "Session";
            this.Load += new System.EventHandler(this.frmSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSession;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label txtValeur;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label txtTexte;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.TextBox txtRSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRanneeAcademique;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label ttx;
    }
}