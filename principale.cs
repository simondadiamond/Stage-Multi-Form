// bouton recherche 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GestionStages
{
    public partial class principale : Form
    {
        private ListBox m_stageVide { get; set; }
        private ListBox m_stagiairesOriginal { get; set; }
        private bool m_enRecherche { get; set; }

        private static string XML_ELM_RACINE = "listeStagiaire";
        private static string XML_ELM_STAGIAIRE = "stagiaire";
        private static string XML_ELM_STAGE = "stage";

        private static string XML_ATTR_ID = "id";
        private static string XML_ATTR_NOM = "nom";
        private static string XML_ATTR_NOMSTAGE = "nomStage";
        private static string XML_ATTR_TELEPHONE = "telephone";
        private static string XML_ATTR_COURRIEL = "courriel";
        private static string XML_ATTR_DATEDEBUT = "dateDebut";
        private static string XML_ATTR_DATEFIN = "dateFin";
        private static string XML_ATTR_NOMSUPERVISEUR = "nomSuperviseur";
        private static string XML_ATTR_COMMENTAIRE = "commentaire";

        public principale()
        {
            InitializeComponent();
            m_stageVide = lst_stages;

            //lst_stagiaires.Items.Add( new classeStagiaire(1, "Pierre",
            //                      "418-123-1234", "patate@patate.com", new ListBox() ));
            //lst_stagiaires.Items.Add( new classeStagiaire(2, "Jean",
            //                      "418-123-1234", "patate@patate.com", new ListBox() ));
            //lst_stagiaires.Items.Add( new classeStagiaire(3, "Jacques",
            //                      "581-123-1234", "banane@banane.com", new ListBox() ));

            DialogResult resultat = this.dlg_charger.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                try
                {
                    Charger(this.dlg_charger.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                          exception.Message, "Erreur",
                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
            m_enRecherche = false;
            m_stagiairesOriginal = new ListBox();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if ( lst_stages.Items.Count > 0 ) {
                classeStage stageSelectionne = (classeStage)this.lst_stages.SelectedItem;

                if (stageSelectionne != null)
                {
                    int index = lst_stages.SelectedIndex;
                    lst_stages.Items.RemoveAt(index);
                }
            }
            else {
                MessageBox.Show(
                              "La liste des stages est vide", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            classeStagiaire stagiaireSelectionne = (classeStagiaire)this.lst_stagiaires.SelectedItem;
            classeStage stageSelectionne = (classeStage)this.lst_stages.SelectedItem;

            if (stagiaireSelectionne != null)
            {
                stagiaire nouvelleFenetre = new stagiaire(stagiaireSelectionne, lst_stagiaires);
                if (nouvelleFenetre.ShowDialog() == DialogResult.OK)
                {
                    int index = lst_stagiaires.SelectedIndex;
                    lst_stagiaires.Items.RemoveAt(index);
                    lst_stagiaires.Items.Insert(index, nouvelleFenetre.m_stagiaire);
                }
            }
            else if (stageSelectionne != null)
            {
                stage nouvelleFenetre = new stage(stageSelectionne);
                if (nouvelleFenetre.ShowDialog() == DialogResult.OK)
                {
                    int index = lst_stages.SelectedIndex;
                    lst_stages.Items.RemoveAt(index);
                    lst_stages.Items.Insert(index, nouvelleFenetre.m_stage);
                }
            }
            else
            {
                MessageBox.Show("Veuillez SVP selectionner un stagiaire ou un stage a modifier.");
            }



        }

        private void btn_stagiaire_Click(object sender, EventArgs e){

            stagiaire nouvelleFenetre = new stagiaire( null, lst_stagiaires );

            if ( nouvelleFenetre.ShowDialog() == DialogResult.OK){
                lst_stagiaires.Items.Add( nouvelleFenetre.m_stagiaire );
            }


        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void principale_Load(object sender, EventArgs e)
        {
           
        }

        private void lst_stagiaires_SelectedIndexChanged(object sender, EventArgs e){
            
            classeStagiaire stagiaireSelectionne = (classeStagiaire)this.lst_stagiaires.SelectedItem;
            classeStage stageSelectionne = (classeStage)this.lst_stages.SelectedItem;


            if (stagiaireSelectionne != null) {
                                
                lst_stages.DataSource = creerListeStage(stagiaireSelectionne);

                StringBuilder sb = new StringBuilder();
                string infoStagiaire = "Numéro d'employé: {0} \r\nNom: {1} \r\nTéléphone: {2} \r\nCouriel: {3}\n";
                

                sb.AppendFormat(infoStagiaire,  stagiaireSelectionne.m_id.ToString(),
                                                stagiaireSelectionne.m_nom,
                                                stagiaireSelectionne.m_telephone,
                                                stagiaireSelectionne.m_courriel);
                lst_stages.ClearSelected();
                txt_affichage.Text = sb.ToString();
                
            }
            else{
                lst_stages = m_stageVide;
            }

        }

        // Ajouter stage
        private void btn_stage_Click(object sender, EventArgs e) {

            // si il y a au moins 1 stagiaire
            if ( lst_stagiaires.Items.Count > 0 ) {

                classeStagiaire stagiaireSelectionne = (classeStagiaire)this.lst_stagiaires.SelectedItem;

                if (stagiaireSelectionne != null)
                {
                    classeStage stageSelectionne = (classeStage)this.lst_stages.SelectedItem;
                    
                    stage nouvelleFenetre = new stage(stageSelectionne);

                    if (nouvelleFenetre.ShowDialog() == DialogResult.OK) {

                        stagiaireSelectionne.m_stages.Items.Add(nouvelleFenetre.m_stage);
                        // pour refresh la liste
                        lst_stages.DataSource = creerListeStage(stagiaireSelectionne);
                    }
                }
                else {
                    MessageBox.Show(
                               "Aucun stagiaire de sélectionné", "Erreur",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                MessageBox.Show(
                              "La liste de stagiaire est vide", "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            Btn_recherche_Click(sender, e);

            if (txt_recherche.Text == "" && m_enRecherche)
            {
                lst_stagiaires.Items.Clear();
                lst_stagiaires.Items.AddRange(m_stagiairesOriginal.Items);
                m_enRecherche = false;
            }
        }

        private void Btn_recherche_Click(object sender, EventArgs e)
        {
            if (!m_enRecherche)
            {
                if (m_stagiairesOriginal.Items != null)
                {
                    m_stagiairesOriginal.Items.Clear();
                }
                m_stagiairesOriginal.Items.AddRange(lst_stagiaires.Items);
                lst_stagiaires.Items.Clear();
                m_enRecherche = true;
            }

            lst_stagiaires.Items.Clear();
            bool textePresent = false;
            foreach (classeStagiaire stagiaire in m_stagiairesOriginal.Items)
            {
                textePresent = false;
                if (estInfoStagiaire(stagiaire))
                {
                    textePresent = true;
                }
                foreach (classeStage stage in stagiaire.m_stages.Items)
                {
                    if (!textePresent)
                    {
                        if (estInfoStage(stage))
                        {
                            textePresent = true;
                        }
                    }
                }
                if (textePresent && !dejaTrouve(stagiaire))
                {
                    lst_stagiaires.Items.Add(stagiaire);
                }
            }
        }

        private bool dejaTrouve(classeStagiaire p_stagiaire)
        {
            bool trouve = false;
            foreach (classeStagiaire stagiaire in lst_stagiaires.Items)
            {
                if (!trouve)
                {
                    if (p_stagiaire.m_id == stagiaire.m_id)
                    {
                        trouve = true;
                    }
                }
            }
            return trouve;
        }

        private bool estInfoStage(classeStage p_stage)
        {
            bool trouve = false;


            if (p_stage.m_nomStage.Contains(txt_recherche.Text) ||
                p_stage.m_Commentaire.Contains(txt_recherche.Text) ||
                p_stage.m_nomSuperviseur.Contains(txt_recherche.Text))
            {
                trouve = true;
            }
            return trouve;
        }

        private bool estInfoStagiaire(classeStagiaire p_stagiaire)
        {
            bool trouve = false;

            if (p_stagiaire.m_id.ToString().Contains(txt_recherche.Text) ||
                p_stagiaire.m_nom.ToString().Contains(txt_recherche.Text) ||
                p_stagiaire.m_courriel.ToString().Contains(txt_recherche.Text) ||
                p_stagiaire.m_telephone.ToString().Contains(txt_recherche.Text))
            {
                trouve = true;
            }
            return trouve;
        }

        private void btn_sauvegarder_Click(object sender, EventArgs e)
        {
            if ( this.lst_stagiaires.Items.Count > 0 ) { // si au moins 1 stagiaire
                DialogResult resultat = this.dlg_sauvergarder.ShowDialog();

                if ( resultat == DialogResult.OK ) {
                    try {
                        Sauvegarder(this.dlg_sauvergarder.FileName);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(
                              exception.Message, "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else {
                MessageBox.Show(
                    "Aucun stagiaire à sauvegarder", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void Sauvegarder( string p_nomFichier )
        {
            Debug.Assert( !string.IsNullOrEmpty(p_nomFichier) );
            Debug.Assert( lst_stagiaires.Items != null );

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            XmlWriter fichier = XmlWriter.Create( p_nomFichier, settings );

            fichier.WriteStartDocument();

            // <listeStagiaire>
            fichier.WriteStartElement(XML_ELM_RACINE);


            foreach ( classeStagiaire stagiaire in lst_stagiaires.Items )
            {
                // <stagiaire>
                SauvegarderStagiaire(fichier, stagiaire);
                // </stagiaire>
            }

            // </listeStagiaire>
            fichier.WriteEndElement();

            fichier.WriteEndDocument();
            fichier.Close();

            MessageBox.Show(
                "L'opération c'est terminé avec succès !", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SauvegarderStagiaire( XmlWriter p_document, classeStagiaire p_stagiaire )
        {
            Debug.Assert( p_document != null  );
            Debug.Assert( p_stagiaire != null );

            // <stagiaire>
            p_document.WriteStartElement( XML_ELM_STAGIAIRE );

            p_document.WriteAttributeString( XML_ATTR_ID, p_stagiaire.m_id.ToString() );
            p_document.WriteAttributeString( XML_ATTR_NOM, p_stagiaire.m_nom );
            p_document.WriteAttributeString( XML_ATTR_TELEPHONE, p_stagiaire.m_telephone );
            p_document.WriteAttributeString( XML_ATTR_COURRIEL, p_stagiaire.m_courriel );

            foreach ( classeStage stage in p_stagiaire.m_stages.Items ) {
                // <stage>
                SauvegarderStage(p_document, stage);
                // </stage>
            }

            // </stagiaire>
            p_document.WriteEndElement();
        }
        private void SauvegarderStage( XmlWriter p_document, classeStage p_stage )
        {
            Debug.Assert( p_document != null );
            Debug.Assert( p_stage != null    );

            // <stage>
            p_document.WriteStartElement(XML_ELM_STAGE);

            p_document.WriteAttributeString( XML_ATTR_NOMSTAGE, p_stage.m_nomStage );
            p_document.WriteAttributeString( XML_ATTR_DATEDEBUT, p_stage.m_dateDebut );
            p_document.WriteAttributeString( XML_ATTR_DATEFIN, p_stage.m_dateFin );
            p_document.WriteAttributeString( XML_ATTR_NOMSUPERVISEUR, p_stage.m_nomSuperviseur );
            p_document.WriteAttributeString( XML_ATTR_COMMENTAIRE, p_stage.m_Commentaire );

            // </stage>
            p_document.WriteEndElement();
        }

        private void btn_charger_Click(object sender, EventArgs e)
        {
            DialogResult resultat = this.dlg_charger.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                try {
                    Charger( this.dlg_charger.FileName );
                }
                catch (Exception exception) {
                    MessageBox.Show(
                          exception.Message, "Erreur",
                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


        }
        public void Charger( string p_nomFichier )
        {
            //pré-condition
            Debug.Assert( !string.IsNullOrEmpty(p_nomFichier) );

            // on vide la liste de stagiaire
            this.lst_stagiaires.Items.Clear();
            // on vide la liste de stage
            this.lst_stages.Items.Clear();

            XmlReader doc = XmlReader.Create( p_nomFichier );

            doc.MoveToContent();

            // <listeStagiaire> 
            doc.ReadStartElement(XML_ELM_RACINE);

            // Lire sans savoir si on a terminé
            while ( doc.IsStartElement(XML_ELM_STAGIAIRE) )
            {
                this.lst_stagiaires.Items.Add( chargerStagiaire(doc) );
            }

            // </listeStagiaire>
            doc.ReadEndElement();
            doc.Close();

            MessageBox.Show(
                "L'opération c'est terminé avec succès !", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public classeStagiaire chargerStagiaire( XmlReader p_doc )
        {
            // Aucun ReadStartElement()

            int id = Convert.ToInt32( p_doc.GetAttribute(XML_ATTR_ID) );
            string nom = p_doc.GetAttribute( XML_ATTR_NOM );
            string telephone = p_doc.GetAttribute( XML_ATTR_TELEPHONE );
            string courriel = p_doc.GetAttribute( XML_ATTR_COURRIEL );

            classeStagiaire nouveau = new classeStagiaire( id, nom, telephone,
                                                        courriel, new ListBox() );

            // Lire sans savoir si on a terminé
            while ( p_doc.IsStartElement(XML_ELM_STAGE) )
            {
                nouveau.m_stages.Items.Add( chargerStage(p_doc) );
            }
            
            // Pour passer par-dessus </stagiaire>
            p_doc.Skip();

            return nouveau;
        }
        public classeStage chargerStage( XmlReader p_doc )
        {
            // Aucun ReadStartElement()
            
            string nomStage = p_doc.GetAttribute( XML_ATTR_NOMSTAGE );
            string dateDebut = p_doc.GetAttribute( XML_ATTR_DATEDEBUT );
            string dateFin = p_doc.GetAttribute( XML_ATTR_DATEFIN );
            string nomSuperviseur = p_doc.GetAttribute( XML_ATTR_NOMSUPERVISEUR );
            string commentaire = p_doc.GetAttribute( XML_ATTR_COMMENTAIRE );

            classeStage nouveau = new classeStage( nomStage, dateDebut, dateFin, nomSuperviseur, commentaire );
            
            // Pour passer par-dessus </stage>
            p_doc.Skip();

            return nouveau;
        }
        public List<classeStage> creerListeStage(classeStagiaire p_stagiaire) {

            List<classeStage> nouvelleListe = new List<classeStage>();

            foreach (classeStage stage in p_stagiaire.m_stages.Items) {
                nouvelleListe.Add(stage);
            }

            return nouvelleListe;
        }

        private void lst_stages_SelectedIndexChanged(object sender, EventArgs e)
        {
            classeStage stageSelectionne = (classeStage)this.lst_stages.SelectedItem;
            StringBuilder sb = new StringBuilder();
            if (stageSelectionne != null)
            {
                string infoStage = "Titre:{0} \r\n    Date de début:{1} \r\n    Date de fin:{2} \r\n    Commentaires:{3}\r\n    Nom du superviseur:{4}";
                sb.AppendFormat(infoStage,
                                stageSelectionne.m_nomStage,
                                stageSelectionne.m_dateDebut,
                                stageSelectionne.m_dateFin,
                                stageSelectionne.m_Commentaire,
                                stageSelectionne.m_nomSuperviseur);
            }
            txt_affichage.Text = sb.ToString();
        }
    }
}
