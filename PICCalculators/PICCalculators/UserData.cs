using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICCalculators
{
    internal static class UserData
    {
        internal static decimal FOSC { get; set; }              // Stored as Hz
        internal static decimal Desired_Delay { get; set; }     // Stored as Seconds
        internal static decimal Prescaler { get; set; }         // Stored as regular value
        internal static decimal Register_Size { get; set; }     // Stored as bits
        internal static decimal Clock_Divider { get; set; }     // Stored as regular value
    }
}
