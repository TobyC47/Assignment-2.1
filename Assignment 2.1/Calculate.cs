using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    class Calculate
    {
        public static double MonPayment(double dInitPrincipal, double dAnnualIntRate, int iTerm)
        {
            double dMonPayment = 0;
            int iTermMonths = iTerm * 12;
            double dMonthlyIntRate = (dAnnualIntRate / 100) / 12;
            double dPower = (dMonthlyIntRate) + 1;
            double dStartingMonthlyRate = (dMonthlyIntRate) + 1;


            for (int iMonth = 1; iMonth <= iTermMonths; iMonth++)
            {
                dPower = dPower * dStartingMonthlyRate;
            }

            dMonPayment = ((dMonthlyIntRate * dPower) / (dPower - 1)) * dInitPrincipal;

            return dMonPayment;
        }
    }
}
