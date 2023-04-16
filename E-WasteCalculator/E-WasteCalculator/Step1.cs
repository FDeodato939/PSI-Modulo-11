using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_WasteCalculator
{
    public partial class Step1 : Form
    {
        public Step1()
        {
            InitializeComponent();
        }

        private void EyfButton_Click(object sender, EventArgs e)
        {
            var Steps = new Step2();
            Steps.Show();
            this.Hide();
        }
    }
}