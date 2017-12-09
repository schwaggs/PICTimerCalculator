using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICCalculators
{
    internal class ManualModeData
    {
        internal static decimal FOSC { get; set; }              // Stored as Hz
        internal static decimal Desired_Delay { get; set; }     // Stored as Seconds
        internal static decimal Prescaler { get; set; }         // Stored as regular value
        internal static decimal Register_Size { get; set; }     // Stored as bits
        internal static decimal Clock_Divider { get; set; }     // Stored as regular value

        internal static decimal Instruction_Frequency { get; set; }
        internal static decimal Min_Delay { get; set; }
        internal static decimal Max_Delay { get; set; }
        internal static decimal Timer_Frequency { get; set; }
        internal static decimal Timer_Period { get; set; }
        internal static decimal Delay_Count { get; set; }
        internal static decimal Register_Value { get; set; }
        internal static decimal Tick_Counter { get; set; }
        internal static decimal Full_Register { get; set; }

        internal enum DATA_TYPE
        {
            ALL,
            FOSC,
            CLOCK_DIVIDER,
            PRESCALER,
            REGISTER_SIZE,
            DESIRED_DELAY,
            INSTRUCTION_FREQUENCY,
            TIMER_FREQUENCY,
            TIMER_PERIOD,
            MIN_DELAY,
            MAX_DELAY,
            DELAY_COUNT,
            REGISTER_VALUE,
            TICK_COUNTER
        }

        internal static void Calculate_All(DATA_TYPE ChangedData)
        {
            int i;

            if (ChangedData == DATA_TYPE.ALL)
            {
                Instruction_Frequency = Calculate.InstructionFrequency(FOSC, Clock_Divider);
                Timer_Frequency = Calculate.TimerFrequency(Instruction_Frequency, Prescaler);
                Timer_Period = Calculate.TimerPeriod(Timer_Frequency);
                Min_Delay = Timer_Period;
                Full_Register = Calculate.FullRegister(Register_Size);
                Max_Delay = Calculate.Max_Delay(Timer_Period, Full_Register);
                Delay_Count = Calculate.Delay_Count(Desired_Delay, Timer_Period);
                Register_Value = Calculate.PR_Register_Value(Full_Register, Delay_Count);
            }

            else
            {
                for(i = 1; i < (int)ChangedData; i ++)
                {
                    switch ((DATA_TYPE)i)
                    {
                        case DATA_TYPE.CLOCK_DIVIDER:
                            

                            break;


                        case DATA_TYPE.DELAY_COUNT:
                            Delay_Count = Calculate.Delay_Count(Desired_Delay, Timer_Period);

                            break;

                        case DATA_TYPE.DESIRED_DELAY:
                            

                            break;

                        case DATA_TYPE.FOSC:
                            

                            break;

                        case DATA_TYPE.INSTRUCTION_FREQUENCY:
                            Instruction_Frequency = Calculate.InstructionFrequency(FOSC, Clock_Divider);

                            break;

                        case DATA_TYPE.MAX_DELAY:
                            Max_Delay = Calculate.Max_Delay(Timer_Period, Full_Register);

                            break;

                        case DATA_TYPE.MIN_DELAY:
                            Min_Delay = Calculate.TimerPeriod(Timer_Frequency);

                            break;

                        case DATA_TYPE.PRESCALER:
                            

                            break;

                        case DATA_TYPE.REGISTER_SIZE:
                            

                            break;


                        case DATA_TYPE.REGISTER_VALUE:
                            Register_Value = Calculate.PR_Register_Value(Full_Register, Delay_Count);

                            break;


                        case DATA_TYPE.TICK_COUNTER:
                            

                            break;

                        case DATA_TYPE.TIMER_FREQUENCY:
                            Timer_Frequency = Calculate.TimerFrequency(Instruction_Frequency, Prescaler);

                            break;

                        case DATA_TYPE.TIMER_PERIOD:
                            Timer_Period = Calculate.TimerPeriod(Timer_Frequency);

                            break;
                    }
                }

                i += 1;

                if (i < (int)DATA_TYPE.TICK_COUNTER)
                {
                    for (; i <= (int)DATA_TYPE.TICK_COUNTER; i++)
                    {
                        switch ((DATA_TYPE)i)
                        {
                            case DATA_TYPE.CLOCK_DIVIDER:
                                

                                break;


                            case DATA_TYPE.DELAY_COUNT:
                                Delay_Count = Calculate.Delay_Count(Desired_Delay, Timer_Period);

                                break;

                            case DATA_TYPE.DESIRED_DELAY:
                                

                                break;

                            case DATA_TYPE.FOSC:
                                

                                break;

                            case DATA_TYPE.INSTRUCTION_FREQUENCY:
                                Instruction_Frequency = Calculate.InstructionFrequency(FOSC, Clock_Divider);

                                break;

                            case DATA_TYPE.MAX_DELAY:
                                Max_Delay = Calculate.Max_Delay(Timer_Period, Full_Register);

                                break;

                            case DATA_TYPE.MIN_DELAY:
                                Min_Delay = Timer_Period;

                                break;

                            case DATA_TYPE.PRESCALER:
                                

                                break;

                            case DATA_TYPE.REGISTER_SIZE:
                                

                                break;


                            case DATA_TYPE.REGISTER_VALUE:
                                Register_Value = Calculate.PR_Register_Value(Full_Register, Delay_Count);

                                break;


                            case DATA_TYPE.TICK_COUNTER:
                                

                                break;

                            case DATA_TYPE.TIMER_FREQUENCY:
                                Timer_Frequency = Calculate.TimerFrequency(Instruction_Frequency, Prescaler);

                                break;

                            case DATA_TYPE.TIMER_PERIOD:
                                Timer_Period = Calculate.TimerPeriod(Timer_Frequency);

                                break;
                        }
                    }
                }
            }
        }
    }
}
