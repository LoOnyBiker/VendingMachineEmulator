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

        /*public bool WaitMoney
        {
            get { return changer.waitMoney; }
        }

        public Good Selection
        {
            get { return changer.Selection; }
            set { changer.Selection = value; }
        }

        private bool ExactChange
        {
            get { return changer.waitMoney; }
        }

        public bool CancelOrder
        {
            get { return changer.CancelOrder; }
            set { changer.CancelOrder = value; }
        }*/
        #endregion

        public CustomVendingMachine()
        {
            //InitParts();
            Name = "unknown VM";
        }

        public CustomVendingMachine(string name)
        {
            // InitParts();
            Name = name;
        }

        /*public virtual void Insert(Coin coin)
        {
            changer.Process(coin);
            if (ExactChange)
                DeliverGood(Selection);
        }

        public virtual void Cancel()
        {
            CancelOrder = true;
            
        }

        public virtual void WaitForChoise()
        {
            DisplayMenu();
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
        protected virtual void InitParts()
        {
            display = new Display();
            returnChange = new CoinStorage();
            goodStorage = new GoodsStorage();
            changer = new CoinChanger(display, returnChange);
        }

        protected virtual void DisplayMenu()
        {
            foreach (Good item in goodStorage.Goods)
            {
                display.Show(item.Name + "\t" + changer.Prices[item]);
            }
        }

        protected void DeliverGood(Good good)
        {
            goodStorage.RemoveGood(good);
            display.Show("В лоток выпал товар: " + good.Name);
            changer.CalculateChange();
        }
        #endregion    
        */    
    }
}
