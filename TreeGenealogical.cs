using System.Collections.Generic;

namespace paradigma
{
    public class TreeGenealogical
    {
        public TreeGenealogical()
        {
            Childs = new List<TreeGenealogical>();
        }

        public string Parent { get; set; }
        public List<TreeGenealogical> Childs { get; set; }

    }
}