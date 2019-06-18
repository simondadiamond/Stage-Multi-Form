namespace GestionStages
{
    partial class stagiaire
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
            this.grp_stagiaire = new System.Windows.Forms.GroupBox();
            this.txt_courriel = new System.Windows.Forms.TextBox();
            this.lbl_courriel = new System.Windows.Forms.Label();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.lbl_telephone = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.gestionnaireErreurs = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_stagiaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireErreurs)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_stagiaire
            // 
            this.grp_stagiaire.Controls.Add(this.txt_courriel);
            this.grp_stagiaire.Controls.Add(this.lbl_courriel);
            this.grp_stagiaire.Controls.Add(this.txt_telephone);
            this.grp_stagiaire.Controls.Add(this.lbl_telephone);
            this.grp_stagiaire.Controls.Add(this.txt_nom);
            this.grp_stagiaire.Controls.Add(this.lbl_nom);
            this.grp_stagiaire.Controls.Add(this.txt_id);
            this.grp_stagiaire.Controls.Add(this.lbl_id);
            this.grp_stagiaire.Location = new System.Drawing.Point(13, 13);
            this.grp_stagiaire.Name = "grp_stagiaire";
            this.grp_stagiaire.Size = new System.Drawing.Size(343, 162);
            this.grp_stagiaire.TabIndex = 0;
            this.grp_stagiaire.TabStop = false;
            this.grp_stagiaire.Text = "Stagiaire";
            // 
            // txt_courriel
            // 
            this.txt_courriel.Location = new System.Drawing.Point(128, 124);
            this.txt_courriel.Name = "txt_courriel";
            this.txt_courriel.Size = new System.Drawing.Size(175, 20);
            this.txt_courriel.TabIndex = 7;
            this.txt_courriel.Validating += new System.ComponentModel.CancelEventHandler(this.txt_courriel_Validating);
            // 
            // lbl_courriel
            // 
            this.lbl_courriel.AutoSize = true;
            this.lbl_courriel.Location = new System.Drawing.Point(58, 128);
            this.lbl_courriel.Name = "lbl_courriel";
            this.lbl_courriel.Size = new System.Drawing.Size(48, 13);
            this.lbl_courriel.TabIndex = 6;
            this.lbl_courriel.Text = "Courriel :";
            this.lbl_courriel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(128, 88);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(175, 20);
            this.txt_telephone.TabIndex = 5;
            this.txt_telephone.Validating += new System.ComponentModel.CancelEventHandler(this.txt_telephone_Validating);
            // 
            // lbl_telephone
            // 
            this.lbl_telephone.AutoSize = true;
            this.lbl_telephone.Location = new System.Drawing.Point(6, 84);
            this.lbl_telephone.Name = "lbl_telephone";
            this.lbl_telephone.Size = new System.Drawing.Size(101, 26);
            this.lbl_telephone.TabIndex = 4;
            this.lbl_telephone.Text = "Téléphone :\r\n(format xxx-xxx-xxxx)";
            this.lbl_telephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(128, 53);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(175, 20);
            this.txt_nom.TabIndex = 3;
            this.txt_nom.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nom_Validating);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(72, 56);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 2;
            this.lbl_nom.Text = "Nom :";
            this.lbl_nom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(128, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(175, 20);
            this.txt_id.TabIndex = 1;
            this.txt_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_id_Validating);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(41, 23);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(66, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID employé :";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(199, 181);
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
            this.btn_annuler.Location = new System.Drawing.Point(281, 181);
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
            // stagiaire
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_annuler;
            this.ClientSize = new System.Drawing.Size(368, 212);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.grp_stagiaire);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stagiaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter / Modifier un stagiaire";
            this.grp_stagiaire.ResumeLayout(false);
            this.grp_stagiaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireErreurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_stagiaire;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_telephone;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.TextBox txt_courriel;
        private System.Windows.Forms.Label lbl_courriel;
        private System.Windows.Forms.ErrorProvider gestionnaireErreurs;
    }
}