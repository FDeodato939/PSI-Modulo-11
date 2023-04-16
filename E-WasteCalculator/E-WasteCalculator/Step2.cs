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
    public partial class Step2 : Form
    {
        public Step2()
        {
            InitializeComponent();
        }

        private void KaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 16) + (16 * (double)KaNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 3) + (3 * (double)KaNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 8) + (8 * (double)KaNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 1.61) + (1.61 * (double)KaNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 1.78) + (1.78 * (double)KaNumericUpDown.Value);
        }

        private void HvNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 133) + (133 * (double)HvNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 350) + (350 * (double)HvNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 7) + (7 * (double)HvNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 7) + (7 * (double)HvNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 7.74) + (7.74 * (double)HvNumericUpDown.Value);
        }

        private void mNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 1904) + (1904 * (double)mNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 612) + (612 * (double)mNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 1278) + (1278 * (double)mNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 13.6) + (13.6 * (double)mNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 15.03) + (15.03 * (double)mNumericUpDown.Value);
        }

        private void VcNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 2418) + (2418 * (double)VcNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 365) + (365 * (double)VcNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 49) + (49 * (double)VcNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 4.05) + (4.05 * (double)VcNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 4.48) + (4.48 * (double)VcNumericUpDown.Value);
        }

        private void PcNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 174) + (174 * (double)PcNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 21) + (21 * (double)PcNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 44) + (44 * (double)PcNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 0.4) + (0.4 * (double)PcNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 0.44) + (0.44 * (double)PcNumericUpDown.Value);
        }

        private void oNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 1484) + (1484 * (double)oNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 133) + (133 * (double)oNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 7) + (7 * (double)oNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 7.74) + (7.74 * (double)oNumericUpDown.Value);
        }

        private void CrtNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 4428) + (4428 * (double)CrtNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 18) + (18 * (double)CrtNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 63) + (63 * (double)CrtNumericUpDown.Value);
        }

        private void LcdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 6237) + (6237 * (double)LcdNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 18) + (18 * (double)LcdNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 326) + (326 * (double)LcdNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 18.13) + (18.13 * (double)LcdNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 20.04) + (20.04 * (double)LcdNumericUpDown.Value);
        }

        private void dNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 10714) + (10714 * (double)dNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 101) + (101 * (double)dNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 404) + (404 * (double)dNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 50.54) + (50.54 * (double)dNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 154) + (154 * (double)dNumericUpDown.Value);
        }

        private void WmNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 10709) + (10709 * (double)WmNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 2168) + (2168 * (double)WmNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 920) + (920 * (double)WmNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 65.7) + (65.7 * (double)WmNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 156) + (156 * (double)WmNumericUpDown.Value);
        }

        private void CdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 19710) + (19710 * (double)CdNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 2431) + (2431 * (double)CdNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 3285) + (3285 * (double)CdNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 65.7) + (65.7 * (double)CdNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 156) + (156 * (double)CdNumericUpDown.Value);
        }

        private void fridgeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 13275) + (13275 * (double)fridgeNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 945) + (945 * (double)fridgeNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 765) + (765 * (double)fridgeNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 45) + (45 * (double)fridgeNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 51) + (51 * (double)fridgeNumericUpDown.Value);
        }

        private void freezerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 11970) + (11970 * (double)freezerNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 1890) + (1890 * (double)freezerNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 765) + (765 * (double)freezerNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 45) + (45 * (double)freezerNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 51) + (51 * (double)freezerNumericUpDown.Value);
        }

        private void AcNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 6922) + (6922 * (double)AcNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 2025) + (2025 * (double)AcNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 8285) + (8285 * (double)AcNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 36.82) + (36.82 * (double)AcNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 68) + (68 * (double)AcNumericUpDown.Value);
        }

        private void WbNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 13001) + (13001 * (double)WbNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 691) + (691 * (double)WbNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 401) + (401 * (double)WbNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 22.3) + (22.3 * (double)WbNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 24.65) + (24.65 * (double)WbNumericUpDown.Value);
        }

        private void FtNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 2) + (2 * (double)FtNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 0.14) + (0.14 * (double)FtNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 0.01) + (0.01 * (double)FtNumericUpDown.Value);
        }

        private void LbNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Aluminium = (Step3.Aluminium / 1) + (1 * (double)LbNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 3) + (3 * (double)LbNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 0.015) + (0.015 * (double)LbNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 0.073) + (0.073 * (double)LbNumericUpDown.Value);
        }

        private void NbNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 1) + (1 * (double)NbNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 0.023) + (0.023 * (double)NbNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 0.107) + (0.107 * (double)NbNumericUpDown.Value);
        }

        private void aNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Waste = (Step3.Waste / 0.023) + (0.023 * (double)aNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 0.107) + (0.107 * (double)aNumericUpDown.Value);
        }

        private void MpNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 59) + (59 * (double)MpNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 3) + (3 * (double)MpNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 13) + (13 * (double)MpNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 0.13) + (0.13 * (double)MpNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 0.14) + (0.14 * (double)MpNumericUpDown.Value);
        }

        private void LtNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 1140) + (1140 * (double)LtNumericUpDown.Value);
            Step3.Aluminium = (Step3.Aluminium / 682) + (682 * (double)LtNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 122) + (122 * (double)LtNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 2.9) + (2.9 * (double)LtNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 3.21) + (3.21 * (double)LtNumericUpDown.Value);
        }

        private void pNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 3666) + (3666 * (double)pNumericUpDown.Value);
            Step3.Copper = (Step3.Copper / 126) + (126 * (double)pNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 6) + (6 * (double)pNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 15.69) + (15.69 * (double)pNumericUpDown.Value);
        }

        private void rNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 580) + (580 * (double)rNumericUpDown.Value);
            Step3.Waste = (Step3.Waste / 2.05) + (2.05 * (double)rNumericUpDown.Value);
            Step3.Equivalent = (Step3.Equivalent / 2.27) + (2.27 * (double)rNumericUpDown.Value);
        }

        private void oNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Step3.Plastic = (Step3.Plastic / 63) + (63 * (double)oNumericUpDown2.Value);
            Step3.Aluminium = (Step3.Aluminium / 3) + (3 * (double)oNumericUpDown2.Value);
            Step3.Copper = (Step3.Copper / 14) + (14 * (double)oNumericUpDown2.Value);
            Step3.Waste = (Step3.Waste / 0.14) + (0.14 * (double)oNumericUpDown2.Value);
            Step3.Equivalent = (Step3.Equivalent / 0.16) + (0.16 * (double)oNumericUpDown2.Value);
        }

        private void GyrButton_Click(object sender, EventArgs e)
        {
            var Steps = new Step3();
            Steps.Show();
            this.Hide();
        }
    }
}