using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineStateDesignPattern
{
    public class Inventory
    {
        ItemShelf[] shelf = null;
        public Inventory(int count)
        {
            shelf = new ItemShelf[count];
            initialEmptyInventory();
        }

        public ItemShelf[] getShelf() { return shelf; }
        public void setShelf(ItemShelf[] shelf) { this.shelf = shelf; }
        public void initialEmptyInventory()
        {
            int startCode = 101;
            for (int i = 0; i < shelf.Length; i++)
            {
                ItemShelf space = new ItemShelf();
                space.setCode(startCode);
                space.setSoldOut(true);
                shelf[i] = space;
                startCode++;
            }
        }

        public void addItem(Item item, int codeNumber)
        {
            foreach(ItemShelf itemShelf in shelf)
            {
                if (itemShelf.getCode() == codeNumber)
                {
                    if (itemShelf.isSoldOut())
                    {
                        itemShelf.setItem(item);
                        itemShelf.setSoldOut(false);
                    }
                    else
                    {
                        throw new Exception("Already Item Present, You cannot add item here");
                    }
                }
            }
        }
    }
}
