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

        public virtual void Insert(Coin coin)
        {
            if (isAvaliable(coin))
                coinStorage.Add(coin);
        }

        public virtual void Insert(Customer c, Coin coin)
        {
            if (isAvaliable(coin))
                coinStorage.Add(coin);
            else
                c.Get(coin);
        }

        public virtual void Purchase()
        {
            if (status != MachineStatus.Shutdown)
            {

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

        private void ReturnChanges() { }

        private void DeliverGood() { }

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
