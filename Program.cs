using System;

namespace VendingMachineEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new CookieMachine();
            Customer you = new Customer();

            vm.ServiceLoad();
            vm.Start();
            
            you.PayDay();
            you.LookAt(vm);

            //vm.DisplayMenu();

            Console.ReadKey();
        }
    }
}
