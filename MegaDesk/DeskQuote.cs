using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public string Shipping { get; set; }
        public Desk desk { get; set; }

        public decimal GetQuote()
        {
            //TODO set up method
            decimal result = 0;
            return result;
        }
    }
}
