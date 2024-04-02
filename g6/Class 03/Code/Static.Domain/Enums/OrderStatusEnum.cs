using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Domain.Enums
{
   public enum OrderStatusEnum
    {
        Created = 1,
        Processing,
        DeliveryInProcess,
        Delivered,
        Problem
    }
}
