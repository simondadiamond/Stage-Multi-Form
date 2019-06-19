using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStages
{
    public partial class stage : Form
    {
        public classeStage m_stage {
            get;
            private set;
        }
        private Regex m_regexDate { get; set; }
        //private List<classeStage> m_listeStages { get; set; }
        public stage( classeStage p_stage )
        {
            InitializeComponent();
            btn_annuler.CausesValidation = false;
            this.m_regexDate = new Regex("^\\d{4}-\\d{2}-\\d{2}$");

            //m_listeStages = p_listStages;

            if (p_stage == null) {
                this.Text = "Ajouter un stage";
            }
            else {
                this.Text = "Modifier un stage";

                this.txt_nom.Text = p_stage.m_nomStage;
                this.txt_debut.Text = p_stage.m_dateDebut;
                this.txt_fin.Text = p_stage.m_dateFin;
                this.txt_superviseur.Text = p_stage.m_dateFin;
                this.txt_commentaire.Text = p_stage.m_Commentaire;
            }
        }

        private void txt_nom_Validating(object sender, CancelEventArgs e){
            if (txt_nom.Text == "") {

                this.gestionnaireErreurs.SetError(this.txt_nom, "Le nom ne doit pas être vide");
                e.Cancel = true;
            }
            else {
                this.gestionnaireErreurs.SetError(this.txt_nom, "");
            }
        }

        private void txt_debut_Validating(object sender, CancelEventArgs e) {
            if (txt_debut.Text == "") { //chaine vide

                this.gestionnaireErreurs.SetError(this.txt_debut, "La date ne doit pas être vide");
                e.Cancel = true;
            }
            else { 
                if ( this.m_regexDate.IsMatch( txt_debut.Text ) ) {

                    DateTime dateDebut = DateTime.ParseExact(txt_debut.Text, "yyyy-MM-dd", null);
                    DateTime dateLimite = DateTime.ParseExact("1990-06-01", "yyyy-MM-dd", null);
                    DateTime aujourdhui = DateTime.Now;

                    if ( dateDebut < dateLimite ) { // date dans le passé
                        this.gestionnaireErreurs.SetError(this.txt_debut, "Le date doit être après le 1er juin 1990");
                        e.Cancel = true;
                    }
                    else {
                        this.gestionnaireErreurs.SetError(this.txt_debut, "");
                    }
                }
                else { // format
                    this.gestionnaireErreurs.SetError(this.txt_debut, "Le format n'est pas valide");
                }
            }
        }
        private void txt_fin_Validating(object sender, CancelEventArgs e) {

            if (txt_fin.Text == "") { //chaine vide

                this.gestionnaireErreurs.SetError(this.txt_fin, "La date ne doit pas être vide");
                e.Cancel = true;
            }
            else  {

                if ( this.m_regexDate.IsMatch(txt_fin.Text) ){

                    DateTime dateDebut = DateTime.ParseExact(txt_debut.Text, "yyyy-MM-dd", null);
                    DateTime dateFin = DateTime.ParseExact(txt_fin.Text, "yyyy-MM-dd", null);
                    DateTime dateLimite = DateTime.ParseExact("1990-06-01", "yyyy-MM-dd", null);

                    if (dateFin < dateDebut) { // date de fin avant le début
                        this.gestionnaireErreurs.SetError(this.txt_fin, "Le date de fin doit être après celle de début");
                        e.Cancel = true;
                    }
                    else {
                        TimeSpan duree = dateFin - dateDebut;

                        if (duree.Days > 365) { // stage plus d'un an
                            this.gestionnaireErreurs.SetError(this.txt_fin, "La durée d'un stage ne peut pas être plus d'un an");
                            e.Cancel = true;
                        }
                        else { // aucune erreur
                            this.gestionnaireErreurs.SetError(this.txt_fin, "");
                        }
                    }
                }
                else { // format
                    this.gestionnaireErreurs.SetError(this.txt_fin, "Le format n'est pas valide");
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e) {

            if ( this.ValidateChildren() ) {

                classeStage nouveau = new classeStage( txt_nom.Text, txt_debut.Text,
                                                     txt_fin.Text, txt_superviseur.Text,
                                                     txt_commentaire.Text );

                this.m_stage = nouveau;
                this.DialogResult = DialogResult.OK;

                this.Close(); // fermer fenetre
            }
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {

        }
    }
}
