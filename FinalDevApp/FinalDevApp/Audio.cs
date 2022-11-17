using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    public class Audio : Document, IDescription
    {
        string description;
        int nbMinutes;
        string format;

        public Audio(string description_p, int nbMinutes_p, string format_p, string titre_p, string auteur_p) :base(titre_p, auteur_p)
        {
            description = description_p;
            nbMinutes = nbMinutes_p;
            format = format_p;
        }

        public override string Description()
        {
            return description;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetFormat()
        {
            return format;
        }

        public int GetnbMinutes()
        {
            return nbMinutes;
        }
    }
}
