namespace VendingMachine.Parts.CoinChangerComponents
{
    public sealed class CircuitBoard
    {

        private int _expected;
        private Good _chosen;

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
        
        public int currentBill
        {
            get; set;
        }

        public bool isExactChange
        {
            get { return currentBill >= _expected; }
        }

        public int GetChange
        {
            get { return currentBill - _expected; }
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
