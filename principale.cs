using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStages
{
    public partial class principale : Form
    {
        private ListBox m_stageVide { get; set; }
        private ListBox m_stagiairesOriginal { get; set; }
        private bool m_enRecherche { get; set; }


    public principale()
        {
            InitializeComponent();
            m_stageVide = lst_stages;

            lst_stagiaires.Items.Add( new classeStagiaire(1, "patate",
                                  "123-123-1234", "patate@patate.com", new ListBox() ));
            m_enRecherche = false;
            m_stagiairesOriginal = new ListBox();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {

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
            this.lbl_recherche.Text = "";
        }

        private void lst_stagiaires_SelectedIndexChanged(object sender, EventArgs e){

            classeStagiaire stagiaireSelectionne = (classeStagiaire)this.lst_stagiaires.SelectedItem;

            if (stagiaireSelectionne != null) {
                lst_stages = stagiaireSelectionne.m_stages;
            }
            else{
                lst_stages = m_stageVide;
            }


        }

        private void btn_stage_Click(object sender, EventArgs e) {

            stage nouvelleFenetre = new stage( null );

            if (nouvelleFenetre.ShowDialog() == DialogResult.OK) {

                lst_stages.Items.Add( nouvelleFenetre.m_stage );
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
    }
}
