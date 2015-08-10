namespace VendingMachine
{
    public struct Coin
    {

        private int rating;
        public int Rating
        {
            get { return rating; }
            private set { rating = value; }
        }

        public Coin(int nom = 1)
        {
            rating = nom;
        }

        public override string ToString()
        {
            return string.Format("{0} руб", rating);
        }

    }
}
