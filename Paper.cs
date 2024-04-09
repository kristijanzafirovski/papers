using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokvezba
{
    public class Paper
    {
        private string name;
        public string[] authors;
        private string[] keywords;

        public Paper(string name, string[] authors, string[] keywords)
        {
            this.name = name;
            this.authors = authors;
            this.keywords = keywords;
        }
        private string NameCut(string name)
        {
            string[] names = name.Split(' ');
            return names[0] + ", " + names[1].Substring(0,1) + ".";


        }

        public override string ToString()
        {
            if (authors.Length == 1)
            {
                return NameCut(authors[0]) + " - " + name;
            }
            else if (authors.Length == 2)
            {
                return NameCut(authors[0]) + ", " + NameCut(authors[1]) + " - " + name;
            }
            else
                return NameCut(authors[0]) + ", et al - " + name;
          
        }
    }

}
