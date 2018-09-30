using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcolatriceLibrary
{
    public class Calculator:ICalc
    {
        private double _num1;
        public double Num1
        {
            get { return _num1; }
            set { _num1 = value; }
        }

        private double _num2;
        public double Num2
        {
            get { return _num2; }
            set { _num2 = value; }
        }

        private double _ris;
        public double Ris
        {
            get { return _ris; }
            set { _ris = value; }
        }

        public Calculator()
        {

        }
        public void Addizione()
        {
            Ris = Num1 + Num2;
        }
        public void Sottrazione()
        {
            Ris = Num1 - Num2;
        }
        public void Moltiplicazione()
        {
            Ris = Num1 * Num2;
        }
        public void Divisione()
        {
            if(Num2!=0)
                Ris = Num1 / Num2;
            else
                Ris = 999999999;
        }
    }
}
