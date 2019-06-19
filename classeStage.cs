using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStages
{
    public class classeStage
    {
        public string m_nomStage { get; set; }
        public string m_dateDebut { get; set; }
        public string m_dateFin { get; set; }
        public string m_nomSuperviseur { get; set; }
        public string m_Commentaire { get; set; }

        public classeStage( string p_nomStage, string p_dateDebut,
            string p_dateFin, string p_nomSuperviseur, string p_commentaire ) {

            m_nomStage = p_nomStage;
            m_dateDebut = p_dateDebut;
            m_dateFin = p_dateFin;
            m_nomSuperviseur = p_nomSuperviseur;
            m_Commentaire = p_commentaire;
        }
        public override string ToString()
        {
            return m_nomStage;
        }


    }
}
