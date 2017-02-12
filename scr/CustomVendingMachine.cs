using VendingMachine.Parts;

namespace VendingMachine
{
    public class CustomVendingMachine
    {
        protected GoodsStorage goodStorage;

        #region Properties
        public string Name
        {
            get; protected set;
        }
        #endregion

        public CustomVendingMachine(string name = "unknown VM")
        {
            Name = name;
        }

        /*public virtual void Insert(Coin coin)
        {
            changer.Process(coin);
            if (ExactChange)
                DeliverGood(Selection);
        }

        public virtual void LoadGoods(Good good,int price, int amount)
        {
            goodStorage.AddGood(good, amount);
            changer.Prices.AddGood(good, price);
        }*/

        public bool Contain(Good g)
        {
            return goodStorage.Contains(g);
        }

        /*
        #region Protected methods
        protected virtual void DisplayMenu()
        {
            foreach (Good item in goodStorage.Goods)
            {
                display.Show(item.Name + "\t" + changer.Prices[item]);
            }
        }
        #endregion    
        */    
    }
}
