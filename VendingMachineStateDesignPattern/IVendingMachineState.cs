using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineStateDesignPattern
{
    public interface IVendingMachineState
    {
        public void InsertCoin();
        public void SelectProduct();
        public void RefundOrCancel();
        public void ChooseProduct();
        public void ReturnTheChange();
        public void DispenseItem();

    }
}
