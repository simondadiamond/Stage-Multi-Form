// Equipe : Simon Paris, Jean-philippe Proteau-Coulombe

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
    public partial class stagiaire : Form
    {

        private Regex m_regex_telephone = new Regex("^\\d{3}-\\d{3}-\\d{4}$");
        private Regex m_regex_numero = new Regex("^\\d+");
        public classeStagiaire m_stagiaire { get; private set; }

        public ListBox m_stagiaires { get; set; }

        public stagiaire( classeStagiaire p_stagiaire, ListBox p_stagiaires)
        {
            InitializeComponent();
            btn_annuler.CausesValidation = false;

            m_stagiaires = p_stagiaires;

            if (p_stagiaire == null) {
                this.Text = "Ajouter un stagiaire";
            }
            else {
                this.Text = "Modifier un stagiaire";
                m_stagiaire = p_stagiaire;

                txt_id.Text = p_stagiaire.m_id.ToString();
                txt_nom.Text = p_stagiaire.m_nom;
                txt_telephone.Text = p_stagiaire.m_telephone;
                txt_courriel.Text = p_stagiaire.m_courriel;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (this.Text == "Ajouter un stagiaire") {
                    m_stagiaire = new classeStagiaire(Convert.ToInt32(txt_id.Text), txt_nom.Text,
                                  txt_telephone.Text, txt_courriel.Text, new ListBox() );
                }
                else if (this.Text == "Modifier un stagiaire") {
                    m_stagiaire.m_id = Convert.ToInt32(txt_id.Text);
                    m_stagiaire.m_nom = txt_nom.Text;
                    m_stagiaire.m_telephone = txt_telephone.Text;
                    m_stagiaire.m_courriel = txt_courriel.Text;
                }
                this.DialogResult = DialogResult.OK;

                this.Close(); // fermer fenetre
            }
        }
        private void txt_id_Validating(object sender, CancelEventArgs e)
        {
            if (txt_id.Text == "") // si la case est vide
            {
                e.Cancel = true;
                this.gestionnaireErreurs.SetError(this.txt_id, "Vous devez rajouter un Identifiant");
            }
            else if (!m_regex_numero.IsMatch(txt_id.Text)) // si la case contient autre chose que un nombre
            {
                e.Cancel = true;
                this.gestionnaireErreurs.SetError(this.txt_id, "Votre ID doit être un nombre");
            }
            else if ( m_regex_numero.IsMatch(txt_id.Text) ) { // si la case contient un nombre

                classeStagiaire stagiaireId = trouverStagiaireParId(txt_id.Text);

                // si le numero est deja utilisé et que l'on ne le modifie pas
                if ( stagiaireId != null && stagiaireId != m_stagiaire) {
                    e.Cancel = true;
                    this.gestionnaireErreurs.SetError(this.txt_id, "Votre ID est déja utilisé");
                }
                else { // nombre non utilise
                    this.gestionnaireErreurs.SetError(this.txt_id, "");
                }
            }
        }

        private bool estIdUtilise(string p_id)
        {
            bool estUtilise = false;
            foreach ( classeStagiaire stagiaire in m_stagiaires.Items )
            {
                if (Convert.ToInt32(p_id) == stagiaire.m_id)
                {
                    estUtilise = true;
                }
            }
            return estUtilise;
        }
        private classeStagiaire trouverStagiaireParId(string p_id)
        {
            classeStagiaire resultat = null;

            foreach (classeStagiaire stagiaire in m_stagiaires.Items)
            {
                if ( Convert.ToInt32(p_id) == stagiaire.m_id )
                {
                    resultat = stagiaire;
                }
            }
            return resultat;
        }


        private void txt_nom_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nom.Text == "")
            {
                e.Cancel = true;
                this.gestionnaireErreurs.SetError(this.txt_nom, "Vous devez rajouter un nom");
            }
            else
            {
                this.gestionnaireErreurs.SetError(this.txt_nom, "");
            }
        }

        private void txt_courriel_Validating(object sender, CancelEventArgs e)
        {
            if (txt_courriel.Text == "")
            {
                e.Cancel = true;
                this.gestionnaireErreurs.SetError(this.txt_courriel, "Vous devez rajouter un couriel");
            }
            else
            {
                this.gestionnaireErreurs.SetError(this.txt_courriel, "");
            }
        }

        private void txt_telephone_Validating(object sender, CancelEventArgs e)
        {
            if (txt_telephone.Text == "") // si la case est vide
            {
                e.Cancel = true;
                this.gestionnaireErreurs.SetError(this.txt_telephone, "Veuillez ajouter un numéro de téléphone");
            }
            else if (!m_regex_telephone.IsMatch(txt_telephone.Text)) // si la case contient autre chose que un nombre
            {
                e.Cancel = true;
                this.gestionnaireErreurs.SetError(this.txt_telephone, "Format invalide. SVP entrez un numéro dans le format XXX-XXX-XXXX");
            }
            else if (m_regex_telephone.IsMatch(txt_telephone.Text)) // le numéro est du bon format
            {
                this.gestionnaireErreurs.SetError(this.txt_telephone, "");
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            
            this.Close(); // fermer fenetre
        }
    }
}