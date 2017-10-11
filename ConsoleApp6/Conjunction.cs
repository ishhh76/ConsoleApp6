using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Conjunction
    {
        private static List<string> conjnt = new List<string>(new string[]
          { "and ", "between ", "with ", "together ", "but ", "so ", "or ", "for ", "after ", "because "});

        public Conjunction()
        {

        }

        public static List<string> Conjnts
        {
            get { return conjnt; }
        }
    }
}

