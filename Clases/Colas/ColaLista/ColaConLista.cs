using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.ColaLista
{
    class ColaConLista
    {
        protected Nodo frente;
        protected Nodo fin;

        //constructor: crear cola vacia
        public ColaConLista()
        {
            frente = fin = null;
        }

        //verificar si la cola est´vacia
        public bool colaVacia()
        {
            return (frente == null);
        }

        //inseratr: pone elemento por el final de la cola
        public void insertar(object elemento)
        {
            Nodo a;
            a = new Nodo(elemento);
            if (colaVacia())
            {
                frente = a;
            }
            else
            {
                fin.Siguiente = a;
            }
            fin = a;
        }

        //quitar un elemento
        public object quitar()
        {
            object aux;
            if (!colaVacia())
            {
                aux = frente.elemento;
                frente = frente.Siguiente;
            }
            else
            {
                throw new Exception("Error porqué la cola está vacía");
            }
            return aux;
        }

        //vaciar la cola o liberar todos los nodos
        public void borrarCola()
        {
            for(;frente != null;)
            {
                frente = frente.Siguiente;
            }
        }

        //devolver el valor que está al frente de la cola
        public object frenteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error la cola está vacía");
            }
            return (frente.elemento);
        }

    }
}
