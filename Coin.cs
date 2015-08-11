using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public struct Coin : IComparer<Coin>
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

        public int Compare(Coin x, Coin y)
        {
            if (x.rating == y.rating)
                return 0;
            if (x.rating < y.rating)
                return -1;
            return 1;
        }
    }
}
