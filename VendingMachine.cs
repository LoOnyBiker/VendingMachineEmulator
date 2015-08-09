using System.Collections.Generic;

namespace VendingMachineEmulator
{
    public enum MachineStatus
    {
        Waiting,
        Purchase,
        Shutdown,
        Error
    }

    public class VendingMachine
    {

        protected CoinStorage coinStorage;
        protected CoinStorage returnStorage;
        protected GoodsStorage goodStorage;
        protected IDisplay display;

        protected List<Coin> avaliableCoins;
        private PriceList prices;
        private MachineStatus status = MachineStatus.Shutdown;

        private int totalBill = 0;
        private Good chosen;

        public int CoinsTotal
        {
            get { return coinStorage.Total; }
        }

        public string Name
        {
            get; set;
        }

        public VendingMachine()
        {
            InitParts();
            Name = "unknown VM";
        }

        public VendingMachine(string name)
        {
            InitParts();
            Name = name;
        }

        public virtual void Start(/*Service*/)
        {
            display.Show("Автомат начал работу.");
            status = MachineStatus.Waiting;
        }

        public virtual void Shutdown(/*Service*/)
        {
            display.Show("Автомат отключается...");
            Cancel();
            status = MachineStatus.Shutdown;
        }

        public void Insert(Coin coin)
        {
            if (isAvaliable(coin))
                coinStorage.Add(coin);
        }

        public void Insert(Customer c, Coin coin)
        {
            if (isAvaliable(coin))
            {
                coinStorage.Add(coin);
                totalBill += coin.Rating;
            }
            else
                c.Get(coin);
        }

        public virtual void Purchase(Customer c)
        {
            if (status != MachineStatus.Shutdown)
            {
                // customer make selection
                chosen = new Good("Вафли");
                while (!CheckTotal())
                {
                    c.CheckoutWallet();
                    Coin coin = c.Find();
                    if (c.isAvaliable(coin))
                    {
                        c.Spend(coin);
                        Insert(c, coin);
                    }
                }
                display.Show("Вот " + chosen.Name);
                totalBill = 0;
            }
        }

        public virtual void Cancel() { }

        public virtual void DisplayMenu()
        {
            foreach (Good item in goodStorage.Goods)
            {
                display.Show(item.Name+"\t"+prices[item]);
            }
        }

        public virtual void LoadGoods(Good good,int price, int amount)
        {
            goodStorage.AddGood(good, amount);
            prices.Add(good, price);
        }

        protected virtual void CalculateChange() { }

        protected virtual void InitParts()
        {
            coinStorage = new CoinStorage();
            returnStorage = new CoinStorage();
            goodStorage = new GoodsStorage();
            display = new Display();

            avaliableCoins = new List<Coin>();
            prices = new PriceList();
        }

        protected bool CheckTotal()
        {
            return (totalBill >= prices[chosen]);
        }

        protected void ReturnChanges() { }

        protected void DeliverGood() { }

        private bool isAvaliable(Coin coin)
        {
            bool result = false;
            foreach (Coin c in avaliableCoins)
            {
                if (c.Rating == coin.Rating)
                    result = true;
            }
            if (!result)
                display.Show("Автомат " + Name + " не принимает таких монет.");

            return result;
        }

    }
}
