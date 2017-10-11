using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Noun
    {
        private static List<string> nouns = new List<string>(new string[]
        { "House ", "Street ", "River ", "Trees ", "Birds ", "sky ", "sun ", "moon ", "breeze ", "bushes "});

        public Noun()
        {
            
        }

        public static List<string> Nouns
        {
            get { return nouns; }
        }
    }
}
