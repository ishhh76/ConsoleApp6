using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Verb
    {
        private static List<string> verbs = new List<string>(new string[]
           { "flow ", "blow ", "is ", "move ", "sing ", "brim ", "shine ", "light ", "are " , "swing "});

        public Verb()
        {

        }

        public static List<string>Verbs
        {
            get { return verbs; }
        }
    }
}
