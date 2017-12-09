using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICCalculators
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();

            
        }

        private void foscTB_TextChanged(object sender, EventArgs e)
        {
            FOSCTBP.BackColor = Color.White;
            CheckInputs();
        }

        private void ddTB_TextChanged(object sender, EventArgs e)
        {
            DesiredDelayTBP.BackColor = Color.White;
            CheckInputs();
        }

        private void PrescalerTB_TextChanged(object sender, EventArgs e)
        {
            PrescalerTBP.BackColor = Color.White;
            CheckInputs();
        }

        private void RegisterSizeTB_TextChanged(object sender, EventArgs e)
        {
            RegisterSizeTBP.BackColor = Color.White;
            CheckInputs();
        }

        private void foscCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            FOSCCBP.BackColor = Color.White;
            CheckInputs();
        }

        private void ddCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesiredDelayCBP.BackColor = Color.White;
            CheckInputs();
        }

        private void RegisterSizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegisterSizeCBP.BackColor = Color.White;
            CheckInputs();
        }

        private void InternalClockCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InternalClockCBP.BackColor = Color.White;
            CheckInputs();
        }

        private void GenerateBT_Click(object sender, EventArgs e)
        {
            CalculatedP.Visible = false;
            HideCalculatedPBT.Visible = false;

            decimal temp;

            if (ProgramData.Generate)
            {
                if (decimal.TryParse(FOSCTB.Text, out temp))
                {
                    switch (foscCB.SelectedIndex)
                    {
                        case 0:
                            UserData.FOSC = temp;
                            break;

                        case 1:
                            UserData.FOSC = temp * ProgramData.kilo;
                            break;


                        case 2:
                            UserData.FOSC = temp * ProgramData.mega;
                            break;

                        case 3:
                            UserData.FOSC = temp * ProgramData.giga;
                            break;

                        case 4:
                            UserData.FOSC = temp * ProgramData.tera;
                            break;

                        case 5:
                            UserData.FOSC = temp * ProgramData.peta;
                            break;
                    }
                }

                else
                {
                    MessageBox.Show("Illegal Value For FOSC");
                    FOSCTBP.BackColor = Color.Red;
                    return;
                }
                if (decimal.TryParse(PrescalerTB.Text, out temp))
                {
                    UserData.Prescaler = temp;
                }

                else
                {
                    MessageBox.Show("Illegal Value For Prescaler");
                    PrescalerTBP.BackColor = Color.Red;
                    return;
                }

                if (decimal.TryParse(DesiredDelayTB.Text, out temp))
                {
                    switch (DesiredDelayCB.SelectedIndex)
                    {
                        case 0:
                            UserData.Desired_Delay = Convert.ToDecimal(temp);
                            break;

                        case 1:
                            UserData.Desired_Delay = Convert.ToDecimal(temp * ProgramData.milli);
                            break;


                        case 2:
                            UserData.Desired_Delay = Convert.ToDecimal(temp * ProgramData.micro);
                            break;

                        case 3:
                            UserData.Desired_Delay = Convert.ToDecimal(temp * ProgramData.nano);
                            break;

                        case 4:
                            UserData.Desired_Delay = Convert.ToDecimal(temp * ProgramData.pico);
                            break;
                    }
                }

                else
                {
                    MessageBox.Show("Illegal Value For Desired Delay");
                    DesiredDelayTBP.BackColor = Color.Red;
                    return;
                }

                if (decimal.TryParse(RegisterSizeTB.Text, out temp))
                {
                    switch (RegisterSizeCB.SelectedIndex)
                    {
                        case 0:
                            UserData.Register_Size = Convert.ToDecimal(temp);
                            break;

                        case 1:
                            UserData.Register_Size = Convert.ToDecimal(temp * 4);
                            break;


                        case 2:
                            UserData.Register_Size = Convert.ToDecimal(temp * 8);
                            break;

                        case 3:
                            UserData.Register_Size = Convert.ToDecimal(temp * ProgramData.kilo);
                            break;

                        case 4:
                            UserData.Register_Size = Convert.ToDecimal(temp * ProgramData.mega);
                            break;

                        case 5:
                            UserData.Register_Size = Convert.ToDecimal(temp * ProgramData.giga);
                            break;

                        case 6:
                            UserData.Register_Size = Convert.ToDecimal(temp * ProgramData.tera);
                            break;

                        case 7:
                            UserData.Register_Size = Convert.ToDecimal(temp * ProgramData.peta);
                            break;
                    }
                }

                else
                {
                    MessageBox.Show("Illegal Value For Register Size");
                    RegisterSizeTBP.BackColor = Color.Red;
                    return;
                }

                switch (InternalClockCB.SelectedIndex)
                {
                    case 0:
                        UserData.Clock_Divider = 1;
                        break;

                    case 1:
                        UserData.Clock_Divider = 2;
                        break;

                    case 2:
                        UserData.Clock_Divider = 4;
                        break;
                }

                ProgramMethods.Generate();

                PopulateCalculations();

                CalculatedP.Visible = true;
                HideCalculatedPBT.BackgroundImage = Properties.Resources.Collapse;
                HideCalculatedPBT.Visible = true;
            }

            else
            {
                MessageBox.Show("Please Enter All Required Information Before Proceeding.");

                HighlightBlankFields();
            }
        }

        private void FormulasBT_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckInputs()
        {
            ProgramData.Generate = true;

            if (string.IsNullOrEmpty(FOSCTB.Text) || string.IsNullOrWhiteSpace(FOSCTB.Text))
            {
                ProgramData.Generate = false;
            }

            if (string.IsNullOrEmpty(PrescalerTB.Text) || string.IsNullOrWhiteSpace(PrescalerTB.Text))
            {
                ProgramData.Generate = false;
            }

            if (string.IsNullOrEmpty(DesiredDelayTB.Text) || string.IsNullOrWhiteSpace(DesiredDelayTB.Text))
            {
                ProgramData.Generate = false;
            }

            if (string.IsNullOrEmpty(RegisterSizeTB.Text) || string.IsNullOrWhiteSpace(RegisterSizeTB.Text))
            {
                ProgramData.Generate = false;
            }

            if (foscCB.SelectedIndex == -1)
            {
                ProgramData.Generate = false;
            }

            if (DesiredDelayCB.SelectedIndex == -1)
            {
                ProgramData.Generate = false;
            }

            if (RegisterSizeCB.SelectedIndex == -1)
            {
                ProgramData.Generate = false;
            }

            if (InternalClockCB.SelectedIndex == -1)
            {
                ProgramData.Generate = false;
            }
        }

        private void HighlightBlankFields()
        {
            if (FOSCTB.Text == "")
            {
                FOSCTBP.BackColor = Color.Red;
            }

            if (foscCB.SelectedIndex == -1)
            {
                FOSCCBP.BackColor = Color.Red;
            }

            if (PrescalerTB.Text == "")
            {
                PrescalerTBP.BackColor = Color.Red;
            }

            if (DesiredDelayTB.Text == "")
            {
                DesiredDelayTBP.BackColor = Color.Red;
            }

            if (DesiredDelayCB.SelectedIndex == -1)
            {
                DesiredDelayCBP.BackColor = Color.Red;
            }

            if (RegisterSizeTB.Text == "")
            {
                RegisterSizeTBP.BackColor = Color.Red;
            }

            if (RegisterSizeCB.SelectedIndex == -1)
            {
                RegisterSizeCBP.BackColor = Color.Red;
            }

            if (InternalClockCB.SelectedIndex == -1)
            {
                InternalClockCBP.BackColor = Color.Red;
            }
        }

        private void PopulateCalculations()
        {
            InstructionFrequencyTB.Text = ProgramData.Instruction_Frequency.ToString();
            MinDelayTB.Text = ProgramData.Min_Delay.ToString();
            MaxDelayTB.Text = ProgramData.Max_Delay.ToString();
            TimerFrequencyTB.Text = ProgramData.Timer_Frequency.ToString();
            TimerPeriodTB.Text = ProgramData.Timer_Period.ToString();
            DelayCountTB.Text = ProgramData.Delay_Count.ToString();
            RegisterValueTB.Text = ProgramData.Register_Value.ToString();

            if (ProgramData.Register_Value < 0)
            {
                RegisterValueTB.ForeColor = Color.Red;
            }
            else
            {
                RegisterValueTB.ForeColor = Color.Black;
            }
            
            TickCounterTB.Text = ProgramData.Tick_Counter.ToString();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Color GroupBoxBackground = Color.Transparent;
            Color TextBoxBackground = Color.White;

            RegisterValueGB.BackColor = GroupBoxBackground;
            RegisterValueTB.BackColor = TextBoxBackground;

            TickCounterGB.BackColor = GroupBoxBackground;
            TickCounterTB.BackColor = TextBoxBackground;

            MinDelayGB.BackColor = GroupBoxBackground;
            MinDelayTB.BackColor = TextBoxBackground;

            MaxDelayGB.BackColor = GroupBoxBackground;
            MaxDelayTB.BackColor = TextBoxBackground;

            TimerPeriodGB.BackColor = GroupBoxBackground;
            TimerPeriodTB.BackColor = TextBoxBackground;

            TimerFrequencyGB.BackColor = GroupBoxBackground;
            TimerFrequencyTB.BackColor = TextBoxBackground;

            DelayCountGB.BackColor = GroupBoxBackground;
            DelayCountTB.BackColor = TextBoxBackground;

            InstructionFrequencyGB.BackColor = GroupBoxBackground;
            InstructionFrequencyTB.BackColor = TextBoxBackground;
        }

        private void HideCalculatedPBT_Click(object sender, EventArgs e)
        {
            if (CalculatedP.Visible)
            {
                CalculatedP.Visible = false;
                HideCalculatedPBT.BackgroundImage = Properties.Resources.Expand;
            }

            else
            {
                CalculatedP.Visible = true;
                HideCalculatedPBT.BackgroundImage = Properties.Resources.Collapse;
            }
        }

        private void ManualModeBT_Click(object sender, EventArgs e)
        {
            ManualTimer MT = new ManualTimer();
            MT.ShowDialog();
        }
    }
}
