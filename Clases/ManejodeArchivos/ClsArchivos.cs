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
        public void GuardaNombres(string nombre, string punteo)
        {
            StreamWriter archivo = new StreamWriter(@"Punteos.txt", true);
            archivo.WriteLine(nombre + ";" + punteo);
            archivo.Close();
        }

        public void MuestraNombres()
        {
            StreamReader archivo;
            string[] devuelta = null;
            try
            {
                archivo = new StreamReader(@"Punteos.txt");
                string tem = archivo.ReadToEnd();
                string[] temp2 = tem.Split(Environment.NewLine);
                int i = 0;
                foreach (string linea in temp2)
                {
                    string[] CadaEspacio = linea.Split(';');
                    devuelta[i] = $"Nombre: {CadaEspacio[0]}\nPuntos: {CadaEspacio[1]}";
                    i++;
                }

                var MayoresPunteos = devuelta.OrderByDescending(x => x).Take(10);

                foreach(string linea in MayoresPunteos)
                {
                    Console.WriteLine(linea);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"No existe el archivo {ex.Message}");
            }
        }
    }
}
