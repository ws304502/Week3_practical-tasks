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

        public double Euro 
        {
            get { return m_dEuro; }
            set { m_dEuro = value; }
        }

        public double Sterling 
        {
            get { return m_dSterling; }
            set { m_dSterling = value; }
        }

        public double Dollar 
        {
            get { return m_dDollar; }
            set { m_dDollar = value; }
        }

        //public double GetSterling()
        //{
        //    return m_dSterling;
        //}

        //public double GetEuro()
        //{
        //    return m_dEuro;
        //}

        //public double GetDollar()
        //{
        //    return m_dDollar;
        //}

        //public void SetSterling(double dSterling)
        //{
        //    m_dSterling = dSterling;
        //}

        //public void SetEuro(double dEuro)
        //{
        //    m_dEuro = dEuro;
        //}

        //public void SetDollar(double dDollar)
        //{
        //    m_dDollar = dDollar;
        //}
    }
}
