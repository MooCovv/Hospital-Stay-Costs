using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Stay_Costs
{
    public partial class goBox : Form
    {
        public goBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trollButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You could not afford your stay in the hospital, go directly to jail, do not collect 200 dollors.");
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            double numOfDays = int.Parse(daysTextBox.Text);
            double medicationCost = int.Parse(medicationTextBox.Text);
            double surgicalCost = int.Parse(SurgicalTextBox.Text);
            double labCost = int.Parse(labTextBox.Text);
            double rehabCost = int.Parse(rehabTextBox.Text);

            double totalDayCharges = 0;
            double totalMiscCharges = 0;
            double totalCharges = 0;

            totalDayCharges = ReturnDayCharges(numOfDays);
            totalMiscCharges = CalcMiscCharges(medicationCost, surgicalCost, labCost, rehabCost);

            totalCharges = CalcTotalCharges(totalDayCharges, totalMiscCharges);

            finalOutputBox.Text = totalCharges.ToString();

        }

        private double ReturnDayCharges(double days)
        {
            return days * 350;
        }

        private double CalcMiscCharges(double med, double surg, double lab, double rehab)
        {
            return med + surg + lab + rehab;
        }

        private double CalcTotalCharges(double days, double misc)
        {
            return days + misc;
        }

   

    }
}
