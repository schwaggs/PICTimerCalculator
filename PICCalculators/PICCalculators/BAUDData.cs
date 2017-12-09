using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICCalculators
{
    class BAUDData
    {
        internal static decimal FOSC { get; set; }
        internal static decimal CONF { get; set; }
        internal static decimal Desired_BAUD { get; set; }
        internal static decimal Actual_BAUD { get; set; }
        internal static decimal Error { get; set; }
        internal static decimal SPBRG { get; set; }
        internal static bool _Calculate { get; set; }

        internal static void Calculate_BAUD()
        {
            SPBRG = Calculate.SPBRG(FOSC, CONF, Desired_BAUD);
            Actual_BAUD = Calculate.Acual_BAUD_Rate(FOSC, CONF, SPBRG);
            Error = Calculate.BAUD_Error(Actual_BAUD, Desired_BAUD);
        }
    }
}
