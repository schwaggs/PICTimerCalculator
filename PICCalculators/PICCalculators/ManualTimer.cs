using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PICCalculators.ManualModeData;

namespace PICCalculators
{
    public partial class ManualTimer : Form
    {
        public ManualTimer()
        {
            InitializeComponent();

            if (ProgramData.Generate)
            {
                Prescaler = UserData.Prescaler;
                FOSC = UserData.FOSC;
                Clock_Divider = UserData.Clock_Divider;
                Register_Size = UserData.Register_Size;
                Desired_Delay = UserData.Desired_Delay;

                PrescalerTRB.Value = Convert.ToInt32(Math.Log(Convert.ToDouble(Prescaler)) / ProgramData.ln2);
                FOSCTRB.Value = Convert.ToInt32(Math.Log(Convert.ToDouble(FOSC / ProgramData.mega)) / ProgramData.ln2);
                ClockDividerTRB.Value = Convert.ToInt32(Math.Log(Convert.ToDouble(Clock_Divider)) / ProgramData.ln2);

                int temp = Convert.ToInt32(Math.Log(Convert.ToDouble(Register_Size)) / ProgramData.ln2);
                RegisterSizeTRB.Value = temp;
                DesiredDelayTB.Text = Desired_Delay.ToString();
                
            }

            Calculate(DATA_TYPE.ALL);

            PrescalerLB.Text = Prescaler.ToString();
            FOSCLB.Text = (FOSC/ProgramData.mega).ToString();
            ClockDividerLB.Text = Clock_Divider.ToString();
            RegisterSizeLB.Text = Register_Size.ToString();

        }

        private void PrescalerTRB_ValueChanged(object sender, EventArgs e)
        {
            PrescalerTT.SetToolTip(PrescalerTRB, Math.Pow(2, PrescalerTRB.Value).ToString());
        }

        private void PrescalerTRB_Scroll(object sender, EventArgs e)
        {
            
        }

        private void PrescalerTRB_MouseUp(object sender, MouseEventArgs e)
        {
            Calculate(DATA_TYPE.PRESCALER);
            PrescalerLB.Text = Prescaler.ToString();
        }



        private void FOSCTRB_ValueChanged(object sender, EventArgs e)
        {
            FOSCTT.SetToolTip(FOSCTRB, Math.Pow(2, FOSCTRB.Value).ToString());
        }

        private void FOSCTRB_Scroll(object sender, EventArgs e)
        {

        }

        private void FOSCTRB_MouseUp(object sender, MouseEventArgs e)
        {
            Calculate(DATA_TYPE.FOSC);
            FOSCLB.Text = (FOSC/ProgramData.mega).ToString();
        }



        private void ClockDividerTRB_ValueChanged(object sender, EventArgs e)
        {
            ClockDividerTT.SetToolTip(ClockDividerTRB, Math.Pow(2, ClockDividerTRB.Value).ToString());
        }

        private void ClockDividerTRB_Scroll(object sender, EventArgs e)
        {

        }

        private void ClockDividerTRB_MouseUp(object sender, MouseEventArgs e)
        {
            Calculate(DATA_TYPE.CLOCK_DIVIDER);
            ClockDividerLB.Text = Clock_Divider.ToString();
        }



        private void RegisterSizeTRB_ValueChanged(object sender, EventArgs e)
        {
            RegisterSizeTT.SetToolTip(RegisterSizeTRB, Math.Pow(2, RegisterSizeTRB.Value).ToString());
        }

        private void RegisterSizeTRB_Scroll(object sender, EventArgs e)
        {

        }

        private void RegisterSizeTRB_MouseUp(object sender, MouseEventArgs e)
        {
            Calculate(DATA_TYPE.REGISTER_SIZE);
            RegisterSizeLB.Text = Register_Size.ToString();
        }

