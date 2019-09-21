using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public interface ICheckout
    {
        void Scan(Item item);
        int Total();
    }
}
