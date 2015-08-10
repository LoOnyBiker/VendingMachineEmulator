using System;

namespace VendingMachine.Parts
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
