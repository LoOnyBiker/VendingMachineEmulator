using EntireWorld;
using VendingMachine.Parts;

namespace VendingMachine
{
    public class CustomVendingMachine
    {
        protected CoinChanger changer;
        protected CoinStorage returnChange;
        protected IDisplay display;
        protected GoodsStorage goodStorage;

        public string Name
        {
            get; protected set;
        }

        public bool WaitMoney
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

        public CustomVendingMachine()
        {
            InitParts();
            Name = "unknown VM";
        }

        public CustomVendingMachine(string name)
        {
            InitParts();
            Name = name;
        }

        public virtual void Insert(Coin coin)
        {
            changer.Process(coin);
            if (ExactChange)
                DeliverGood(Selection);
        }

        protected virtual void DisplayMenu()
        {
            foreach (Good item in goodStorage.Goods)
            {
                display.Show(item.Name+"\t"+changer.Prices[item]);
            }
        }

        public virtual void WaitForChoise()
        {
            DisplayMenu();
        }

        public virtual void LoadGoods(Good good,int price, int amount)
        {
            goodStorage.AddGood(good, amount);
            changer.Prices.AddGood(good, price);
        }

        protected virtual void CalculateChange() { }

        protected virtual void InitParts()
        {
            display = new Display();
            returnChange = new CoinStorage();
            goodStorage = new GoodsStorage();
            changer = new CoinChanger(display, returnChange);
        }

        protected void DeliverGood(Good good)
        {
            goodStorage.RemoveGood(good);
            display.Show("В лоток выпал товар: " + good.Name);
        }

        public bool Contain(Good g)
        {
            return goodStorage.Contains(g);
        }
    }
}
