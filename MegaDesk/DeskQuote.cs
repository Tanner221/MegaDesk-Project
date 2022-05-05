using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public enum ShippingOption
    {
        [Description("Normal 14 Day")] Normal,
        [Description("3 Day")] ThreeDay,
        [Description("5 Day")] FiveDay,
        [Description("7 Day")] SevenDay
    }
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public ShippingOption shippingOption { get; set; }
        public Desk desk { get; set; }

        public decimal GetQuote()
        {
            //TODO set up method
            decimal result = 0;
            return result;
        }
    }
}
