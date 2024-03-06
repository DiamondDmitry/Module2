using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Extensions
{
    public static class ListRemoveDuplicatesExtension
    {
        public static List<string> RemoveDuplicates(this List<string> fruitsList)
        {
            List<string> clearList = new List<string>();
            foreach (string fruit in fruitsList)
            {
                if (!clearList.Contains(fruit))
                {
                    clearList.Add(fruit);
                }
            }
            return clearList;
        }
    }
}
