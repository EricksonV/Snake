using Colas.Clases.BicolaEnlazada;
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
            List<ClsJugadores> jugadores = new List<ClsJugadores>();
            for(int i = 0; i<puntos.Length; i++) //guardamos los datos de punteos en un vector temporal
            {
                jugadores.Add(new ClsJugadores() {
                    Nombre = names[i], Punteo = puntos[i], Dificultad = dificulta[i] });
            }

            List<ClsJugadores> jugadoresordenados = jugadores.OrderBy(x => x).ToList();

            int cont = 0;
            foreach(ClsJugadores ss in jugadoresordenados)
            {
                if (cont < 4)
                {
                    Console.WriteLine(ss);
                }
            }
        }
    }
}
