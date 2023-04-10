using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploenum.Entities.Enums
{
    enum OrderStatus: int
    {
        PendingPayment = 8,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
