using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOrder.Presentation
{
    public static class Extensions
    {
        public static string RemoveSpaces(this string value)
        {
            return value.Replace(" ", string.Empty);
        }
    }
}
