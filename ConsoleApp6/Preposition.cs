using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Preposition
    {
        
            private static List<string> prepos = new List<string>(new string[]
              { "on ", "in ", "up ", "down ", "out ", "by ", "under ", "beside ", "above ", "over "});

            public Preposition()
            {

            }

            public static List<string> Prepos
            {
                get { return prepos; }
            }
        
    }
}
