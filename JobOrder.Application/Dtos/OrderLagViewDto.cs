using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Application.Dtos
{
    public class OrderLagViewDto
    {
        public string OrderName { get; set; }
        public string LagReason { get; set; }
        public double LagDuration { get; set; }
    }
}
