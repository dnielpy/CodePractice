using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weboo.Examen
{
    public class Zuma
    {
            public static int[] Simula (int[] colores, int[] posiciones, int[] pista)
            {
            List<int> Respuesta = pista.ToList();

            //Crear el metodo para lanzar las bolas
            int[] shoot(int[] x, int pos, int col){
        List<int> resultado = x.ToList();

        if (pos >= x.Length)
        {
            resultado.Add(col);
        }
        if (pos <= 0)
        {
            resultado.Insert(0, col);
        }
        else
        {
            resultado.Insert(pos, col);   
        }

        return resultado.ToArray();
    }

            //Crear el metodo para chequear
            int[] check(int[] arr)
    {
        List<int> resultado = new List<int>();
        int i = 0;
        while (i < arr.Length - 2)
        {
            if (arr[i] == arr[i + 1] && arr[i + 1] == arr[i + 2])
            {
                // Encuentra una secuencia de tres o mas
                int valorEliminar = arr[i];
                int j = i + 3;
                while (j < arr.Length && arr[j] == valorEliminar)
                {
                    j++;
                }
                // No se agregua la secuencia al resultado
                i = j;
            }
            else
            {
                // Se agruega el número al resultado
                resultado.Add(arr[i]);
                i++;
            }
        }
        // Los elementos restantes
        while (i < arr.Length)
        {
            resultado.Add(arr[i]);
            i++;
        }
        return resultado.ToArray();
    }

            for (int i = 0; i < colores.Length; i++)
            {
                Respuesta = check(Respuesta.ToArray()).ToList();
                Respuesta = shoot(Respuesta.ToArray(), posiciones[i], colores[i]).ToList();
                for (int j = 0; j < Respuesta.Count(); j++)
                {
                    Respuesta = check(Respuesta.ToArray()).ToList();  
                }

            }
            return Respuesta.ToArray();
        }
    }
}
