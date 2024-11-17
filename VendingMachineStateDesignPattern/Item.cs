using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineStateDesignPattern
{
    public class Item
    {
        private ItemType type;
        private int price;

        public ItemType getType() { return type; }
        public void setType(ItemType type) { this.type = type; }
        public int getPrice() { return price; }
        public void setPrice(int price) { this.price = price; }
    }
}
