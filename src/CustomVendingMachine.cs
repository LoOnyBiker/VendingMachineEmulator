using VendingMachine.Parts;

namespace VendingMachine
{
    public class CustomVendingMachine
    {
        protected GoodsStorage goodStorage;

        #region Properties
        // Name of machine, e.g. "Cookie vending machine"
        public string Name {
            get; protected set;
        }

        // Link to Customer object that iteract with machine
        // Could be a queue of Customer objects or smth like that
        public World.Customer client {
            get; set;
        }
        #endregion

        public CustomVendingMachine(string name = "unknown VM") {
            Name = name;
            goodStorage = new GoodsStorage();
        }

        /*public virtual void Insert(Coin coin)
        {
            changer.Process(coin);
            if (ExactChange)
                DeliverGood(Selection);
        }*/

        public virtual void LoadGoods(Good good, int amount)
        {
            goodStorage.add(good, amount);
        }

        public bool Contain(Good g) {
            return goodStorage.Contains(g);
        }


        #region Protected methods
        public virtual void displayMenu() {
            foreach (Good item in goodStorage.Goods) {
                // display.show(item.Name + "\t" + prices[item]);
            }
        }
        #endregion
    }
}
