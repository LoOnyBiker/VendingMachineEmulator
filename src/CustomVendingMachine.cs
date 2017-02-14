using System;
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

        public virtual void load(Good good, int amount) {
            goodStorage.add(good, amount);
        }

        public bool contain(Good g) {
            return goodStorage.Contains(g);
        }


        #region Protected methods
        public virtual void displayMenu() {
            int index = 0;
            Console.WriteLine("Welcome to Vending Machine Emulation program \n");
            Console.WriteLine("Here's menu. Choose whatever you want, but keep eye on your wallet!");
            Console.WriteLine("Now there's {0} rubles in your wallet.\n", this.client.getMoneyInWallet());
            Console.WriteLine("Number\tName\n- - - - - - - - -");

            foreach (Good item in goodStorage.Goods) {
                Console.WriteLine("{0}\t{1}", index, item.Name);
                index++;
            }
            Console.Write("\nChoose [type number] item: ");
            string itemName = Console.ReadLine();
            Console.WriteLine(itemName);

            int num;
            if (!int.TryParse(itemName, out num))
            {
                displayMenu();
            }
        }

        protected virtual void emptyMenu() { }
        protected virtual void actualMenu() { }
        #endregion
    }
}
