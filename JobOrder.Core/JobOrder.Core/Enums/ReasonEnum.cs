using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Core.Enums
{
    public enum ReasonEnum
    {
        [Description("Mola")]
        Break,
        [Description("Arıza")]
        Fault,
        [Description("Setup")]
        Setup,
        [Description("Arge")]
        RD
    }
}
