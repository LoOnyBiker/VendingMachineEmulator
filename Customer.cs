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

        public void Spend(Coin coin)
        {
            wallet.Remove(coin);
        }

    }
}
