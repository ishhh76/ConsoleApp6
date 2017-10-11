using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class WordList
    {
        List<Noun> nounList = new List<Noun>();


        public WordList ()
        {
            nounList.Add(new Noun(" House, Street, River, Trees, Birds, sky, sun, moon, breeze, bushes"));
            //StringBuilder result = nounList.Aggregate(new StringBuilder(), (a, b) => a.Append(b));
           // List<string> strings = nounList.Select(s => (string)s).ToList();
           
        }
        public void SelectWords()

        {
            foreach (Noun element in nounList)
            {
                Console.ReadLine();
                Console.WriteLine(element);
            }







        }
        static void Main(string[] args)
        {
            Console.ReadLine();

        }
    }
}
