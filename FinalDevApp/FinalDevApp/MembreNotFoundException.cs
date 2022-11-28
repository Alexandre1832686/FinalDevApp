using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    public class MembreNotFoundException : Exception
    {
        public MembreNotFoundException(string nom, string list) :base("Could not found " + nom + " in " +list)
        {

        }

        public MembreNotFoundException()
        {

        }
    }
}
