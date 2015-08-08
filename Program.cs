using System;

namespace VendingMachineEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new CookieMachine();
            vm.ServiceLoad();
            vm.Start();

            vm.DisplayMenu();

            Console.ReadKey();
        }
    }
}
