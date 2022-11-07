using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    internal class Livre : Document, IDescription, IImprime
    {
        string editeur;
        DateTime datePublication;
        int nbPages;
        string isbn;
        string cote;

        public string GetDescription()
        {
            return Description();
        }

        public override string Description()
        {
            return "Titre : " + base.GetTitre() + "\t Auteur : " + base.GetAuteur();
        }

        public int GetNbPages()
        {
            return nbPages;
        }
    }
}
