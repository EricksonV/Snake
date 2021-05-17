using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected Object[] listaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new Object[MAXTAMQ];
        }

        //Operaciones para trabajar con datos en la cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                listaCola[++fin] = elemento;

            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }
        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }
        public bool colaVacia()
        {
            return frente > fin;
        }

        //quitar elemento en la cola
        public Object quitar()
        {
            if (!colaVacia())
            {
                return listaCola[frente++];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacía");
            }
        }
    }
}
