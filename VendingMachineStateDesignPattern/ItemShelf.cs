using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VendingMachineStateDesignPattern
{
    public class ItemShelf
    {
        private int code;
        private Item item;
        private bool soldOut;

        public int getCode() { return code; }
        public void setCode(int code) { this.code = code; }
        public Item getItem() { return item; }
        public void setItem(Item item) {    this.item = item; }
        public bool isSoldOut() { return soldOut; }
        public void setSoldOut(bool soldOut) { this.soldOut = soldOut; }

    }
}
