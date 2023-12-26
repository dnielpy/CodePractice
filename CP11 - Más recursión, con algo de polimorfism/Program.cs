//Pal´ındromo Implemente una funci´on recursiva que reciba un string y analice si este es pal´ındromo.
/*bool Palindromo(string x){
    string y = "";
    if(x == "" && y == ""){
        return true;
    }
    for (int i = 0; i < x.Length; i++)
    {
        y += x[x.Length - 1 - i];
    }

    if (x[0] != y[y.Length-1])
    {
        return false;
    }
    else
    {
        return Palindromo(x.Remove(x.Length - 1));
    }
}
System.Console.WriteLine(Palindromo("radar")); */


//Suma decreciente Implemente un m´etodo que reciba un entero n y muestre en la consola todas las secuencias distintas de enteros positivos que suman n. Por ejemplo, para n = 4, debe mostrar:
//formula para descomponer un numero en sus sumandos
int Descomponer(int x){
    if (x <= 1)
    {
        return x;
    }
    else
    {
        int y = x;
        return y - Descomponer(x-1);
    }  
}

System.Console.WriteLine(Descomponer(4));
