﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
        public bool any(Point x)
        {
            int cont = 0;
            bool flag;
            Point a;
            Nodo aux = frente; //Se guardan los datos en un nodo auxiliar
            while (aux != null)
            {
                
                a = (Point)aux.elemento; //se convierte el elemento a tipo Point
                flag = ((a.X != x.X) && (a.Y != x.Y)); //compara que la posicion sea distinta a la que ocupa la serpiente
                int z = (flag == true ? cont+0 : cont++); //comparación que no hayan datos repetidos
                aux = aux.Siguiente; //avanza al siguiente nodo
            }

            return (cont == 0) ? true : false;
        }

        public bool all(int x, int y)
        {
            int cont = 0;
            bool flag;
            Point a;
            Nodo aux = frente; //Se guardan los datos en un nodo auxiliar
            while (aux != null)
            {

                a = (Point)aux.elemento; //se convierte el elemento a tipo Point
                flag = (a.X != x || a.Y != y);
                int z = (flag == true ? cont + 0 : cont++); //comparación que no hayan datos repetidos
                aux = aux.Siguiente; //avanza al siguiente nodo
            }

            return (cont == 0) ? true : false;
        }


    }
}
