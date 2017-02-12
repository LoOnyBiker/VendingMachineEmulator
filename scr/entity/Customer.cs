using System;
using VendingMachine;
using VendingMachine.Parts;

namespace World
{
    public class Customer
    {
        private int wallet;

        public Customer(int coins = 150) {
            wallet = coins;
        }

        public void interact(CustomVendingMachine cvm) {
            cvm.client = this;
            cvm.displayMenu();
        }
    }
}