        private void DesiredDelayTB_TextChanged(object sender, EventArgs e)
        {
            Calculate(DATA_TYPE.DESIRED_DELAY);
        }

        
        private void Calculate(DATA_TYPE caller)
        {
            switch (caller)
            {
                case DATA_TYPE.ALL:
                    FOSC = GetTrackVal(DATA_TYPE.FOSC);
                    Clock_Divider = GetTrackVal(DATA_TYPE.CLOCK_DIVIDER);
                    Prescaler = GetTrackVal(DATA_TYPE.PRESCALER);
                    Register_Size = GetTrackVal(DATA_TYPE.REGISTER_SIZE);                  

                    break;

                case DATA_TYPE.CLOCK_DIVIDER:
                    Clock_Divider = GetTrackVal(DATA_TYPE.CLOCK_DIVIDER);
                    Calculate_All(DATA_TYPE.ALL);

                    break;

                case DATA_TYPE.DESIRED_DELAY:
                    Desired_Delay = GetVal(DATA_TYPE.DESIRED_DELAY);
                    Calculate_All(DATA_TYPE.ALL);

                    break;

                case DATA_TYPE.FOSC:
                    FOSC = GetTrackVal(DATA_TYPE.FOSC);

                    break;

                case DATA_TYPE.INSTRUCTION_FREQUENCY:
                    Instruction_Frequency = GetVal(DATA_TYPE.INSTRUCTION_FREQUENCY);

                    break;

                case DATA_TYPE.PRESCALER:
                    Prescaler = GetTrackVal(DATA_TYPE.PRESCALER);

                    break;

                case DATA_TYPE.REGISTER_SIZE:
                    Register_Size = GetTrackVal(DATA_TYPE.REGISTER_SIZE);

                    break;

                case DATA_TYPE.REGISTER_VALUE:
                    Register_Value = GetVal(DATA_TYPE.REGISTER_VALUE);

                    break;

                case DATA_TYPE.TICK_COUNTER:
                    Tick_Counter = GetVal(DATA_TYPE.TICK_COUNTER);

                    break;

                case DATA_TYPE.TIMER_FREQUENCY:
                    Timer_Frequency = GetVal(DATA_TYPE.TIMER_FREQUENCY);

                    break;

                case DATA_TYPE.TIMER_PERIOD:
                    Timer_Period = GetVal(DATA_TYPE.TIMER_PERIOD);

                    break;

                case DATA_TYPE.MIN_DELAY:
                    Min_Delay = GetVal(DATA_TYPE.MIN_DELAY);

                    break;

                case DATA_TYPE.MAX_DELAY:
                    Max_Delay = GetVal(DATA_TYPE.MAX_DELAY);
                    
                    break;

                case DATA_TYPE.DELAY_COUNT:
                    Delay_Count = GetVal(DATA_TYPE.DELAY_COUNT);
                    
                    break;
            }

            if ((int)caller < (int)DATA_TYPE.DESIRED_DELAY)
            {
                Calculate_All(DATA_TYPE.ALL);
            }

            else
            {
                Calculate_All(caller);
            }

            if (Register_Value < 0)
            {
                Register_Value = Full_Register;
            }

            if (Desired_Delay > Max_Delay)
            {
                Tick_Counter = Math.Round((Desired_Delay / Max_Delay), 0, MidpointRounding.AwayFromZero) + 1;
            }

            else if (Desired_Delay < Min_Delay)
            {
                if (Desired_Delay == 0)
                {
                    Tick_Counter = 0;
                }
                else
                {
                    Tick_Counter = Math.Round((Min_Delay / Desired_Delay), 0, MidpointRounding.AwayFromZero) + 1;
                }
            }

            else
            {
                Tick_Counter = 1;
            }

            PopulateCalculated();
        }

        decimal GetTrackVal(DATA_TYPE data)
        {
            decimal temp = 0;

            switch (data)
            {
                case DATA_TYPE.FOSC:
                    temp = Convert.ToDecimal(Math.Pow(2, Convert.ToDouble(FOSCTRB.Value))) * ProgramData.mega;
                    break;

                case DATA_TYPE.CLOCK_DIVIDER:
                    temp = Convert.ToDecimal(Math.Pow(2, Convert.ToDouble(ClockDividerTRB.Value)));
                    break;

                case DATA_TYPE.PRESCALER:
                    temp = Convert.ToDecimal(Math.Pow(2, Convert.ToDouble(PrescalerTRB.Value)));
                    break;

                case DATA_TYPE.REGISTER_SIZE:
                    temp = Convert.ToDecimal(Math.Pow(2, Convert.ToDouble(RegisterSizeTRB.Value)));
                    break;
            }

            return temp;
        }

