using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Alumno_P1
{
    public class Pila:Coleccionable
    {
        private List<Comparable> stack;
        //constructor
        public Pila()
        {
            this.stack = new List<Comparable>();
        }
        //apilar
        public void apilar(Comparable c)
        {
            this.stack.Add(c);
        }
        //desapilar
        public Comparable desapilar()
        {
            //guardar ultimo elemento
            Comparable ultimo = stack[stack.Count() - 1];
            //eliminar ultimo
            stack.RemoveAt(stack.Count() - 1);
            return ultimo;
        }

        public int cuantos()
        {
            return this.stack.Count;
        }
        //metodo para revisar el queue
        public Comparable obtenerElemento(int indice)
        {
            return stack[indice];
        }
        public Comparable minimo()
        {
            Comparable min = obtenerElemento(0);

            for (int i = 0; i < cuantos(); i++)
            {
                //si el elemento actual es menor que min
                if (obtenerElemento(i).sosMenor(min))
                {
                    min = obtenerElemento(i);
                }
            }
            return min;
        }

        public Comparable maximo()
        {
            Comparable max = obtenerElemento(0);

            for (int i = 0; i < cuantos(); i++)
            {
                //si el elemento actual es mayor que max
                if (obtenerElemento(i).sosMayor(max))
                {
                    max = obtenerElemento(i);
                }
            }
            return max;
        }
        //agregar comparable
        public void agregar(Comparable c)
        {
            stack.Add(c);
            //Console.WriteLine("Elemento agregado: " + ((Numero)c).getValor());
        }
        //contiene comparable?

        public bool contiene(Comparable c)
        {
            foreach (Comparable item in stack)
            {
                if (item.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
        


    }
}
