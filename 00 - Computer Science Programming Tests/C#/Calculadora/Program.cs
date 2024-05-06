int Calculadora(char[] y){
    int resultado = 0;
    List<char> x = y.ToList();

    int toInt(char t){
        return (int)Char.GetNumericValue(t);
    } 

    for (int i = 0; i < x.Count; i++)
    {
        if (x[i] == '+')
        {
            resultado = toInt(x[i-1]) + toInt(x[i+1]);
            x.RemoveRange(0, i+2);
            x.Insert(0, resultado.ToString()[0]);
            i = 0;
        }
        if (x[i] == '-')
        {
            resultado = toInt(x[i-1]) - toInt(x[i+1]);
            x.RemoveRange(0, i+2);
            x.Insert(0, resultado.ToString()[0]);
            i = 0;
        }
        if (x[i] == '*')
        {
            resultado = toInt(x[i-1]) * toInt(x[i+1]);
            x.RemoveRange(0, i+2);
            x.Insert(0, resultado.ToString()[0]);
            i = 0;
        }
        if (x[i] == 'C')
        {
            x.RemoveRange(0, i+1);
            x.Insert(0, 0.ToString()[0]);
            i = 0;
        }
    }
    return resultado;
}

char[] a = {'1', '+', '2', '+', '1', 'C', '1', '+', '2'};

Calculadora(a);