namespace GestionStages
{
    partial class principale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grp_rechercher = new System.Windows.Forms.GroupBox();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.grp_gestionFichier = new System.Windows.Forms.GroupBox();
            this.btn_sauvegarder = new System.Windows.Forms.Button();
            this.btn_charger = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.grp_stagiaires = new System.Windows.Forms.GroupBox();
            this.lst_stagiaires = new System.Windows.Forms.ListBox();
            this.grp_stages = new System.Windows.Forms.GroupBox();
            this.lst_stages = new System.Windows.Forms.ListBox();
            this.grp_gestion = new System.Windows.Forms.GroupBox();
            this.btn_modifierStage = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_stagiaire = new System.Windows.Forms.Button();
            this.btn_stage = new System.Windows.Forms.Button();
            this.btn_modifierStagiaire = new System.Windows.Forms.Button();
            this.grp_affichage = new System.Windows.Forms.GroupBox();
            this.txt_affichage = new System.Windows.Forms.TextBox();
            this.gestionnaireErreurs = new System.Windows.Forms.ErrorProvider(this.components);
            this.dlg_sauvergarder = new System.Windows.Forms.OpenFileDialog();
            this.dlg_charger = new System.Windows.Forms.OpenFileDialog();
            this.grp_rechercher.SuspendLayout();
            this.grp_gestionFichier.SuspendLayout();
            this.grp_stagiaires.SuspendLayout();
            this.grp_stages.SuspendLayout();
            this.grp_gestion.SuspendLayout();
            this.grp_affichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireErreurs)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_rechercher
            // 
            this.grp_rechercher.Controls.Add(this.txt_recherche);
            this.grp_rechercher.Location = new System.Drawing.Point(223, 12);
            this.grp_rechercher.Name = "grp_rechercher";
            this.grp_rechercher.Size = new System.Drawing.Size(416, 64);
            this.grp_rechercher.TabIndex = 0;
            this.grp_rechercher.TabStop = false;
            this.grp_rechercher.Text = "Rechercher";
            // 
            // txt_recherche
            // 
            this.txt_recherche.Location = new System.Drawing.Point(10, 29);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(399, 20);
            this.txt_recherche.TabIndex = 0;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // grp_gestionFichier
            // 
            this.grp_gestionFichier.Controls.Add(this.btn_sauvegarder);
            this.grp_gestionFichier.Controls.Add(this.btn_charger);
            this.grp_gestionFichier.Location = new System.Drawing.Point(12, 12);
            this.grp_gestionFichier.Name = "grp_gestionFichier";
            this.grp_gestionFichier.Size = new System.Drawing.Size(202, 64);
            this.grp_gestionFichier.TabIndex = 1;
            this.grp_gestionFichier.TabStop = false;
            this.grp_gestionFichier.Text = "Gestion des fichiers";
            this.grp_gestionFichier.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_sauvegarder
            // 
            this.btn_sauvegarder.Location = new System.Drawing.Point(111, 21);
            this.btn_sauvegarder.Name = "btn_sauvegarder";
            this.btn_sauvegarder.Size = new System.Drawing.Size(85, 34);
            this.btn_sauvegarder.TabIndex = 1;
            this.btn_sauvegarder.Text = "&Sauvegarder";
            this.btn_sauvegarder.UseVisualStyleBackColor = true;
            this.btn_sauvegarder.Click += new System.EventHandler(this.btn_sauvegarder_Click);
            // 
            // btn_charger
            // 
            this.btn_charger.Location = new System.Drawing.Point(7, 21);
            this.btn_charger.Name = "btn_charger";
            this.btn_charger.Size = new System.Drawing.Size(98, 34);
            this.btn_charger.TabIndex = 0;
            this.btn_charger.Text = "&Charger";
            this.btn_charger.UseVisualStyleBackColor = true;
            this.btn_charger.Click += new System.EventHandler(this.btn_charger_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(543, 355);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(96, 44);
            this.btn_quitter.TabIndex = 2;
            this.btn_quitter.Text = "&Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // grp_stagiaires
            // 
            this.grp_stagiaires.Controls.Add(this.lst_stagiaires);
            this.grp_stagiaires.Location = new System.Drawing.Point(12, 95);
            this.grp_stagiaires.Name = "grp_stagiaires";
            this.grp_stagiaires.Size = new System.Drawing.Size(203, 237);
            this.grp_stagiaires.TabIndex = 3;
            this.grp_stagiaires.TabStop = false;
            this.grp_stagiaires.Text = "Stagiaires";
            // 
            // lst_stagiaires
            // 
            this.lst_stagiaires.FormattingEnabled = true;
            this.lst_stagiaires.Location = new System.Drawing.Point(7, 20);
            this.lst_stagiaires.Name = "lst_stagiaires";
            this.lst_stagiaires.Size = new System.Drawing.Size(189, 212);
            this.lst_stagiaires.TabIndex = 0;
            this.lst_stagiaires.SelectedIndexChanged += new System.EventHandler(this.lst_stagiaires_SelectedIndexChanged);
            // 
            // grp_stages
            // 
            this.grp_stages.Controls.Add(this.lst_stages);
            this.grp_stages.Location = new System.Drawing.Point(222, 95);
            this.grp_stages.Name = "grp_stages";
            this.grp_stages.Size = new System.Drawing.Size(202, 237);
            this.grp_stages.TabIndex = 4;
            this.grp_stages.TabStop = false;
            this.grp_stages.Text = "Stages";
            // 
            // lst_stages
            // 
            this.lst_stages.FormattingEnabled = true;
            this.lst_stages.Location = new System.Drawing.Point(7, 20);
            this.lst_stages.Name = "lst_stages";
            this.lst_stages.Size = new System.Drawing.Size(189, 212);
            this.lst_stages.TabIndex = 0;
            this.lst_stages.SelectedIndexChanged += new System.EventHandler(this.lst_stages_SelectedIndexChanged);
            // 
            // grp_gestion
            // 
            this.grp_gestion.Controls.Add(this.btn_modifierStage);
            this.grp_gestion.Controls.Add(this.btn_supprimer);
            this.grp_gestion.Controls.Add(this.btn_stagiaire);
            this.grp_gestion.Controls.Add(this.btn_stage);
            this.grp_gestion.Controls.Add(this.btn_modifierStagiaire);
            this.grp_gestion.Location = new System.Drawing.Point(12, 338);
            this.grp_gestion.Name = "grp_gestion";
            this.grp_gestion.Size = new System.Drawing.Size(491, 72);
            this.grp_gestion.TabIndex = 5;
            this.grp_gestion.TabStop = false;
            this.grp_gestion.Text = "Gestion";
            // 
            // btn_modifierStage
            // 
            this.btn_modifierStage.Location = new System.Drawing.Point(295, 21);
            this.btn_modifierStage.Name = "btn_modifierStage";
            this.btn_modifierStage.Size = new System.Drawing.Size(90, 40);
            this.btn_modifierStage.TabIndex = 4;
            this.btn_modifierStage.Text = "&Modifier un stage";
            this.btn_modifierStage.UseVisualStyleBackColor = true;
            this.btn_modifierStage.Click += new System.EventHandler(this.btn_modifierStage_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(391, 21);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(90, 40);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer un  stage";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_stagiaire
            // 
            this.btn_stagiaire.Location = new System.Drawing.Point(7, 21);
            this.btn_stagiaire.Name = "btn_stagiaire";
            this.btn_stagiaire.Size = new System.Drawing.Size(90, 40);
            this.btn_stagiaire.TabIndex = 1;
            this.btn_stagiaire.Text = "Ajouter un stagiaire";
            this.btn_stagiaire.UseVisualStyleBackColor = true;
            this.btn_stagiaire.Click += new System.EventHandler(this.btn_stagiaire_Click);
            // 
            // btn_stage
            // 
            this.btn_stage.Location = new System.Drawing.Point(103, 21);
            this.btn_stage.Name = "btn_stage";
            this.btn_stage.Size = new System.Drawing.Size(90, 40);
            this.btn_stage.TabIndex = 0;
            this.btn_stage.Text = "Ajouter un  stage";
            this.btn_stage.UseVisualStyleBackColor = true;
            this.btn_stage.Click += new System.EventHandler(this.btn_stage_Click);
            // 
            // btn_modifierStagiaire
            // 
            this.btn_modifierStagiaire.Location = new System.Drawing.Point(199, 21);
            this.btn_modifierStagiaire.Name = "btn_modifierStagiaire";
            this.btn_modifierStagiaire.Size = new System.Drawing.Size(90, 40);
            this.btn_modifierStagiaire.TabIndex = 2;
            this.btn_modifierStagiaire.Text = "Modifier Stagiaire";
            this.btn_modifierStagiaire.UseVisualStyleBackColor = true;
            this.btn_modifierStagiaire.Click += new System.EventHandler(this.btn_modifierStagiaire_Click);
            // 
            // grp_affichage
            // 
            this.grp_affichage.Controls.Add(this.txt_affichage);
            this.grp_affichage.Location = new System.Drawing.Point(431, 95);
            this.grp_affichage.Name = "grp_affichage";
            this.grp_affichage.Size = new System.Drawing.Size(207, 237);
            this.grp_affichage.TabIndex = 6;
            this.grp_affichage.TabStop = false;
            this.grp_affichage.Text = "Affichage";
            // 
            // txt_affichage
            // 
            this.txt_affichage.Location = new System.Drawing.Point(7, 20);
            this.txt_affichage.Multiline = true;
            this.txt_affichage.Name = "txt_affichage";
            this.txt_affichage.ReadOnly = true;
            this.txt_affichage.Size = new System.Drawing.Size(194, 211);
            this.txt_affichage.TabIndex = 0;
            this.txt_affichage.Text = "\r\n";
            // 
            // gestionnaireErreurs
            // 
            this.gestionnaireErreurs.ContainerControl = this;
            // 
            // dlg_sauvergarder
            // 
            this.dlg_sauvergarder.CheckFileExists = false;
            this.dlg_sauvergarder.DefaultExt = "xml";
            this.dlg_sauvergarder.FileName = "data.xml";
            this.dlg_sauvergarder.Filter = "Fichiers XML|*.xml";
            // 
            // dlg_charger
            // 
            this.dlg_charger.DefaultExt = "xml";
            this.dlg_charger.FileName = "data.xml";
            this.dlg_charger.Filter = "Fichiers XML|*.xml";
            // 
            // principale
            // 
            this.AcceptButton = this.btn_quitter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 414);
            this.Controls.Add(this.grp_affichage);
            this.Controls.Add(this.grp_gestion);
            this.Controls.Add(this.grp_stages);
            this.Controls.Add(this.grp_stagiaires);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.grp_gestionFichier);
            this.Controls.Add(this.grp_rechercher);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "principale";
            this.Text = "Banque de stagiaires";
            this.Load += new System.EventHandler(this.principale_Load);
            this.grp_rechercher.ResumeLayout(false);
            this.grp_rechercher.PerformLayout();
            this.grp_gestionFichier.ResumeLayout(false);
            this.grp_stagiaires.ResumeLayout(false);
            this.grp_stages.ResumeLayout(false);
            this.grp_gestion.ResumeLayout(false);
            this.grp_affichage.ResumeLayout(false);
            this.grp_affichage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionnaireErreurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_rechercher;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.GroupBox grp_gestionFichier;
        private System.Windows.Forms.Button btn_sauvegarder;
        private System.Windows.Forms.Button btn_charger;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.GroupBox grp_stagiaires;
        private System.Windows.Forms.ListBox lst_stagiaires;
        private System.Windows.Forms.GroupBox grp_stages;
        private System.Windows.Forms.ListBox lst_stages;
        private System.Windows.Forms.GroupBox grp_gestion;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifierStagiaire;
        private System.Windows.Forms.Button btn_stagiaire;
        private System.Windows.Forms.Button btn_stage;
        private System.Windows.Forms.GroupBox grp_affichage;
        private System.Windows.Forms.TextBox txt_affichage;
        private System.Windows.Forms.ErrorProvider gestionnaireErreurs;
        private System.Windows.Forms.OpenFileDialog dlg_sauvergarder;
        private System.Windows.Forms.OpenFileDialog dlg_charger;
        private System.Windows.Forms.Button btn_modifierStage;
    }
}

