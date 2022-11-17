using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    public class Periodique : Document, IDescription, IImprime
    {
        int numero;
        int nbPages;
        int annee;
        string description;

        public string GetDescription()
        {
            return description;
        }
        public override string Description()
        {
            return GetDescription();
        }

        public int GetNbPages()
        {
            return nbPages;
        }

        public int GetAnnee()
        {
            return annee;
        }

        public int GetNumero()
        {
            return numero;
        }

        public Periodique(int numero_p, int nbPages_p, int annee_p, string description_p, string auteur_p, string titre_p):base(titre_p,auteur_p)
        {
            numero = numero_p;
            nbPages = nbPages_p;
            annee = annee_p;
            description = description_p;
        }
    }
}
