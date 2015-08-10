using VendingMachine.Parts.CoinChangerComponents;

namespace VendingMachine.Parts
{
    public class CoinChanger
    {

        private CircuitBoard brain;
        private CoinIdentify coinID;
        private CoinStorage storage;

        private IDisplay display;
        private CoinStorage returnChange;

        public bool waitMoney
        {
            get { return brain.isExactChange; }
        }

        public GoodsStorage Prices
        {
            get { return brain.PriceList; }
        }

        public Good Selection
        {
            get { return brain.chosen; }
            set { brain.chosen = value; }
        }

        public CoinChanger(IDisplay d, CoinStorage changeBox)
        {
            brain = new CircuitBoard();
            coinID = new CoinIdentify();
            storage = new CoinStorage();

            display = d;
            returnChange = changeBox;
        }

        private void InsertCoin(Coin c)
        {
            if (coinID.isAvaliable(c))
            {
                storage.Add(c);
                brain.currentBill += c.Rating;
            }
            else
            {
                display.Show("Автомат не принимает монет данного номинала.");
                returnChange.Add(c);
            }
        }

        public void Process(Coin c)
        {
            InsertCoin(c);
            if(!brain.isExactChange)
                display.Show("Внесите " + brain.WaitFor + " руб");
        }

    }
}
