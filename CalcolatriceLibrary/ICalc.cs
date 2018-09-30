using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcolatriceLibrary
{
    public interface ICalc
    {
        double Ris { get; }
        double Num1 { get; set; }
        double Num2 { get; set; }
        void Addizione();
        void Sottrazione();
        void Moltiplicazione();
        void Divisione();
    }
}
