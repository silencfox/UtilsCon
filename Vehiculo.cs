using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilesCon
{
    internal class Vehiculo
    {
        private int _puertas;
        private string _traccion;
        private string _tipo;
        private int _pasajeros;


        public int Puertas { get => _puertas; set => _puertas = value; }
        public string Traccion { get => _traccion; set => _traccion = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public int Pasajeros { get => _pasajeros; set => _pasajeros = value; }

        public void carro() {
        
        }

        public void camion() {
        
        }

        public void camioneta() {
        
        }

        public void jeep() { 
        
        }

    }
}
