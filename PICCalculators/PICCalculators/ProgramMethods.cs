using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICCalculators
{
    internal class ProgramMethods
    {
        internal static void Generate()
        {
            ProgramData.Instruction_Frequency = UserData.FOSC / UserData.Clock_Divider;
            ProgramData.Timer_Frequency = ProgramData.Instruction_Frequency / UserData.Prescaler;
            ProgramData.Timer_Period = 1 / ProgramData.Timer_Frequency;
            ProgramData.Min_Delay = 1 / ProgramData.Timer_Frequency;
            ProgramData.Full_Register = Convert.ToDecimal(Math.Pow(2, Convert.ToDouble(UserData.Register_Size)));
            ProgramData.Max_Delay = ProgramData.Timer_Period * ProgramData.Full_Register;
            ProgramData.Delay_Count = UserData.Desired_Delay / ProgramData.Timer_Period;
            ProgramData.Register_Value = ProgramData.Full_Register - ProgramData.Delay_Count;

            if (UserData.Desired_Delay > ProgramData.Max_Delay)
            {
                ProgramData.Tick_Counter = Math.Round(UserData.Desired_Delay / ProgramData.Max_Delay);
            }

            else if (UserData.Desired_Delay < ProgramData.Min_Delay)
            {
                ProgramData.Tick_Counter = Math.Round(ProgramData.Min_Delay / UserData.Desired_Delay);
            }

            else
            {
                ProgramData.Tick_Counter = 1;
            }
        }
    }
}
