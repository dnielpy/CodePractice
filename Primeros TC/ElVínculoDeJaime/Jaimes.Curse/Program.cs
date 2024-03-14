string Solve(string[] words, char[] c)
{
    string solucion = "";
    List<string> x= words.ToList();

    List<char> deletrear (string a){
        List<char> w = new List<char>();
        for (int i = 0; i < a.Length; i++)
        {
            w.Add(a[i]);
        }

        //Array.IndexOf(w.ToArray(), 's');
        return w;
    }

    bool busca(List<char> x, char y){
        if (x.Contains(y))
        {
            return true;
        }
        else{
            return false;
        }
    }

    void transform(int j, char k){
        List<string> z = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            if (i == j)
            {
                List<char> y = deletrear(words[i]);
                y.Remove(k);
                string e = "";
                for (int l = 0; l < y.Count; l++)
                {
                    e += y[l].ToString();
                }
                z.Add(e);
            }
            else
            {
                z.Add(words[i]);
            }
        }
        words = z.ToArray();
    }
    
    int contador = 0;
    for (int i = 0; i < c.Length; i++)
    {
        for (int j = contador; j < words.Length; j++)
        {
            if (busca(deletrear(words[j]), c[i]))
            {
                transform(j, c[i]);
                contador++;
                break;
            }
        }
    }
    
    //transform(1, 'o');
    //busca(deletrear(words[0]), 'o');

    //Agregar los valores a solucion

    for (int i = 0; i < words.Length; i++)
    {
        solucion += words[i];
    }
    return solucion;
}

string[] a = {"lom", "asvi", "ddtal"};
char[] b = {'c', 'd', 'c', 'd'};
Solve(a, b);
