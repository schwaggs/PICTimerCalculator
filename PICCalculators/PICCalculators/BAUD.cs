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
    public partial class BAUD : Form
    {
        public BAUD()
        {
            InitializeComponent();
        }

        private void BAUD_Load(object sender, EventArgs e)
        {

        }

        private void CalculateBT_Click(object sender, EventArgs e)
        {
            CheckInputs();

            if (BAUDData._Calculate)
            {
                GetUserData();
                BAUDData.Calculate_BAUD();
                PopulateCalculated();
                CalculatedP.Visible = true;
            }

            else
            {
                CalculatedP.Visible = false;
                HighlightBlankFields();
                MessageBox.Show("Please Enter All Required Information Before Proceeding.");
            }        
        }

        private void FOSCTB_TextChanged(object sender, EventArgs e)
        {
            FOSCTBP.BackColor = Color.White;
            CheckInputs();
        }

        private void FOSCCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FOSCCBP.BackColor = Color.White;
            CheckInputs();
        }

        private void DesiredBAUDTB_TextChanged(object sender, EventArgs e)
        {
            DesiredBAUDP.BackColor = Color.White;
            CheckInputs();
        }

        private void CONFTB_TextChanged(object sender, EventArgs e)
        {
            CONFP.BackColor = Color.White;
            CheckInputs();
        }

        private void CheckInputs()
        {
            BAUDData._Calculate = true;

            if (string.IsNullOrEmpty(FOSCTB.Text) || string.IsNullOrWhiteSpace(FOSCTB.Text))
            {
                BAUDData._Calculate = false;
                CalculatedP.Visible = false;
                return;
                
            }

            if (string.IsNullOrEmpty(CONFTB.Text) || string.IsNullOrWhiteSpace(CONFTB.Text))
            {
                BAUDData._Calculate = false;
                CalculatedP.Visible = false;
                return;
            }

            if (string.IsNullOrEmpty(DesiredBAUDTB.Text) || string.IsNullOrWhiteSpace(DesiredBAUDTB.Text))
            {
                BAUDData._Calculate = false;
                CalculatedP.Visible = false;
                return;
            }

            if (FOSCCB.SelectedIndex == -1)
            {
                ProgramData.Generate = false;
                CalculatedP.Visible = false;
                return;
            }
        }

        private void HighlightBlankFields()
        {
            if (FOSCTB.Text == "")
            {
                FOSCTBP.BackColor = Color.Red;
            }

            if (FOSCCB.SelectedIndex == -1)
            {
                FOSCCBP.BackColor = Color.Red;
            }

            if (CONFTB.Text == "")
            {
                CONFP.BackColor = Color.Red;
            }

            if (DesiredBAUDTB.Text == "")
            {
                DesiredBAUDP.BackColor = Color.Red;
            }
        }

        private void GetUserData()
        {
            decimal temp = 0;

            if (decimal.TryParse(FOSCTB.Text, out temp))
            {
                switch (FOSCCB.SelectedIndex)
                {
                    case 0:
                        BAUDData.FOSC = temp;
                        break;

                    case 1:
                        BAUDData.FOSC = temp * ProgramData.kilo;
                        break;


                    case 2:
                        BAUDData.FOSC = temp * ProgramData.mega;
                        break;

                    case 3:
                        BAUDData.FOSC = temp * ProgramData.giga;
                        break;

                    case 4:
                        BAUDData.FOSC = temp * ProgramData.tera;
                        break;

                    case 5:
                        BAUDData.FOSC = temp * ProgramData.peta;
                        break;
                }
            }

            else
            {
                MessageBox.Show("Illegal Value For FOSC");
                FOSCTBP.BackColor = Color.Red;
                return;
            }

            if (decimal.TryParse(CONFTB.Text, out temp))
            {
                BAUDData.CONF = temp;
            }

            else
            {
                MessageBox.Show("Illegal Value For CONF");
                CONFP.BackColor = Color.Red;
                return;
            }

            if (decimal.TryParse(DesiredBAUDTB.Text, out temp))
            {
                BAUDData.Desired_BAUD = temp;
            }

            else
            {
                MessageBox.Show("Illegal Value For Desired BAUD");
                DesiredBAUDP.BackColor = Color.Red;
                return;
            }
        }

        private void PopulateCalculated()
        {
            SPBRGTB.Text = BAUDData.SPBRG.ToString();
            ErrorTB.Text = BAUDData.Error.ToString();
            ActualBAUDTB.Text = BAUDData.Actual_BAUD.ToString();
        }
    }
}
