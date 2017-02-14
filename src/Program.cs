using World;
using System;

namespace VendingMachine.Emulator
{
    class Program
    {
        static void ServiceLoad(CustomVendingMachine vm)
        {
            Good g1 = new Good("Cakes");
            Good g2 = new Good("Cookies");
            Good g3 = new Good("Waffles");

            vm.load(g1, 4);
            vm.load(g2, 3);
            vm.load(g3, 10);
        }

        static void Main(string[] args)
        {
            // Init vending machine we'll working with
            // that automatcly called LoadGoods function so
            // there's no need in call like
            // vm.ServiceLoad();
            CustomVendingMachine vm = new CustomVendingMachine();
            // Load all goods we want to it's places
            ServiceLoad(vm);
            // Now we init ourselves
            // It doesn't matter how mant coins different rating we have
            Customer you = new Customer(150);

            // Interaction with vendong machine
            you.interact(vm);

            Console.ReadKey();
        }
    }
}
