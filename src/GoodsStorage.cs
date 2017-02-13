using System.Collections.Generic;
using System.Linq;

namespace VendingMachine.Parts
{
    public class GoodsStorage : StorageBox<Good>
    {

        // Return amount of goods with given name
        public int this[string name]
        {
            get {
                return items.First(l => string.Equals(name, l.Key.Name)).Value;
            }
        }

        public Dictionary<Good, int>.KeyCollection Goods {
            get { return items.Keys; }
        }

        public void add(Good good, int Amount = 1) {
            if (!Contains(good))
                items.Add(good, 0);
            items[good] += Amount;
        }

        /**
         * Try to remove one good from storage.
         * Return false if there's no given good
         * @param  {[type]} Good good          [description]
         * @return {[type]}      [description]
         */
        public bool remove(Good good) {
            if (Contains(good)) {
                if(items[good] > 0) {
                    items[good] -= 1;
                    return true;
                }
            }
            return false;
        }

        // Complitely remove good from storage
        public void unload(Good good) {
            items.Remove(good);
        }

    }
}
