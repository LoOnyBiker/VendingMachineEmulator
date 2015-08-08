using System;

namespace VendingMachineEmulator
{
    public class Display : IDisplay
    {

        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Clear()
        {
            Console.WriteLine(string.Empty);
        }

    }
}
