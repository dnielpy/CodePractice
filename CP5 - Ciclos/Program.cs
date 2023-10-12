//Implemente un metodo que devuelva el mayor elemento de un array
/*
int[] x = {1,109,2,4,12,4,56,3,99,-3};
int Mayor(int[] x){
    int contador = 0;

    for (int i = 0; i < x.Length; i++)
    {
        if (x[contador] < x[i])
        {
            contador = i;
        }
    }
    return x[contador];
}

System.Console.WriteLine(Mayor(x));
*/


//Implemente un m´etodo que devuelva el segundo menor elemento de un array.
/*
int[] x = {1,2,4,12,4,56,3,99,-3, 6};
int Segundo(int[] x){
    int Mayor(int[] x){
        int contador = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[contador] < x[i])
            {
                contador = i;
            }
        }
        return x[contador];
    }

    int mayor = Mayor(x);

    int[]y = new int[x.Length];
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] != mayor)
        {
            y[i] = x[i];
        }
    }
    return Mayor(y);
}

System.Console.WriteLine(Segundo(x));
*/

//Implemente un m´etodo que invierte el orden de los elementos del array a que recibe como entrada

int[]y = {1,2,54,3,21,4};

int[] InvertirArray(int[] x){
    int[] invertido = new int[x.Length];
    for (int i = 0; i < x.Length; i++)
    {
        invertido[i] = x[x.Length-1-i];
    }
    return invertido;
}

InvertirArray(y);