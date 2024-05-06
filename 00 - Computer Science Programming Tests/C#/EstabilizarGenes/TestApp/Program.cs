using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weboo.Examen;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO 1
            string gen1 = "TTCG";
            string subString1 = EstabilizaGenes.EstabilizarGen(gen1);
            //Respuesta correcta "T"
            Test(1, "T", subString1);

            //EJEMPLO 2
            string gen2 = "GAAA";
            string subString2 = EstabilizaGenes.EstabilizarGen(gen2);
            //Respuesta correcta "AA" 
            Test(1, "AA", subString2);

            //EJEMPLO 3
            string gen3 = "GAAATAAA";
            string subString3 = EstabilizaGenes.EstabilizarGen(gen3);
            //Respuesta correcta "AATAA"
            Test(1, "AATAA", subString3);

            //EJEMPLO 4
            string gen4 = "ACTGCTAG";
            string subString4 = EstabilizaGenes.EstabilizarGen(gen4);
            //Respuesta correcta ""
            Test(1, "", subString4);

            //EJEMPLO 5
            string gen5 = "ACTGAAAG";
            string subString5 = EstabilizaGenes.EstabilizarGen(gen5);
            //Respuesta correcta "AA" 
            Test(1, "AA", subString5);
        }

        #region Utilidades

        private static void Test(int ejemplo, string ok, string estudiante)
        {
            if (!SonEquivalentes(ok, estudiante))
            {
                NotificaError(string.Format("[Ejemplo {0} INCORRECTO] Se esperaba: {1} pero ud devolvió {2}", ejemplo, ok, estudiante));
            }
            else
            {
                NotificaOk(string.Format("[Ejemplo {0} CORRECTO] {1} es correcto", ejemplo, estudiante));
            }
        }

        private static bool SonEquivalentes(string ok, string estudiante)
        {
            var okToCharArray = ok.ToCharArray();
            var estudianteToCharArray = estudiante.ToCharArray();
            Array.Sort(okToCharArray);
            Array.Sort(estudianteToCharArray);
            return string.Join("", okToCharArray) == string.Join("", estudianteToCharArray);
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
