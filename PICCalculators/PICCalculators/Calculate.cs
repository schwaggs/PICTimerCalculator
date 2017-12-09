using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PICCalculators
{
    internal class Calculate
    {
        /*
         *  =========================================================== InstructionFrequency
         *  Method Name:        InstructionFrequency
         *  
         *  Method Purpose:     Given a system clock frequency and a clock divider calculate
         *                      the instruction frequency used by the system timers.
         *  
         *  Method Arguments:   FOSC
         *                      decimal
         *                      The system clock frequency
         *                      
         *                      Clock_Divider
         *                      decimal
         *                      The system clock divider
         *  
         *  Method Return:      decimal -   The system instruction frequency
         *  ================================================================================
         */

        internal static decimal InstructionFrequency(decimal FOSC, decimal Clock_Divider)
        {
            try
            {
                return (FOSC / Clock_Divider);
            }

            catch
            {
                return 0;
            }
        }






        /*
         *  ================================================================= TimerFrequency
         *  Method Name:        TimerFrequency
         *  
         *  Method Purpose:     Given the system instruction frequency and the prescaler
         *                      chosen, calculate the frequency of the system timers.
         *  
         *  Method Arguments:   Instruction_Frequency
         *                      decimal
         *                      The system instruction frequency
         *                      
         *                      Prescaler
         *                      decimal
         *                      The chosen prescaler
         *  
         *  Method Return:      decimal -   The frequency all timers will operate at
         *  ================================================================================
         */

        internal static decimal TimerFrequency (decimal Instruction_Frequency, decimal Prescaler)
        {
            try
            {
                return (Instruction_Frequency / Prescaler);
            }

            catch
            {
                return 0;
            }
        }






        /*
         *  ==================================================================== TimerPeriod
         *  Method Name:        TimerPeriod
         *  
         *  Method Purpose:     Given a timer frequency calculate the timer period. This is
         *                      also the minimum delay any timer can provide.
         *  
         *  Method Arguments:   Timer_Frequency
         *                      decimal
         *                      The timer frequency
         *  
         *  Method Return:      decimal -   The absolute minimum period a timer can have
         *  ================================================================================
         */

        internal static decimal TimerPeriod (decimal Timer_Frequency)
        {
            try
            {
                return (1 / Timer_Frequency);
            }

            catch
            {
                return 0;
            }
        }






        /*
         *  ====================================================================== Max_Delay
         *  Method Name:        Max_Delay
         *  
         *  Method Purpose:     Given a timer period and the the value of the full timer
         *                      register, 0xFF, 0xFFFF, etc, calculate the maximum delay
         *                      the timer can provide.
         *  
         *  Method Arguments:   Timer_Period
         *                      decimal
         *                      The minimum delay the timer can have
         *                      
         *                      Full_Register
         *                      decimal
         *                      The maximum value the timer register can have
         *  
         *  Method Return:      decimal -   The maximum delay the timer can provide
         *  ================================================================================
         */

        internal static decimal Max_Delay(decimal Timer_Period,  decimal Full_Register)
        {
            try
            {
                return (Timer_Period * Full_Register);
            }
            
            catch
            {
                return 0;
            }
        }






        /*
         *  ================================================================== Full_Register
         *  Method Name:        Full_Register
         *  
         *  Method Purpose:     Given a register size calculates the maximum value the
         *                      register can have such as 0xFF for an 8 bit register.
         *  
         *  Method Arguments:   Register_Size
         *                      decimal
         *                      The size of the timer register in bits
         *  
         *  Method Return:      decimal -   The maximum value the timer register can have
         *  ================================================================================
         */

        internal static decimal Full_Register (decimal Register_Size)
        {
            try
            {
                return (Convert.ToDecimal(Math.Pow(2, Convert.ToDouble(Register_Size))));
            }

            catch
            {
                return 0;
            }
        }






        /*
         *  ==================================================================== Delay_Count
         *  Method Name:        Delay_Count
         *  
         *  Method Purpose:     Given the desired delay in seconds and the timer period,
         *                      calculate the required timer count to achieve the desired
         *                      delay. If the delay is too large for the timer the maximum
         *                      delay of the timer is used and a tick counter is calculated.
         *                      The tick counter is the number of times the maximum delay
         *                      of the timer needs to occur to get as close as possible to
         *                      the desired delay.
         *  
         *  Method Arguments:   Desired_Delay
         *                      decimal
         *                      The desired delay in seconds
         *                      
         *                      Timer_Period
         *                      decimal
         *                      The minimum delay the timer can have.
         *  
         *  Method Return:      decimal -   The timer count required to achieve the desired
         *                                  delay.
         *  ================================================================================
         */

        internal static decimal Delay_Count (decimal Desired_Delay, decimal Timer_Period)
        {
            try
            {
                return Desired_Delay / Timer_Period;
            }

            catch
            {
                return 0;
            }
        }






        /*
         *  ============================================================== PR_Register_Value
         *  Method Name:        PR_Register_Value
         *  
         *  Method Purpose:     Given the maximum value of the timer register and the delay
         *                      count, calculate the PR register value of the timer. For
         *                      a 16 bit timer this is usually broken up into high and low
         *                      registers so the value will need to be seperated into it's
         *                      8 bit high and low representations.
         *  
         *  Method Arguments:   Full_Register
         *                      decimal
         *                      The maximum value the timer register can have
         *                      
         *                      Delay_Count
         *                      decimal
         *                      The timer count required to reach the desired delay
         *  
         *  Method Return:      deciaml -   The PR register value required for the desired
         *                                  delay.
         *  ================================================================================
         */

        internal static decimal PR_Register_Value (decimal Full_Register, decimal Delay_Count)
        {
            try
            {
                return (Full_Register - Delay_Count);
            }
            
            catch
            {
                return 0;
            }
        }






        /*
         *  =================================================================== Tick_Counter
         *  Method Name:        Tick_Counter
         *  
         *  Method Purpose:     Given the deisred delay and the maximum delay the timer can
         *                      produce, calculate the number of times the maximum delay
         *                      must occur to get as close as possible to the desired dealy.
         *  
         *  Method Arguments:   Desired_Delay
         *                      decimal
         *                      The desired delay in seconds
         *                      
         *                      Max_Delay
         *                      decimal
         *                      The maximum delay the timer can produce.
         *  
         *  Method Return:      decimal -   The number of times the maximum delay must occur
         *                                  to get as close as possible to the desired
         *                                  delay.
         *  ================================================================================
         */

        internal static decimal Tick_Counter(decimal Desired_Delay, decimal Max_Delay)
        {
            try
            {
                return Convert.ToDecimal(Math.Round((Desired_Delay / Max_Delay), 0));
            }
            
            catch
            {
                return 0;
            }
        }






        /*
         *  ========================================================================== SPBRG
         *  Method Name:        SPBRG
         *  
         *  Method Purpose:     Given the system clock frequency, the chosen CONF value,
         *                      and the desired BAUD rate, calculate the SPBRG register
         *                      value.
         *  
         *  Method Arguments:   FOSC
         *                      decimal
         *                      The system clock frequency
         *                      
         *                      CONF
         *                      decimal
         *                      The chosen CONF value
         *                      
         *                      Desired_BAUD
         *                      decimal
         *                      The desired BAUD rate such as 19200
         *  
         *  Method Return:      decimal -   The SPBRG register value required for the
         *                                  desired BAUD rate.
         *  ================================================================================
         */

        internal static decimal SPBRG(decimal _FOSC, decimal _CONF, decimal _Desired_BAUD)
        {
            try
            {
                return Math.Round(((_FOSC - _CONF * _Desired_BAUD) / (_CONF * _Desired_BAUD)), 0);
            }
            
            catch
            {
                return 0;
            }
        }






        /*
         *  =============================================================== Actual_BAUD_Rate
         *  Method Name:        Acutal_BAUD_Rate
         *  
         *  Method Purpose:     Given the system clock frequency, the chosen CONFG value,
         *                      and the SPBRG register value, calculate the actual BAUD
         *                      rate that is produced.
         *  
         *  Method Arguments:   _FOSC
         *                      decimal
         *                      The system clock frequency
         *                      
         *                      _CONF
         *                      decimal
         *                      The chosen CONFG value
         *                      
         *                      _SPBRG
         *                      decimal
         *                      The SPBRG register value required for the desired BAUD rate
         *  
         *  Method Return:      decimal - The acutal BAUD rate that is prodcued
         *  ================================================================================
         */

        internal static decimal Acual_BAUD_Rate(decimal _FOSC, decimal _CONF, decimal _SPBRG)
        {
            try
            {
                return Math.Round((_FOSC / (_CONF * (_SPBRG + 1))), 0, MidpointRounding.AwayFromZero) - 1;
            }

            catch
            {
                return 0;
            }
        }






        /*
         *  ===================================================================== BAUD_Error
         *  Method Name:        BAUD_Error
         *  
         *  Method Purpose:     Given the actual BAUD rate and the desired BAUD rate find
         *                      the error between the two.
         *  
         *  Method Arguments:   _Actual_BAUD_Rate
         *                      decimal
         *                      The actual BAUD rate that is produced
         *                      
         *                      _Desired_BAUD_Rate
         *                      decimal
         *                      The desired BAUD rate
         *  
         *  Method Return:      decimal -   The error percentage between the actual BAUD
         *                                  rate and the desired BAUD rate.
         *  ================================================================================
         */

        internal static decimal BAUD_Error(decimal _Actual_BAUD_Rate, decimal _Desired_BAUD_Rate)
        {
            try
            {
                return decimal.Round(Math.Abs(100 * ((_Actual_BAUD_Rate - _Desired_BAUD_Rate) / _Actual_BAUD_Rate)), 2);
            }

            catch
            {
                return 0;
            }
        }
    }
}
