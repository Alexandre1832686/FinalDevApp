using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    public class DocumentNotFoundException : Exception
    {
        public DocumentNotFoundException(string nom, string list) : base("Could not found " + nom + " in " + list)
        {

        }

        public DocumentNotFoundException()
        {

        }
    }
}
