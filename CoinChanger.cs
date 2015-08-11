using System.Collections.Generic;
using VendingMachine.Parts.CoinChangerComponents;

namespace VendingMachine.Parts
{
    public class CoinChanger
    {

        private CircuitBoard brain;
        private CoinIdentify coinID;
        private CoinStorage storage;
        private CoinStorage change;

        private IDisplay display;
        private CoinStorage returnChange;

        #region Properties
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
        
        public bool CancelOrder
        {
            get;set;
        }
        #endregion

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
                brain.CurrentBill += c.Rating;
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

        public void CalculateChange()
        {
            List<Coin> list = storage.GetCoinsRating();
            list.Sort(delegate(Coin x, Coin y) { return x.Compare(x, y); });

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (brain.Change >= list[i].Rating)
                {
                    if (storage.Contains(list[i]))
                    {
                        while (brain.Change >= list[i].Rating)
                        {
                            display.Show("Вам вернули монетку номиналом " + list[i].ToString());
                            brain.CurrentBill -= list[i].Rating;
                            storage.Remove(list[i]);
                            returnChange.Add(list[i]);
                        }
                    }
                    else
                        display.Show("Монет номиналом " + list[i].ToString() + " в автомате нет.");                  
                }                    
            }
        }

    }
}
