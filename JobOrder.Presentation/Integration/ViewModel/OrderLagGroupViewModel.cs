using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Presentation.Integration.ViewModel
{    
    public class OrderLagGroupViewModel
    {
        public string OrderName { get; set; }
        public IGrouping<string, OrderLagViewModel> DataSource { get; set; }
    }
}
