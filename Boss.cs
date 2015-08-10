using VendingMachine;

namespace EntireWorld
{
    public static class Boss
    {

        public static void PayDay(this Customer c)
        {
            Coin c1 = new Coin(1);
            Coin c2 = new Coin(2);
            Coin c3 = new Coin(5);
            Coin c4 = new Coin(10);

            c.Get(c1, 11);
            c.Get(c2, 7);
            c.Get(c3, 5);
            c.Get(c4, 10);
        }

    }
}
