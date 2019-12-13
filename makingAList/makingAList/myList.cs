using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makingAList
{
    public class myList
    {
        public ListItem firstItem;

        public void AddItem(string rawData)
        {
            if (firstItem == null)
            {
                firstItem = new ListItem(rawData);
            }
            else
            {
                //find end of list and add new item
                ListItem currentItem = firstItem;

                do
                {
                    if (currentItem.nextItem != null)
                    {
                        currentItem = currentItem.nextItem;
                    }
                    else
                    {
                        currentItem.nextItem = new ListItem(rawData);
                    }
                } while (currentItem != null);
            }
        }
    }

    public class ListItem
    {
        public string textData;
        public ListItem nextItem;
        public ListItem()
        { }
        public ListItem(string _textData)
        {
            this.textData = _textData;
        }
    }
}
