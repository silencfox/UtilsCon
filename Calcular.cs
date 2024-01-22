using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilesCon
{
    class Calcular
    {
        private int _ival1;
        private int _ival2;
        private double _dval1;
        private double _dval2;

        public int Ival1 { get => _ival1; set => _ival1 = value; }
        public int Ival2 { get => _ival2; set => _ival2 = value; }
        public double Dval1 { get => _dval1; set => _dval1 = value; }
        public double Dval2 { get => _dval2; set => _dval2 = value; }

        public Calcular() {
        
        
        }
        public int Suma(int ival1, int ival2) => ival1 + ival2;
        public int restar(int ival1, int ival2)=> ival1 - ival2;
        public int multiplicar(int ival1, int ival2) => ival1 * ival2;
        public double dividir(double dval1, double dval2)=> dval1 / dval2;


    }
}
