using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Dayana_Erickson.Clases.ManejodeArchivos
{
    class ClsArchivos
    {
        public void GuardaNombres(string nombre, int punteo, int i)
        {
            StreamWriter archivo = new StreamWriter(@"Punteos.txt", true);
            string dificultad;
            if (i == 0) { dificultad = "Fácil"; }
            else if (i == 1) { dificultad = "Difícil"; }
            else { dificultad = "Legendario"; }
            archivo.WriteLine($"{nombre};{punteo};{dificultad}") ;
            archivo.Close();
        }

        public void MuestraNombres()
        {
            StreamReader archivo;
            try
            {
                archivo = new StreamReader(@"Punteos.txt",UTF8Encoding.UTF8);
                string tem = archivo.ReadToEnd();
                string[] temp2 = tem.Split(Environment.NewLine);
                int i = 0;
                string[] nombres = new string[temp2.Length-1];
                int[] punteos = new int[temp2.Length - 1];
                string[] dificultad = new string[temp2.Length - 1];
                foreach (string linea in temp2)
                {
                    string[] CadaEspacio = linea.Split(';');
                    if(CadaEspacio.Length > 1)
                    {
                        nombres[i] = CadaEspacio[0];
                        punteos[i] = int.Parse(CadaEspacio[1]);
                        dificultad[i] = CadaEspacio[2];
                        i++;
                    }
                    
                }

                Console.Clear();
                Console.SetCursorPosition(15, 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TOP 10 JUGADORES CON MÁS PUNTOS");
                Console.SetCursorPosition(0, 3);
                Console.ForegroundColor = ConsoleColor.White;
                ordenamientoBurbuja(nombres, punteos, dificultad);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"No existe el archivo {ex.Message}");
            }

        }
        public void ordenamientoBurbuja(string[] names, int[] puntos, string[] dificulta) {
            int t;
            string[] nombresordenados = new string[names.Length];
            string[] dificultadordenada = new string[dificulta.Length];
            int[] temp = new int[puntos.Length];

            for(int i = 0; i<temp.Length; i++) //guardamos los datos de punteos en un vector temporal
            {
                temp[i] = puntos[i];
            }

            for(int a = 1; a<puntos.Length; a++) //ORDENAMIENTO BURBUJA
            {
                for(int b= puntos.Length-1 ; b >= a; b--)
                {
                    if (puntos[b - 1] < puntos[b])
                    {
                        t = puntos[b - 1];
                        puntos[b - 1] = puntos[b];
                        puntos[b] = t;
                    }
                }
            }

            for(int i =0; i<temp.Length; i++) //ORDENAR LOS NOMBRES Y LA DIFICULTAD
            {
                for(int j = 0; j <puntos.Length; j++)
                {
                    if (temp[i] == puntos[j])
                    {
                        nombresordenados[i] = names[j];
                        dificultadordenada[i] = dificulta[j];
                    }
                }
            }

            for(int i =0;i <9; i++) //MOSTRAR LOS mejores 10 datos
            {
                Console.WriteLine($"{i+1}. Nombre: {nombresordenados[i]}, Puntos: {puntos[i]}, Dificultad: {dificultadordenada[i]}");
            }
            Console.WriteLine("Presione Cualquier tecla");
        }
    }
}
