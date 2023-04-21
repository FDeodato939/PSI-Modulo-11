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
    public partial class Step3 : Form
    {
        public static double Plastic;
        public static double Aluminium;
        public static double Copper;
        public static double Waste;
        public static double Equivalent;
        public Step3()
        {
            InitializeComponent();
            Random rnd = new Random();
            int text = rnd.Next(0, 2);
            PlasticLabel.Text = ("" + (int)Plastic + " g");
            AluminiumLabel.Text = ("" + (int)Aluminium + " g");
            CopperLabel.Text = ("" + (int)Copper + " g");
            CollectLabel.Text = ("You collected a total of " + (int)Waste + " kg of e-waste.\nCorrectly recycled, this saves up to " + (int)Equivalent + " kg CO2 equivalent.");
            if (text == 0)
            {
                label1.Text = ("CO2 collected\n equivalent to " + "" + (int)Equivalent / (int)10.6 + " coca cola bottles.");
            }
            else if (text == 1)
            {
                label1.Text = ("CO2 collected \nequivalent to " + "" + (int)Equivalent / (double)0.5 + " 2L coca cola bottles.");
            }
            else if (text == 2)
            {
                label1.Text = ("CO2 collected \nequivalent to " + "" + (int)Equivalent / (int)5000 + " fire extinguishers.");
            }
        }

        private void RyfButton_Click(object sender, EventArgs e)
        {
            var Steps = new Step2();
            Steps.Show();
            this.Hide();
        }
    }
}
