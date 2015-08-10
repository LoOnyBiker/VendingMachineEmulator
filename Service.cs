namespace VendingMachine
{
    public static class Service
    {

        public static void ServiceLoad(this CustomVendingMachine vm)
        {
            Good g1 = new Good("Кексики");
            Good g2 = new Good("Печенье");
            Good g3 = new Good("Вафли");

            vm.LoadGoods(g1, 50, 4);
            vm.LoadGoods(g2, 10, 3);
            vm.LoadGoods(g3, 30, 10);
        }

    }
}
