using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Alumno_P1
{
    public class Alumno:Persona
    {
        
        private int legajo;
        private int promedio;
        //:base(parametros originales)
        public Alumno(string n,int d, int l, int p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        //getters
        //declaracion de metodos de cla clase abstracta
        //base para usar 
        public override string getNombre(){ return this.nombre; }
        public override int getDni (){ return this.dni; }
        //getters propios
        public int getLegajo (){ return this.legajo; }
        public int getPromedio(){ return this.promedio; }
        //llenar alumnos
        public void LlenarAlumnos(Coleccionable col)
        {
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {   //random para luego ser convertido a ascii
                //mnayusculas de 65 a 90
                char inicial = (char)r.Next(65, 90);
                //minúsculas entre 97 y 122
                char dos = (char)r.Next(97, 122);
                char tres= (char)r.Next(97, 122);
                char cuatro= (char)r.Next(97, 122);
                //interpolacion de cadenas para formar el nombre
                string nombre = $"{inicial}{ dos}{tres}{cuatro}";
                Console.WriteLine(nombre);
                //random para int
                int id =r.Next(40000000, 50000000);
                int p = r.Next(1, 100);
                Comparable comp = new Alumno(nombre, id , i,p);
                col.agregar(comp);
            }
            
    }
        public override string ToString()
        {
            return $"{nombre} , {dni} , {legajo} , {promedio}";
        }
    }
}
