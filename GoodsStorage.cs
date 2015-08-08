using System.Collections.Generic;
using System.Linq;

namespace VendingMachineEmulator
{
    public class GoodsStorage : StorageBox<Good>
    {

        // Return amount of goods with given name
        public int this[string name]
        {
            get
            {
                return items.First(l => string.Equals(name, l.Key.Name)).Value;  
            }
        }

        public Dictionary<Good, int>.KeyCollection Goods
        {
            get { return items.Keys; }
        }

        public void AddGood(Good good, int Amount = 1)
        {
            if (!Contains(good))
                items.Add(good, 0);
            items[good] += Amount;
        }

        public bool RemoveGood(Good good)
        {
            if (Contains(good))
            {
                if(items[good] > 0)
                {
                    items[good] -= 1;
                    return true;
                }
            }
            return false;
        }

        public void Remove(Good good)
        {
            items.Remove(good);
        }

    }
}
