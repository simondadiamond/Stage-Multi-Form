using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStages
{
    public class classeStagiaire
    {
        public int m_id { get; set; }
        public string m_nom { get; set; }
        public string m_telephone { get; set; }
        public string m_courriel { get; set; }
        public ListBox m_stages { get; set; }
        public classeStagiaire( int p_id, string p_nom,
            string p_telephone, string p_courriel, ListBox p_stages )
        {
            m_id = p_id;
            m_nom = p_nom;
            m_telephone = p_telephone;
            m_courriel = p_courriel;
            m_stages = p_stages;
        }
        public override string ToString()
        {
            return  m_id.ToString() + " " + m_nom;
        }




    }
}
