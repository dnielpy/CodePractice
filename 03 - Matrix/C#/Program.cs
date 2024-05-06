using System;
// int[,] MatrisSumada(int[,]x , int[,] y){
//     int[,] respuesta = new int[x.GetLength(0),x.GetLength(1)];

//     if (x.GetLength(0) != y.GetLength(0) || x.GetLength(1) != y.GetLength(1))
//     {
//         System.Console.WriteLine("Deja la gracia pana");
//     }
//     else
//     {
//         for (int i = 0; i < x.GetLength(0); i++)
//         {
//             for (int j = 0; j < x.GetLength(1); j++)
//             {
//                 respuesta[i,j] = x[i,j] + y[i,j];
//             }
//         }
//     }
//     return respuesta;
// }
//  int[,] a = {{1,2}, {1,2}};
//  int[,] b = {{1,2}, {1,2}};
// MatrisSumada(a, b);

// int[,] MultiplicarMatrices(int[,] x, int[,] y){
//     int[,] z = new int[x.GetLength(0),x.GetLength(1)];

//     //For que recorra a Z, por Filas x Columnas
//     for (int f = 0; f < x.GetLength(0); f++)
//     {
//         for (int c = 0; c < y.GetLength(1); c++)
//         {
//             for (int w = 0; w < x.GetLength(1); w++)
//             {
//                 z[f,c] += x[f,w] * y[w,c];   
//             }
//         }
//     }
//     return z;
// }
// int[,] a = {{1,2}, {1,2}};
// int[,] b = {{1,2}, {1,2}};
// MultiplicarMatrices(a, b);

// int Diagonal(int[,]x){
//     int z = 0;

//     for (int f = 0; f < x.GetLength(0); f++)
//     {
//         z += x[f,f];
//     }
//     return z;
// }


// int[,] Transpuesta(int[,]x){
//     int[,] z = new int[x.GetLength(1), x.GetLength(0)];

//     for (int f = 0; f < x.GetLength(1); f++)
//     {
//         for (int c = 0; c < x.GetLength(0); c++)
//         {
//             z[f,c] = x[c,f];
//         }
//     }

//     return z;
// }

// int[,] a = {{1,2}, {1,2}};
// Transpuesta(a);



// bool Simetria(int[,]x){
//     bool respuesta = true;

//     for (int f = 0; f < x.GetLength(0); f++)
//     {
//         for (int c = 0; c < x.GetLength(1); c++)
//         {
//             if (x[f,c] != x[c,f])
//             {
//                 respuesta = false;
//             }
//         }
//     }
//     return respuesta;
// }
// int[,] a = {{1,2}, {1,2}};
// Simetria(a);


// int[,] Ceros(int[,]x){
//     int[,]z = x;


//     void Columna(int[,]a, int x1){
//         for (int c = 0; c < z.GetLength(0); c++)
//         {
//             z[c, x1] = 0;
//         }
//     }
    
//     void Fila(int[,]a, int x1){
//         for (int f = 0; f < z.GetLength(1); f++)
//         {
//             z[x1, f] = 0;
//         }
//     }

//     for (int f = 0; f < z.GetLength(0); f++)
//     {
//         for (int c = 0; c < z.GetLength(1); c++)
//         {
//             if (z[f,c] == 0)
//             {
//                 Fila(z,f);
//                 Columna(z,c);
//                 return z;
//             }
//         }
//     }

    

//     return z;
// }

// int[,] a = {{1,1,0}, {1,2,1}};

// Ceros(a);


// int[] Espiral(int[,] x){
//     List<int> z = new List<int>();

//     //Agregar a la derecha
//     void Derecha(int fila){
//         for (int c = 0; c < x.GetLength(1); c++)
//         {
//             z.Add(x[fila,c]);
//         }
//     }
//     void Izquierda(int fila){
//         for (int c = x.GetLength(1)-1; c > 0 ; c--)
//         {
//             z.Add(x[fila,c]); 
//         }
//     }
//     void Abajo(int columna){
//         for (int f = 0; f < x.GetLength(0)-1; f++)
//         {
//             z.Add(x[f, columna]);
//         }
//     }

//     void Arriba(int columna){
//         for (int f = x.GetLength(0)-1; f > 0; f--)
//         {
//             z.Add(x[f, columna]);
//         }
//     }

//     for (int i = 0; i <= x.GetLength(1)/2; i++)
//     {
//         Derecha(i);
//         Abajo(x.GetLength(1)-i-1);
//         Izquierda(x.GetLength(0)-1-i);
//         Arriba(i);

//         if (x.GetLength(0) % 2 == 0)
//         {
//             z.Add(x[(x.GetLength(0)/2)-1, x.GetLength(1)/2]);
//             z.Add(x[x.GetLength(0)/2, x.GetLength(1)/2]);
//             break;
//         }
        
//     }
//     z.RemoveAt(0);
    
//     return z.ToArray();
// }

// int[,] a = {{1,1,1}, {2,2,2}, {3,3,3}, {4,4,4}, {5,5,5}, {6,6,6}};

// Espiral(a);
