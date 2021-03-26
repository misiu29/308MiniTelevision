using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tv
{
    public class ListboxItem
    {
        public string ItemText;
        public string ItemValue;

        public ListboxItem(string strText, string strValue)
        {
            ItemText = strText;
            ItemValue = strValue;
        }

        public override string ToString()
        {
            return this.ItemText;
        }
    }
}
