using System;
using VendingMachine;
using VendingMachine.Parts;

namespace EntireWorld
{
    public class Customer
    {
        private CoinStorage wallet;

        public Customer()
        {
            wallet = new CoinStorage();
        }

        public void Get(Coin coin, int Amount = 1)
        {
            wallet.Add(coin, Amount);
        }

        private Coin Find()
        {
            Console.Write("Вы выбираете монету номиналом в ");
            int c = int.Parse(
                Console.ReadLine()
                );
            return new Coin(c);
        }

        public void MakeChoise(CustomVendingMachine vm)
        {
            Console.Write("Осмотрев меню вы остановились на ");
            Good g = new Good( Console.ReadLine());
            Console.WriteLine();

            if (vm.Contain(g))
            {
                vm.Selection = g;
                Purchase(vm);
            }
            else
            {
                Console.Write("Данный товар не был обнаружен в автомате. ");
                Console.WriteLine("Пожалуйста сделайте выбор снова.");
                Console.WriteLine();
                MakeChoise(vm);
            }                
        }

        public void Spend(Coin c, int amount = 1)
        {
            wallet.Remove(c);
            Console.WriteLine("Монетка со звоном падает в монетоприемник.");
            Console.WriteLine();
        }

        public void LookAt(CustomVendingMachine vm)
        {
            vm.WaitForChoise();
        }

        private void Purchase(CustomVendingMachine vm)
        {
            while (!vm.WaitMoney)
            {
                if (vm.CancelOrder)
                    break;

                CheckoutWallet();
                Coin coin = Find();
                if (isAvaliable(coin))
                {
                    Spend(coin);
                    vm.Insert(coin);
                }
                else
                {
                    Console.WriteLine("Вы не обнаруживаете в кошельке монету номиналов в " + coin.Rating + " руб");
                    Console.WriteLine();
                    Console.Write("Отменить покупку? [д/н]");
                    string ans = Console.ReadLine();
                    if (ans.ToLower() == "д")
                        vm.Cancel();
                }                                  
            }
        }

        public void CheckoutWallet()
        {
            Console.WriteLine(
                "Вы осматриваете кошелек и обнаруживаете там {0} руб. Из них:\n", wallet.Total);
            Console.WriteLine("Номинал\tЧисло");
            Console.WriteLine(wallet.ToString());
        }

        public bool isAvaliable(Coin c)
        {
            return (wallet.Contains(c) && wallet[c] > 0);
        }

    }
}
