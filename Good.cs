namespace VendingMachine
{
    public struct Good
    {

        private string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public Good(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}", name);
        }

    }
}
