using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatCom.Examen;

public class JaimesPineapple
{
    public static int Solve(int[,] matrix, int[] factors, int[] operations)
    {
    int solucion = 0;
    int columnacentral = matrix.GetLength(1)/2;

    //Rotar un array n veces
    int[] Rotar(int[] x, int z){
        List<int> y = x.ToList<int>();
        if (z > 0)
        {
            for (int i = 0; i < z; i++)
            {
                y.Insert(0, y[y.Count-1]);
                y.RemoveAt(y.Count-1); 
            }
        }
        if (z < 0)
        {
            for (int i = z; i < 0; i++)
            {
                y.Add(y[0]);
                y.Remove(y[0]); 
            }
        }
        return y.ToArray();
    }

    //Sumar los elementos de la columna principal
    int SumarColumna(int[,] x){
        int y = 0;
        for (int f = 0; f < x.GetLength(0); f++)
        {
            y += x[f, columnacentral];
            EliminarPosicion(f, columnacentral);
        }
        return y;
    }

    // Rotar Completo
    void RotarCompleto(int k, int r){
        int factores = r;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            List<int> FilaTemporal = new List<int>();
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                FilaTemporal.Add(matrix[i, c]);
            }
            FilaTemporal = Rotar(FilaTemporal.ToArray(), k*factors[factores]).ToList();

            //Cambiar la fila ya lista en la matriz original
            for (int o = 0; o < matrix.GetLength(1); o++)
            {
                matrix[i, o] = FilaTemporal[o];
            }
            factores++;
        }
    }
    
    //Hace 0 una posicion en especifica del array principal
    void EliminarPosicion(int f, int c){
        List<int> FilaTemporal = new List<int>();
        for (int r = 0; r < matrix.GetLength(1); r++)
        {
            FilaTemporal.Add(matrix[f, r]);
        }
        FilaTemporal[c] = 0;
        for (int r = 0; r < matrix.GetLength(1); r++)
        {
            matrix[f, r] = FilaTemporal[r];
        }
    }
    

    for (int o = 0; o < operations.Length; o++)
    {
        RotarCompleto(operations[o], 0);
        solucion += SumarColumna(matrix);
    }

    return solucion;
    }
}
