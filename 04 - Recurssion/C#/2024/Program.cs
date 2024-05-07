//Factorial
// int Factorial(int x){
//     if (x == 0 || x == 1)
//     {
//         return x;
//     }
//     else
//     {
//         return x * Factorial(x-1);
//     }
// }
// System.Console.WriteLine(Factorial(4));

//Fionacci
// int Fibo(int n){
//     if (n == 0)
//     {
//         return 0;
//     }
//     else if(n == 1){
//         return 1;
//     }
//     else
//     {
//         return Fibo(n-1) + Fibo(n-2);
//     }
// }
// System.Console.WriteLine(Fibo(8));

//Suma de Elementos
// int SumaRecursiva(int[] x){
//     List<int> temp = x.ToList();
//     if (temp.Count == 1)
//     {
//         return temp[0];
//     }
//     if (temp.Count == 0)
//     {
//         return 0;
//     }
//     else
//     {
//         int valutemp = temp[temp.Count() - 1];
//         temp.Remove(temp.Last());
//         return valutemp + SumaRecursiva(temp.ToArray());
//     }
// }
// int[] a = {1,2,3,4};
// System.Console.WriteLine(SumaRecursiva(a));

// //Invertir una cadena
// string Invertir(string a){
//     if (a.Length == 0)
//     {
//         return a;
//     }
//     if (a.Length == 1)
//     {
//         return a;
//     }

//     else
//     {
//         return a[a.Length - 1].ToString() + Invertir(a.Remove(a.Length - 1));
//     }

// }
// System.Console.WriteLine(Invertir("HOLA"));

