using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoCurrency
{
    internal class Currency
    {
        public int currencyCodeA { get; set; }
        public int currencyCodeB { get; set; }
        public int date { get; set; }
        public float rateBuy { get; set; }
        public float rateCross { get; set; }
        public float rateSell { get; set; }
    }
}
