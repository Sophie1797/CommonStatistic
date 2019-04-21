using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ItemComparer : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            if (x.Id == y.Id)
                return 0;
            return x.Id > y.Id ? -1 : 1;
        }
    }
}
