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

//Potencia Implemente un m´etodo que calcule recursivamente la potencia de un entero n
/*int Potencia(int x, int k){
    if (k == 0)
    {
        return 1;
    }
    if (k == 1)
    {
        return x;
    }
    else
    {
        return x * Potencia(x, k-1);
    }
}
System.Console.WriteLine(Potencia(4, 3));*/

//MCD Implemente un m´etodo que calcule el m´aximo com´un divisor (MCD) de dos enteros.
/*int MaxComDivisor(int x, int y){
    List<int> divisores = new List<int>();
    for (int i = 1; i <= Math.Min(x, y); i++)
    {
        if (x % i == 0 && y % i == 0)
        {
            divisores.Add(i);
        }
    }
    return divisores.Last();
}
System.Console.WriteLine(MaxComDivisor(14, 27));*/

//D´ıgitos Implemente una funci´on que calcule recursivamente la suma de los d´ıgitos de un entero n.
/*int SumaDigitos(int a){
    string x = a.ToString();
    if (x.Length == 0)
    {
        return 0;
    }
    else if(x.Length == 1)
    {
        string y = x[0].ToString();
        return int.Parse(y);
    }
    else
    {
        return int.Parse(x[x.Length - 1].ToString()) + SumaDigitos(int.Parse(x.Remove(x.Length - 1)));
    }
}
System.Console.WriteLine(SumaDigitos(65));*/

//Subsecuencia com´un Implemente una funci´on recursiva que calcule la longitud de la subsecuencia com´un m´as larga enter dos strings.


