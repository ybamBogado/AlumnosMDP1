using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_Alumno_P1
{
    public class ColeccionMultiple:Coleccionable
    {
        Pila stack = new Pila();
        Cola queue = new Cola();
        public ColeccionMultiple(Pila stack, Cola queue)
        {
            this.stack = stack;
            this.queue = queue;
        }
        //implementar
        //cuantos entere ambos
        public int cuantos() {
            int q = queue.cuantos();
            int s = stack.cuantos();
            return q + s;
                }
        //minimo entere ambos
        public Comparable minimo()
        {
            Comparable q = queue.minimo();
            Comparable s = stack.minimo();
            if (q.sosMenor(s))
            {
                return q;
            }
            else
            {
                return s;
            }
        }
        //maximo entere ambos
        public Comparable maximo()
        {
            Comparable q = queue.maximo();
            Comparable s = stack.maximo();
            if (q.sosMayor(s))
            {
                return q;
            }
            else
            {
                return s;
            }
        }

        //agregar no hace
        public void agregar(Comparable c)
        {        }
        //contiene true si esta en alguna de las 2
        public bool contiene(Comparable c)
        {
            if(queue.contiene(c)|| stack.contiene(c)){
                return true;
            }
            return false;
        }
    }
}
