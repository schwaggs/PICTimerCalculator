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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            

        }

        private void TimerCalcBT_Click(object sender, EventArgs e)
        {
            Timer tm1 = new Timer();
            tm1.Show();
        }

        private void BaudCalcBT_Click(object sender, EventArgs e)
        {
            BAUD bd1 = new BAUD();
            bd1.Show();
        }
    }
}
