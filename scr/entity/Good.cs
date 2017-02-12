namespace VendingMachine
{
    public struct Good
    {
        // Name whitch will be displayed to customer
        private string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        
        public Good(string name = "unknown goodie")
        {
            this.name = name;
        }


        public override string ToString()
        {
            return name;
        }

    }
}
