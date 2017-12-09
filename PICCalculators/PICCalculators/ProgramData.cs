using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICCalculators
{
    internal static class ProgramData
    {
        internal static bool Generate { get; set; }
        internal static decimal Instruction_Frequency { get; set; }
        internal static decimal Min_Delay { get; set; }
        internal static decimal Max_Delay { get; set; }
        internal static decimal Timer_Frequency { get; set; }
        internal static decimal Timer_Period { get; set; }
        internal static decimal Delay_Count { get; set; }
        internal static decimal Register_Value { get; set; }
        internal static decimal Tick_Counter { get; set; }
        internal static decimal Full_Register { get; set; }

        internal static string Instruction_Frequency_Units { get; set; }
        internal static string Min_Delay_Units { get; set; }
        internal static string Max_Delay_Units { get; set; }
        internal static string Timer_Frequency_Units { get; set; }
        internal static string Timer_Period_Units { get; set; }


        internal const decimal pico = 0.000000000001M;
        internal const decimal nano = 0.000000001M;
        internal const decimal micro = 0.000001M;
        internal const decimal milli = 0.001M;
        internal const decimal kilo = 1000M;
        internal const decimal mega = 1000000M;
        internal const decimal giga = 1000000000M;
        internal const decimal tera = 1000000000000M;
        internal const decimal peta = 1000000000000000M;

        internal const double ln2 = 0.69314718056;
    }
}
