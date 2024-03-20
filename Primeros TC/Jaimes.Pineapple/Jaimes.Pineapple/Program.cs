using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatCom.Examen;

class Program
{
    static void Check(int expected, int given)
    {
        if (given == expected)
            Console.WriteLine("Correcto: '{0}'", given);
        else
            Console.WriteLine("Debe devolver '{0}' pero devuelve '{1}'.", expected, given);
    }

    static void Main(string[] args)
    {
        int[,] matrix;
        int[] factors;
        int[] operations;
        int solution;

        matrix = new int[,] {
            { 1, 2, 3 },
            { 1, 2, 3 },
            { 1, 2, 3 }
        };
        factors = new int[] { 5, -2, 0 };
        operations = new int[] { 1, 3, -2, 0 };

        solution = JaimesPineapple.Solve(matrix, factors, operations);
        Check(10, solution);
    }
}


