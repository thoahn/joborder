using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Presentation.Integration.ViewModel
{
    public class OrderLagViewModel
    {
        public string OrderName { get; set; }
        public string LagReason { get; set; }
        public double LagDuration { get; set; }
    }
}
