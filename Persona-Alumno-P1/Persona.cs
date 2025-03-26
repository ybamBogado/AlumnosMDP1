using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Alumno_P1
{
    abstract public class Persona : Comparable {
        protected string nombre;
        protected int dni;
        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;

        }
        public abstract string getNombre();
        public abstract int getDni();

        //IMPLEMENTACION COMPARABLE 
        //comparo por dni
        //public bool sosIgual(Comparable c)
        //{
        //    return this.dni == ((Persona)c).getDni();
        //}
        public bool sosIgual(Comparable c)
        {
            Persona otraPersona = (Persona)c;
            //depuracion pra ver busqueda
            //Console.WriteLine($"Comparando DNI {this.dni} con {otraPersona.getDni()}");
            return this.dni == otraPersona.getDni();
        }
        public bool sosMenor(Comparable c)
        {
            return this.dni < ((Persona)c).getDni();
        }
        public bool sosMayor(Comparable c)
        {
            return this.dni > ((Persona)c).getDni();
        }
        //sobreescritura to string
        public override string ToString()
        {
            return $"{nombre} , {dni}";
        }
    }
}
