//Factorial Implemente un m´etodo que calcule recursivamente el factorial de un n´umero entero n.
/*int factorial(int x){
    if (x == 1)
    {
        return x;
    }
    else
    {
        return x * factorial(x - 1);
    }
}
System.Console.WriteLine(factorial(4));*/

//FibonacciImplemente un m´etodo que calcule recursivamente el n-´esimo n´umero de lasecuencia de Fibonacci.
/*int Fibonacci(int x){
    if (x == 0)
    {
        return 0;
    }
    if (x == 1)
    {
        return x;
    }
    else
    {
        return x + Fibonacci(x-1);
    }
}
System.Console.WriteLine(Fibonacci(4));*/

//Suma de elementos Implemente un m´etodo que sume recursivamente todos los elementos de una lista de enteros.
/*int SumaElementos(List<int> x){
    if (x.Count == 1)
    {
        return x[0];
    }
    else
    {
        int bridge = x.Last();
        x.Remove(x.Last());
        return bridge + SumaElementos(x);
    }
}
List<int> a = new List<int>();
a.Add(1);
a.Add(3);
System.Console.WriteLine(SumaElementos(a));*/

//Inversi´on de cadena Implemente un m´etodo que invierta recursivamente un string. Retorne el string invertido.
/*string Invertir(string a){
    if (a.Length == 1)
    {
        return a;
    }
    else if (a == "")
    {
        return a;
    }
    else
    {
        return a[a.Length - 1].ToString() + Invertir(a.Remove(a.Length - 1));
    }
}
System.Console.WriteLine(Invertir("aaaza"));*/

