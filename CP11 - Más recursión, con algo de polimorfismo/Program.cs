//Pal´ındromo Implemente una funci´on recursiva que reciba un string y analice si este es pal´ındromo.
bool Palindromo(string x){
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

System.Console.WriteLine(Palindromo("radar"));