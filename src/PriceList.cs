using System.Collections.Generic;

namespace VendingMachine.Parts
{
    public sealed class PriceList : StorageBox<Good>
    {

        private Dictionary<Good, int> prices;

        public void Add(Good good, int price)
        {
            if (!Contains(good))
                items.Add(good, 0);
            items[good] = price;
        }

        public bool Remove(Good good)
        {
            if (Contains(good))
            {
                if (items[good] > 0)
                {
                    items.Remove(good);
                    return true;
                }
            }
            return false;
        }

    }
}
