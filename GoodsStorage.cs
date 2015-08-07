using System.Linq;

namespace VendingMachineEmulator
{
    public class GoodsStorage : StorageBox<Good>
    {

        public int this[string name]
        {
            get
            {
                return items.First(l => string.Equals(name, l.Key.Name)).Value;
            }
        }

        public void AddGood(Good good, int Amount)
        {
            if (!items.ContainsKey(good))
            {
                items.Add(good, Amount);
            }
            else
            {
                items[good] += Amount;
            }
        }

        public void RemoveGood(Good good)
        {
            if (items.ContainsKey(good))
            {
                if(items[good] > 0)
                {
                    items[good] -= 1;
                }
                else
                {
                    System.Console.WriteLine("Товар отсутствует :С");
                }
            }
        }

    }
}
