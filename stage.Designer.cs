namespace GestionStages
{
    partial class stage
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_commentaire = new System.Windows.Forms.TextBox();
            this.lbl_commentaire = new System.Windows.Forms.Label();
            this.txt_superviseur = new System.Windows.Forms.TextBox();
            this.lbl_superviseur = new System.Windows.Forms.Label();
            this.txt_fin = new System.Windows.Forms.TextBox();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.txt_debut = new System.Windows.Forms.TextBox();
            this.lbl_debut = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.gestionnaireErreurs = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireErreurs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_commentaire);
            this.groupBox1.Controls.Add(this.lbl_commentaire);
            this.groupBox1.Controls.Add(this.txt_superviseur);
            this.groupBox1.Controls.Add(this.lbl_superviseur);
            this.groupBox1.Controls.Add(this.txt_fin);
            this.groupBox1.Controls.Add(this.lbl_fin);
            this.groupBox1.Controls.Add(this.txt_debut);
            this.groupBox1.Controls.Add(this.lbl_debut);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.lbl_nom);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stage";
            // 
            // txt_commentaire
            // 
            this.txt_commentaire.Location = new System.Drawing.Point(140, 175);
            this.txt_commentaire.Multiline = true;
            this.txt_commentaire.Name = "txt_commentaire";
            this.txt_commentaire.Size = new System.Drawing.Size(242, 98);
            this.txt_commentaire.TabIndex = 9;
            // 
            // lbl_commentaire
            // 
            this.lbl_commentaire.AutoSize = true;
            this.lbl_commentaire.Location = new System.Drawing.Point(53, 175);
            this.lbl_commentaire.Name = "lbl_commentaire";
            this.lbl_commentaire.Size = new System.Drawing.Size(74, 26);
            this.lbl_commentaire.TabIndex = 8;
            this.lbl_commentaire.Text = "Commentaire :\r\n  ( optionnel )";
            this.lbl_commentaire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_superviseur
            // 
            this.txt_superviseur.Location = new System.Drawing.Point(140, 136);
            this.txt_superviseur.Name = "txt_superviseur";
            this.txt_superviseur.Size = new System.Drawing.Size(242, 20);
            this.txt_superviseur.TabIndex = 7;
            // 
            // lbl_superviseur
            // 
            this.lbl_superviseur.AutoSize = true;
            this.lbl_superviseur.Location = new System.Drawing.Point(20, 133);
            this.lbl_superviseur.Name = "lbl_superviseur";
            this.lbl_superviseur.Size = new System.Drawing.Size(107, 26);
            this.lbl_superviseur.TabIndex = 6;
            this.lbl_superviseur.Text = "Nom du superviseur :\r\n              ( optionnel )";
            // 
            // txt_fin
            // 
            this.txt_fin.Location = new System.Drawing.Point(140, 95);
            this.txt_fin.Name = "txt_fin";
            this.txt_fin.Size = new System.Drawing.Size(242, 20);
            this.txt_fin.TabIndex = 5;
            this.txt_fin.Validating += new System.ComponentModel.CancelEventHandler(this.txt_fin_Validating);
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(58, 92);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(69, 26);
            this.lbl_fin.TabIndex = 4;
            this.lbl_fin.Text = "Date de fin :\r\n( aaaa-mm-jj )";
            this.lbl_fin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_debut
            // 
            this.txt_debut.Location = new System.Drawing.Point(140, 55);
            this.txt_debut.Name = "txt_debut";
            this.txt_debut.Size = new System.Drawing.Size(242, 20);
            this.txt_debut.TabIndex = 3;
            this.txt_debut.Validating += new System.ComponentModel.CancelEventHandler(this.txt_debut_Validating);
            // 
            // lbl_debut
            // 
            this.lbl_debut.AutoSize = true;
            this.lbl_debut.Location = new System.Drawing.Point(46, 51);
            this.lbl_debut.Name = "lbl_debut";
            this.lbl_debut.Size = new System.Drawing.Size(81, 26);
            this.lbl_debut.TabIndex = 2;
            this.lbl_debut.Text = "Date de début :\r\n( aaaa-mm-jj )";
            this.lbl_debut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(140, 19);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(242, 20);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            this.txt_nom.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nom_Validating);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(48, 22);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(79, 13);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nom du stage :";
            this.lbl_nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(279, 302);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "&OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_annuler.Location = new System.Drawing.Point(361, 302);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "&Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // gestionnaireErreurs
            // 
            this.gestionnaireErreurs.ContainerControl = this;
            // 
            // stage
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_annuler;
            this.ClientSize = new System.Drawing.Size(448, 333);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter / Modifier un stage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireErreurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_fin;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.TextBox txt_debut;
        private System.Windows.Forms.Label lbl_debut;
        private System.Windows.Forms.Label lbl_superviseur;
        private System.Windows.Forms.TextBox txt_commentaire;
        private System.Windows.Forms.Label lbl_commentaire;
        private System.Windows.Forms.TextBox txt_superviseur;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.ErrorProvider gestionnaireErreurs;
    }
}