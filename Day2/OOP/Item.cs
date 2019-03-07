using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.OOP
{
    class Item
    {
       public string ItemName;

        int itemid;

        //Overloaded constructors: Same name with diff i/p parameters

         Item()  //parameterless contr
        {
            Console.WriteLine("Parameterless contr is called");
        }
        public Item(string ItemName,int itemid)
        {
           this.ItemName = ItemName;
            this.itemid = itemid;
        }

        public int getItemID()
        {
            return itemid;
        }

    }

    class OOPDemo
    {
        static void Main(string[] args)
        {
            Item item = new Item("Mouse", 100);
            //Item item1 = new Item();
            
        }
    }
}
