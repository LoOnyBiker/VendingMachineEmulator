namespace VendingMachine.Parts.CoinChangerComponents
{
    public sealed class CircuitBoard
    {
        private int _expected;
        private Good _chosen;
        private int currentBill;

        #region Properties
        public GoodsStorage PriceList
        {
            get;
            private set;
        }
        
        public Good chosen
        {
            get
            {
                return _chosen;
            }
            set
            {
                _expected = PriceList[value];
                _chosen = value;
            }
        }

        public bool isExactChange
        {
            get { return currentBill >= _expected; }
        }

        public int Change
        {
            get { return currentBill - _expected; }
            set { _expected = value; }
        }

        public int CurrentBill
        {
            get { return currentBill; }
            set { currentBill = value; }
        }

        public int WaitFor
        {
            get { return _expected - currentBill; }
        }
        #endregion


        public CircuitBoard()
        {
            PriceList = new GoodsStorage();
        }

    }
}
