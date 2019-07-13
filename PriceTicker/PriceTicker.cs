using System;
using System.Collections.Generic;
using System.Text;

namespace PriceTicker
{
    public class PriceTicker
    {
        public delegate void PriceTickEventHandler(object source, EventArgs args);
        public event PriceTickEventHandler PriceTicked;
        public void PriceTick(string ticker)
        {
            Random random = new Random();

            int stockPrice = 0;

            switch (ticker)
            {
                case "Stock1":
                    stockPrice = random.Next(240, 270);
                    break;
                case "Stock2":
                    stockPrice = random.Next(180, 210);
                    break;
                default:
                    break;
            }

            

            OnPriceTicked(stockPrice, ticker);
        }

        protected virtual void OnPriceTicked(int stockPrice, string ticker)
        {
            if (PriceTicked != null)
            {
                PriceTicked(this, new StockEventArgs(new Stock { Price = stockPrice, Ticker = ticker }));
            }
                
        }
    }
}
