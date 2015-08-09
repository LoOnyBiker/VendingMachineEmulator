using System;

namespace VendingMachineEmulator
{
    public class Customer
    {
        private CoinStorage wallet;

        public Customer()
        {
            wallet = new CoinStorage();
        }

        public void Get(Coin coin, int Amount = 1)
        {
            wallet.Add(coin, Amount);
        }

        public Coin Find()
        {
            int c = int.Parse(
                Console.ReadLine()
                );
            return new Coin(c);
        }

        public void Spend(Coin c, int amount = 1)
        {
            wallet.Remove(c);
        }

        public void LookAt(VendingMachine vm)
        {
            vm.Purchase(this);
        }

        public void CheckoutWallet()
        {
            Console.WriteLine(
                "Вы остатриваете кошелек и обнаруживаете там {0} руб", wallet.Total);
            wallet.ToString();
        }

        public bool isAvaliable(Coin c)
        {
            return wallet.Contains(c);
        }

    }
}
