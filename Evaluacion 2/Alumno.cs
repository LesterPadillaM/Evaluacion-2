using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2
{
    class Alumno
    {
        public string Nombre { get; set; }
        public long Cuenta { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }

        public Alumno(){}
        public Alumno(string _nombre, long _cuenta) 
        {
            Nombre = _nombre;
            Cuenta = _cuenta;
        }
        public Alumno(string _nombre,long _cuenta, int _nota1, int _nota2, int _nota3, int _nota4)
        {
            Nombre = _nombre;
            Cuenta = _cuenta;
            Nota1 = _nota1;
            Nota2 = _nota2;
            Nota3 = _nota3;
            Nota4 = _nota4;
        }
        
        public int DevolverPromedio()
        {
            return (Nota1+Nota2+Nota3+Nota4)/4;
        }
        public string AproboOReprobo()
        {
            int Promedio = DevolverPromedio();
            if (Promedio >= 70)
            {
                return ("Aprobo");
            }
            else
            {
                return "Reprobo";
            }
        }
    }
}
