using World;
using System;

namespace VendingMachine.Emulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init vending machine we'll working with
            // that automatcly called LoadGoods function so
            // there's no need in call like
            // vm.ServiceLoad();
            CustomVendingMachine vm = new CustomVendingMachine();
            // Now we init ourselves
            // It doesn't matter how mant coins different rating we have
            Customer you = new Customer(150);

            // Interaction with vendong machine
            you.interact(vm);
        }
    }
}
