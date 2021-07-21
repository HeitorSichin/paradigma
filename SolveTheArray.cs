using System.Collections.Generic;
using System.Linq;

namespace paradigma
{
    public class SolveTheArray
    {
        private readonly string[,] _array;

        public SolveTheArray(string[,] array)
        {
            _array = array;
        }
        public TreeGenealogical Resolve()
        {
            TreeGenealogical treeGenealogical = new TreeGenealogical();

            var listParent = new List<string>();

            for (int p = 0; p < _array.GetLength(0); p++)
            {
                listParent.Add(_array[p, 0]);
            }

            List<string> listChidrens = new List<string>();

            foreach (var item in listParent.Distinct().ToList())
            {
                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    if (item == _array[i, 0])
                    {
                        listChidrens.Add(_array[i, 1]);
                    }
                }

                FeedTree(treeGenealogical, item, listChidrens);
                listChidrens = new List<string>();
            }

            return treeGenealogical;
        }

        private void FeedTree(TreeGenealogical t1, string parent, List<string> childrens)
        {
            if (string.IsNullOrEmpty(t1.Parent))
            {
                t1.Parent = parent;

                foreach (var item in childrens)
                {
                    t1.Childs.Add(new TreeGenealogical { Parent = item });
                }

                return;
            }

            foreach (var item in t1.Childs)
            {
                if (item.Parent == parent)
                {
                    foreach (var child in childrens)
                    {
                        item.Childs.Add(new TreeGenealogical { Parent = child });
                    }
                }

                FeedTree(item, parent, childrens);
            }
        }

    }
}