using System;
using System.Collections.Generic;
using System.Text;

namespace PriceTicker
{
    public class StockClient
    {
        public void OnPriceTicked(object source, EventArgs e)
        {
            Console.WriteLine("Stock:" + ((StockEventArgs)e).Stock.Ticker + " Price:" + ((StockEventArgs)e).Stock.Price + " " + DateTime.Now);
        }
    }
}
