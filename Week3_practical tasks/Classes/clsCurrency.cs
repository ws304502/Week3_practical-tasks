using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_practical_tasks.Classes
{
    public class clsCurrency
    {
        private double m_dEuro = 0.89;
        private double m_dSterling = 1;
        private double m_dDollar = 0.72;

        public double GetSterling()
        {
            return m_dSterling;
        }

        public double GetEuro()
        {
            return m_dEuro;
        }

        public double GetDollar()
        {
            return m_dDollar;
        }

        public void SetSterling(double dSterling)
        {
            m_dSterling = dSterling;
        }

        public void SetEuro(double dEuro)
        {
            m_dEuro = dEuro;
        }

        public void SetDollar(double dDollar)
        {
            m_dDollar = dDollar;
        }
    }
}
