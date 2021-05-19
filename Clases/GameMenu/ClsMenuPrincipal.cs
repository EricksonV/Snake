using Snake_Dayana_Erickson.Clases.GameSnake;
using Snake_Dayana_Erickson.Clases.ManejodeArchivos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Dayana_Erickson.Clases.GameMenu
{
    class ClsMenuPrincipal
    {
        public void menuPrincipal()
        {
            bool end = false;
            Size size = new Size(60, 20);
            new clsGame().DibujaPantalla(size);
            do
            {
                int op1 = seleccion(1,2);
                switch (op1)
                {
                    case 0:
                        int op2 = seleccion(2, 2);
                        SwitchMenu2(op2);
                        break;
                    case 1:
                        MuestraTabla();
                        Console.ReadKey();
                        break;
                    case 2:
                        end = true;
                        break;
                }
                
                //Juega(op2);
            } while (end == false);


        }//end menú principal
        public int seleccion(int opc, int tam)
        {
            bool flag = false;
            int i = 0;
            while (flag != true)
            {
                i = (i == tam+1) ? 0 : i;
                i = (i == -1) ? tam : i;
                if (opc == 1) { Console.Clear(); menu1(i); }
                if (opc == 2) { Console.Clear(); menu2(i); }
                if (opc == 3){ Console.Clear(); menu3(i); }


                var tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        i--;
                        break;
                    case ConsoleKey.DownArrow:
                        i++;
                        break;
                    case ConsoleKey.Enter:
                        flag = true;
                        break;
                }//end switch
            }//end while
            return i;
        }
        public void SwitchMenu2(int op2)
        {
            int op3;
            switch (op2)
            {
                case 0:
                    op3 = seleccion(3, 4);
                    SwitchMenu3(op3);
                    break;
                case 1:
                    op3 = seleccion(3, 4);
                    SwitchMenu3(op3);
                    break;
                case 2:
                    op3 = seleccion(3, 4);
                    SwitchMenu3(op3);
                    break;
            }
        }
        public void SwitchMenu3(int op3)
        {
            switch (op3)
            {
                case 0:
                    Console.WriteLine("Bicola");
                    Console.ReadKey();
                    break;
                case 1:
                    Console.WriteLine("circular");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("circular v2");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Con lista");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Lineal");
                    Console.ReadKey();
                    break;
            }
        }

        public void menu1(int i)
        {
            Console.SetCursorPosition(15, 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SNAKE POR DAYANA Y ERICKSON");

            Console.SetCursorPosition(18, 8);
            Console.ForegroundColor = (i == 0) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("1. Jugar");

            Console.SetCursorPosition(18, 10);
            Console.ForegroundColor = (i == 1) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("2. Ver tabla de posiciones");

            Console.SetCursorPosition(18, 12);
            Console.ForegroundColor = (i == 2) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("3. Salir");
        }
        public void menu2(int i)
        {
            Console.SetCursorPosition(15, 4);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ELIJA LA DIFICULTAD");

            Console.SetCursorPosition(18, 8);
            Console.ForegroundColor = (i == 0) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("1. Fácil");

            Console.SetCursorPosition(18, 10);
            Console.ForegroundColor = (i == 1) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("2. Díficil");

            Console.SetCursorPosition(18, 12);
            Console.ForegroundColor = (i == 2) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("3. Legendario");
        }
        public void menu3(int i)
        {
            Console.SetCursorPosition(15, 4);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ELIJA El TIPO DE ESTRUCTURA A USAR ");

            Console.SetCursorPosition(18, 6);
            Console.ForegroundColor = (i == 0) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("1. Bicola");

            Console.SetCursorPosition(18, 8);
            Console.ForegroundColor = (i == 1) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("2. Cola Circular");

            Console.SetCursorPosition(18, 10);
            Console.ForegroundColor = (i == 2) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("3. Cola Circular V2");

            Console.SetCursorPosition(18, 12);
            Console.ForegroundColor = (i ==3) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("4. Cola Con lista");

            Console.SetCursorPosition(18, 14);
            Console.ForegroundColor = (i == 4) ? ConsoleColor.Red : ConsoleColor.White;
            Console.WriteLine("5. Cola Lineal");
        }

        public void Juega(int i)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("Eligio Fácil");
                    break;
                case 1:
                    Console.WriteLine("Eligio Dificil");
                    break;
                case 2:
                    Console.WriteLine("Eligio Legendario");
                    break;
            }
            Console.ReadKey();
        }

        public void MuestraTabla()
        {
            new ClsArchivos().MuestraNombres();
        }
    }
}
