using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyPaymentCalc
{
    public class Calculate
    {
        public static double MonPayment(double dInitPrincipal, double dAnnualIntRate, int iTerm)
        {
            double dMonPayment = 0;
            int iTermMonths = iTerm * 12;
            double dMonthlyIntRate = (dAnnualIntRate / 100) / 12;
            double dPower = Math.Pow(dMonthlyIntRate + 1, iTermMonths);

            dMonPayment = ((dMonthlyIntRate * dPower) / (dPower - 1)) * dInitPrincipal;

            return dMonPayment;
        }
    }
}
