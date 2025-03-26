using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Alumno_P1
{
    public class Cola: Coleccionable
    {
        protected List<Comparable>queue;
        //constructor
        public Cola()
        {
            this.queue = new List<Comparable>();
        }
        //encolar
        public void encolar(Comparable c)
        {
            this.queue.Add(c);
        }
        //desapilar
        public Comparable desapilar()
        {
            //guardar primer elemento
            Comparable primero = queue[0];
            //eliminar primero
            this.queue.RemoveAt(0);
            return primero;
        }
        public int cuantos(){
            return queue.Count;
        }
        //metodo para revisar el queue
        public Comparable obtenerElemento(int indice)
        {
            return queue[indice];
        }
        public Comparable minimo(){
            Comparable min = obtenerElemento(0);

            for (int i = 0; i <cuantos(); i++)
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
            queue.Add(c);
            //Console.WriteLine("Elemento agregado: " + ((Numero)c).getValor());
        }
        //contiene comparable?
        public bool contiene(Comparable c)
        {
            foreach (Comparable item in queue)
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
