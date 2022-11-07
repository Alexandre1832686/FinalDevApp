using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDevApp
{
    internal class Audio : Document, IDescription
    {
        public string GetDescription()
        {
            return "";
        }
        int nbMinutes;
        string format;
    }
}
