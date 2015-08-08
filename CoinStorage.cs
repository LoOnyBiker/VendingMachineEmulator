namespace VendingMachineEmulator
{
    public class CoinStorage : StorageBox<Coin>
    {

        // Return amount of coins with given rating
        public override int this[Coin coin]
        {
            get
            {
                return items[coin];
            }
            set
            {
                items[coin] = value;
            }
        }

        public int Total
        {
            get
            {
                int total = 0;
                if (items != null)
                {
                    foreach (var coin in items)
                    {
                        total += coin.Key.Rating * coin.Value;
                    }
                }
                return total;
            }
        }

        public void Add(Coin coin, int Amount = 1)
        {
            if (!Contains(coin))
                items.Add(coin, 0);
            items[coin] += Amount;
        }

        public void Remove(Coin coin, int Amount = 1)
        {
            if (items[coin] <= 0)
                return;
            items[coin] -= Amount;
        }
    }
}
