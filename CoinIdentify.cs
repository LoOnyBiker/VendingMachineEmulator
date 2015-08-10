using System.Collections.Generic;

namespace VendingMachine.Parts.CoinChangerComponents
{
    public class CoinIdentify
    {

        List<Coin> avaliableCoins;

        public CoinIdentify()
        {
            avaliableCoins = new List<Coin>(4) {
                    new Coin(1),
                    new Coin(2),
                    new Coin(5),
                    new Coin(10) };
        }

        public bool isAvaliable(Coin c)
        {
            return avaliableCoins.Contains(c);
        }

    }
}
