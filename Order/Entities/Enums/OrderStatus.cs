using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities.Enums
{
    enum OrderStatus : int
    {
        PedingPayment = 0,
        Processing = 1 ,
        Shipeed = 2 ,
        Delivered = 3

    }
}
