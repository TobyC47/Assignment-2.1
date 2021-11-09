using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonthlyPaymentCalc;

namespace Assignment_2._1
{
    public partial class MotgageCalculator : Form
    {
        public MotgageCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dInitPrincipal = double.Parse(txtInitPrincipal.Text);
            double dAnnualIntRate = double.Parse(txtAnnualIntRate.Text);
            int iTerm = int.Parse(txtTerm.Text);

            double dMonPayment = Calculate.MonPayment(dInitPrincipal, dAnnualIntRate, iTerm);
            txtMonPayment.Text = dMonPayment.ToString("C2");
        }
    }
}
