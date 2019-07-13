using System;
using System.Collections.Generic;
using System.Text;

namespace PriceTicker
{
    class StockEventArgs : EventArgs
    {

        public Stock Stock { get; set; }
       

        public StockEventArgs(Stock stock)
        {
            this.Stock = stock;
        }

    }
}
