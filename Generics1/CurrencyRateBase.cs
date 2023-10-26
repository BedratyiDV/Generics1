using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
     public class CurrencyRateBase<T>
    {
        public T Buy { get; set; }
        public T Sell { get; set; }
    }
}
