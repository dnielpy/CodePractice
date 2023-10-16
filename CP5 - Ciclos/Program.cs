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
/*
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
*/

//Implemente un m´etodo que devuelva los elementos de un array de enteros pororden de cercan´ıa a otro entero dado que llamaremos pivote, entonces estos sedeber´an ordenar de menor a mayor.Ejemplo:Dado [5,3,7,10] y pivote=7 los elementos del array quedar´ıan en este orden:[7,5,10,3]


//Implemente un m´etodo que determine si un n´umero n pertenece al array a
/*
int[] x = {1,2,3,4,5,6,7,8,9,10};
bool Pertenece(int[] a, int elemento){
    bool answer = false;

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == elemento)
        {
            answer = true;
            break;
        }
        else
        {
            answer = false;
        }
    }
    return answer;
}

System.Console.WriteLine(Pertenece(x, 91));
*/




