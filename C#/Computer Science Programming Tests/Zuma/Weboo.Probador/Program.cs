// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weboo.Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO 1
            int[] col1 = { 1, 1, 2, 1 };
            int[] pos1 = { 3, 0, 2, 0 };
            int[] pista1 = { };
            int[] r1 = Zuma.Simula(col1, pos1, pista1);
            Test(1, new int[] { 2 }, r1);
            //Respuesta correcta: {2}

            //EJEMPLO 2
            int[] col2 = { 3 };
            int[] pos2 = { 2 };
            int[] pista2 = { 1, 2, 3, 3, 2, 2, 1, 1 };
            int[] r2 = Zuma.Simula(col2, pos2, pista2);
            Test(2, new int[] { }, r2);
            //Respuesta correcta: {}

            //EJEMPLO 3
            int[] col3 = { };
            int[] pos3 = { };
            int[] pista3 = { 1, 2, 1, 3, 4 };
            int[] r3 = Zuma.Simula(col3, pos3, pista3);
            Test(3, new int[] { 1, 2, 1, 3, 4 }, r3);
            //Respuesta correcta: {1,2,1,3,4}

            //EJEMPLO 4
            int[] col4 = { 4 };
            int[] pos4 = { 2 };
            int[] pista4 = { 1, 4, 4, 3, 3, 3 };
            int[] r4 = Zuma.Simula(col4, pos4, pista4);
            Test(4, new int[] { 1, 3, 3, 3 }, r4);
            //Respuesta correcta: {1,3,3,3}
        }

        #region Tester
        private static void Test(int ejemplo, int[] ok, int[] estudiante)
        {
            if (!AreEquals(ok, estudiante))
                NotificaError(string.Format("[Ejemplo {0} INCORRECTO] Se esperaba: [{1}] pero ud devolvió [{2}]", ejemplo, string.Join(" ", ok), string.Join(" ", estudiante)));
            else
                NotificaOk(string.Format("[Ejemplo {0} CORRECTO] [{1}] es correcto", ejemplo, string.Join(" ", estudiante)));
        }

        private static bool AreEquals(int[] ok, int[] estudiante)
        {
        	if(ok.Length != estudiante.Length)
        		return false;
            for (int i = 0; i < ok.Length; i++)
                if (ok[i] != estudiante[i])
                    return false;
            return true;
        }

        private static void NotificaError(string msg)
        {
            var fg = Console.ForegroundColor;
            var bg = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine(" " + msg + " ");

            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
        }

        private static void NotificaOk(string msg)
        {
            var fg = Console.ForegroundColor;
            var bg = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine(" " + msg + " ");

            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
        }
        #endregion
    }
}
