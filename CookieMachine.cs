using System.Collections.Generic;

namespace VendingMachineEmulator
{
    public class CookieMachine : VendingMachine
    {

        public CookieMachine()
        {
            avaliableCoins.AddRange(
                new List<Coin>(4) {
                    new Coin(1),
                    new Coin(2),
                    new Coin(5),
                    new Coin(10) }
                );
            Name = "Cookies&Co";
        }
    }
}
