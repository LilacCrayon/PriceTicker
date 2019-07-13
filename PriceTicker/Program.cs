using System;
using System.Threading;

namespace PriceTicker
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticker = args[0];
            var priceTick = new PriceTicker(); //Publisher
            var stockPrice = new StockClient(); //Subscriber

            priceTick.PriceTicked += stockPrice.OnPriceTicked;  

            while (true)
            {
                Thread.Sleep(1000);
                priceTick.PriceTick(ticker);
            }
            
        }
    }


}
