namespace VendingMachineEmulator
{
    public struct Coin
    {

        private int nominal;
        public int Nominal
        {
            get { return nominal; }
            private set { nominal = value; }
        }

        public Coin(int nom)
        {
            nominal = nom;
        }

        public override string ToString()
        {
            return string.Format("{0} руб", nominal);
        }

    }
}
