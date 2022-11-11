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
        string description;

        public string GetDescription()
        {
            return Description();
        }

        public override string Description()
        {
            return description;
        }

        public int GetNbPages()
        {
            return nbPages;
        }

        public DateTime GetDatePublication()
        {
            return datePublication;
        }

        public string GetEditeur()
        {
            return editeur;
        }

        public string GetISBN()
        {
            return isbn;
        }

        public string GetCote()
        {
            return cote;
        }

        public Livre(string editeur_p, DateTime datePublication_p, int nbPages_p, string isbn_p, string cote_p, string titre_p, string auteur_p) :base(titre_p, auteur_p)
        {
            this.editeur = editeur_p;
            this.datePublication = datePublication_p;
            this.nbPages = nbPages_p;
            this.isbn = isbn_p;
            this.cote = cote_p;
        }
    }
}
