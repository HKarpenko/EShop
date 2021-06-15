using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Domain.OrderAggregate
{
    public enum OrderStatus
    {
        NotConfirmed = 10,
        Paid = 20,
        Returned = 30,
        Closed = 40
    }
}
