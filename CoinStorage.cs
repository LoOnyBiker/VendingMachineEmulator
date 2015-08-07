using System;

namespace VendingMachineEmulator
{
    public class CoinStorage : StorageBox<Coin>
    {

        public override int this[Coin coin]
        {
            get
            {
                return items[coin];
            }
            set
            {
                if (!items.ContainsKey(coin))
                    Console.WriteLine("Данный элемент отсутствует!");
                else
                    items[coin] = value;
            }
        }

        public void Add(Coin coin, int Amount)
        {
            if (!items.ContainsKey(coin))
                items.Add(coin, 0);
            items[coin] += Amount;
        }

        public void Remove(Coin coin, int Amount)
        {
            if (items[coin] <= 0)
                return;
            items[coin] -= Amount;
        }

        public int Total
        {
            get
            {
                int total = 0;
                if(items != null)
                {
                    foreach (var coin in items)
                    {
                        total += coin.Key.Nominal * coin.Value;
                    }
                }
                return total;
            }
        }

    }
}
