using VendingMachine;

namespace World
{
    public class Customer
    {
        private int wallet;

        public Customer(int coins = 150) {
            wallet = coins;
        }

        public int getMoneyInWallet() {
            return wallet;
        }

        public void interact(CustomVendingMachine cvm) {
            cvm.client = this;
            cvm.displayMenu();
        }
    }
}
