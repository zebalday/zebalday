using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1SebastianAlday {
    public class Empleado : Persona {

        // ATRIBUTOS 

        private string codigo = "";
        private double sueldo_base = 0;


        // CONSTRUCTOR
        protected Empleado() { }
        protected Empleado(string R, string N, string AP, string AM, string D, string T, string C, double SB) : base(R, N, AP, AM, D, T) {
            codigo = C;
            sueldo_base = SB;
        }


        // GETTERS 
        public string getCodigo() { return codigo; }
        public double getSueldoBase() { return sueldo_base; }


        // SETTERS 
        public void setCodigo(string C) { codigo = C; }
        public void setSueldoBase(double SB) { sueldo_base = SB; }
    }
}
