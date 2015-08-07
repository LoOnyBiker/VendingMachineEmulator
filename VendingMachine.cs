namespace VendingMachineEmulator
{
    public class VendingMachine
    {

        protected CoinStorage coinStorage;
        protected CoinStorage returnStorage;
        protected GoodsStorage goodStorage;

        public VendingMachine()
        {
            coinStorage = new CoinStorage();
            returnStorage = new CoinStorage();
            goodStorage = new GoodsStorage();
        }

        public virtual void Start() { }

        public virtual void Shutdown() { }

        public virtual void Insert(Coin coin) { }

        public virtual void Purchase() { }

        public virtual void Cancel() { }

        public virtual void DisplayMenu() { }

        protected virtual void CalculateChange() { }

        private void ReturnChanges() { }

        private void DeliverGood() { }

    }
}