        decimal GetVal(DATA_TYPE data)
        {
            decimal temp = 0;

            try
            {
                switch (data)
                {
                    case DATA_TYPE.DESIRED_DELAY:
                        temp = Convert.ToDecimal(DesiredDelayTB.Text);
                        break;

                    case DATA_TYPE.INSTRUCTION_FREQUENCY:
                        temp = Convert.ToDecimal(InstructionFrequencyTB.Text);
                        break;

                    case DATA_TYPE.TICK_COUNTER:
                        temp = Convert.ToDecimal(TickCounterTB.Text);
                        break;

                    case DATA_TYPE.TIMER_FREQUENCY:
                        temp = Convert.ToDecimal(TimerFrequencyTB.Text);
                        break;

                    case DATA_TYPE.TIMER_PERIOD:
                        temp = Convert.ToDecimal(TimerPeriodTB.Text);
                        break;

                    case DATA_TYPE.MIN_DELAY:
                        temp = Convert.ToDecimal(MinDelayTB.Text);
                        break;

                    case DATA_TYPE.MAX_DELAY:
                        temp = Convert.ToDecimal(MaxDelayTB.Text);
                        break;

                    case DATA_TYPE.REGISTER_VALUE:
                        temp = Convert.ToDecimal(RegisterValueTB.Text);
                        break;

                    case DATA_TYPE.DELAY_COUNT:
                        temp = Convert.ToDecimal(DelayCountTB.Text);
                        break;
                }
            }

            catch
            {
                temp = 0;
            }

            return temp;
        }



        private void PopulateCalculated()
        {
            RegisterValueTB.Text = Register_Value.ToString();

            if (Register_Value < 0)
            {
                RegisterValueTB.ForeColor = Color.Red;
            }

            else
            {
                RegisterValueTB.ForeColor = Color.Black;
            }

            if (Register_Value > int.MaxValue)
            {
                RegisterValueHexTB.Text = "";
            }

            else
            {
                RegisterValueHexTB.Text = string.Format("0x{0:X}", Convert.ToInt32(Register_Value));
            }

            TickCounterTB.Text = Tick_Counter.ToString();

            MinDelayTB.Text = Min_Delay.ToString();
            MaxDelayTB.Text = Max_Delay.ToString();

            TimerPeriodTB.Text = Timer_Period.ToString();
            TimerFrequencyTB.Text = Timer_Frequency.ToString();

            DelayCountTB.Text = Delay_Count.ToString();
            InstructionFrequencyTB.Text = Instruction_Frequency.ToString();
        }

        private void RegisterValueTB_TextChanged(object sender, EventArgs e)
        {
            Calculate(DATA_TYPE.REGISTER_VALUE);
            
        }

        private void TickCounterTB_TextChanged(object sender, EventArgs e)
        {
            Calculate(DATA_TYPE.TICK_COUNTER);
        }

        private void TimerPeriodTB_TextChanged(object sender, EventArgs e)
        {
            Calculate(DATA_TYPE.TIMER_PERIOD);
        }

        private void TimerFrequencyTB_TextChanged(object sender, EventArgs e)
        {
            Calculate(DATA_TYPE.TIMER_FREQUENCY);
        }

        private void InstructionFrequencyTB_TextChanged(object sender, EventArgs e)
        {
            Calculate(DATA_TYPE.INSTRUCTION_FREQUENCY);
        }

        private void MinDelayTB_TextChanged(object sender, EventArgs e)
        {
            Calculate(DATA_TYPE.MIN_DELAY);
        }

        private void MaxDelayTB_TextChanged(object sender, EventArgs e)
        {
            Calculate(DATA_TYPE.MAX_DELAY);
        }

        private void DelayCountTB_TextChanged(object sender, EventArgs e)
        {
            Calculate(DATA_TYPE.DELAY_COUNT);
        }
    }
}
