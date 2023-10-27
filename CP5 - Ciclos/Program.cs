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


//Implemente un m´etodo que devuelva el promedio de todos los elementos de un array
/*
int[] a = {1,5,3,2,4,5,2};

double Promedio(int[] x){
    double contador = 0;

    for (int i = 0; i < x.Length; i++)
    {
        contador += x[i];
    }
    return contador / (double)x.Length;
}

int MayoresQuePromedio(int[] x, int promedio){
    int mayores = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] > promedio)
        {
            mayores++;
        }
    }
    return mayores;
}


System.Console.WriteLine($"El promedio es: {Promedio(a)} y hay {MayoresQuePromedio(a, (int)Promedio(a))} mayores que el");
*/

//Implemente un m´etodo que devuelva el elemento moda de un array. El elemento moda de un array es aquel que m´as se repite.
/*
int[] a = {1,4,3,2,4,2,2,4,2,1};

int Moda(int[] x){
    int moda = 0;
    int max = 0;
    List<int> sin_repetir_llaves = new List<int>();

    Dictionary<int, int> elementos_sin_repetir = new Dictionary<int, int>();

    for (int i = 0; i < x.Length; i++)
    {
        if (elementos_sin_repetir.ContainsKey(x[i]) != true)
        {
            elementos_sin_repetir.Add(a[i], 0);
        }
        elementos_sin_repetir[a[i]]++;
    }

    foreach (var llave in elementos_sin_repetir.Keys)
    {
        sin_repetir_llaves.Add(llave);
    }

    for (int i = 0; i < sin_repetir_llaves.Count; i++)
    {
        if (max < elementos_sin_repetir[sin_repetir_llaves[i]])
        {
            max = elementos_sin_repetir[sin_repetir_llaves[i]];
        }
    }
    for (int i = 0; i < sin_repetir_llaves.Count; i++)
    {
        if (elementos_sin_repetir[sin_repetir_llaves[i]] == max)
        {
            moda = sin_repetir_llaves[i];
        }
    }

    return moda;
}
System.Console.WriteLine(Moda(a));
*/


/*Implemente un m´etodo que devuelva el elemento mediana de un array. El
elemento mediana de un array es aquel elemento que tiene la misma cantidad
de elementos mayores y elementos menores en el array. Asuma que el array
numeros no contiene elementos repetidos
*/
/*
int[] a = {1,4,3,5,7,9,2};
int Mediana(int[] x){
    int mediana = 0;
    Dictionary<int, int> mayores = new Dictionary<int, int>();
    Dictionary<int, int> menores = new Dictionary<int, int>();

    //agregar las key a los dict
    foreach (var valores in x)
    {
        mayores.Add(valores, 0);
        menores.Add(valores, 0);
    }

    for (int i = 0; i < x.Length; i++)
    {
        for (int y = 0; y < x.Length; y++)
        {
            if (x[i] > x[y])
            {
                menores[x[i]]++;
            }
            if (x[i] < x[y])
            {
                mayores[x[i]]++;
            }
        }
    }

    int[] mayoresarray = new int[x.Length];
    int[] menoresarray = new int[x.Length];

    for (int i = 0; i < x.Length; i++)
    {
        mayoresarray[i] = mayores[x[i]];
        menoresarray[i] = menores[x[i]];
    }

    for (int i = 0; i < x.Length; i++)
    {
        if (mayoresarray[i] == menoresarray[i])
        {
            mediana = x[i];
            return mediana;
        }   
    }
    return mediana;
}

System.Console.WriteLine(Mediana(a));
*/

/*Implemente un m´etodo que dado dos n´umeros no negativos representados como
string devuelva la suma de estos dos n´umeros tambi´en como string.Note que
cada unos de estos n´umeros pueden tener m´as de mil d´ıgitos :-). */
/*
string SumarCadenas(string cadena1, string cadena2){
    string respuesta = "";

//Emparejar las cadenas en tamaño agregando 0s al final de la menor
    int tamaño1 = cadena1.Length;
    int tamaño2 = cadena2.Length;
    double lugaresDecimales = Math.Max(tamaño1, tamaño2) - Math.Min(tamaño1, tamaño2);
    lugaresDecimales = Math.Pow(10, lugaresDecimales - 1);
    string agrego = lugaresDecimales.ToString();
    agrego = agrego.Replace("1", "0");

    if (tamaño1 > tamaño2)
    {
        cadena2 = agrego + cadena2;
    }
    if (tamaño1 < tamaño2)
    {
        cadena1 = agrego + cadena1;        
    }

//Darle la vuelta a las cadenas
    char[] puente1 = cadena1.ToCharArray();
    char[] puente2 = cadena2.ToCharArray();
    Array.Reverse(puente1);
    Array.Reverse(puente2);
    string a = new string(puente1);
    string b = new string(puente2);

//Sumar
int[] resultado = new int[a.Length + 1];
int arrastre = 0;
    for (int i = 0; i < a.Length; i++)
    {
        //Convertir la cadena en int momentanamente
        string bridgea = a[i].ToString();
        string bridgeb = b[i].ToString();

        resultado[i] = int.Parse(bridgea) + int.Parse(bridgeb);
        if (arrastre != 0)
        {
            resultado[i] = resultado[i] + arrastre;
        }
        if (resultado[i] >= 10)
        {
            arrastre = resultado[i] / 10;
            resultado[i] = (resultado[i] % 10);  
        }    
    }
    for (int i = 0; i < resultado.Length - 1; i++)
    {
        respuesta += resultado[i].ToString();   
    }
    char[] puente3 = respuesta.ToCharArray();
    Array.Reverse(puente3);
    respuesta = new string(puente3);
    return respuesta;
}

System.Console.WriteLine(SumarCadenas("132", "2933330"));
*/

/*Restando cadenas
Implemente un m´etodo que dado dos n´umeros no negativos representados como
string devuelva la resta de estos n´umeros.*/
/*
string RestarCadenas(string cadena1, string cadena2){
    string respuesta = "";

//Emparejar las cadenas en tamaño agregando 0s al final de la menor
    int tamaño1 = cadena1.Length;
    int tamaño2 = cadena2.Length;
    double lugaresDecimales = Math.Max(tamaño1, tamaño2) - Math.Min(tamaño1, tamaño2);
    lugaresDecimales = Math.Pow(10, lugaresDecimales - 1);
    string agrego = lugaresDecimales.ToString();
    agrego = agrego.Replace("1", "0");

    if (tamaño1 > tamaño2)
    {
        cadena2 = agrego + cadena2;
    }
    if (tamaño1 < tamaño2)
    {
        cadena1 = agrego + cadena1;        
    }

//Darle la vuelta a las cadenas
    char[] puente1 = cadena1.ToCharArray();
    char[] puente2 = cadena2.ToCharArray();
    Array.Reverse(puente1);
    Array.Reverse(puente2);
    string a = new string(puente1);
    string b = new string(puente2);

//Sumar
int[] resultado = new int[a.Length];
int arrastre = 0;
    for (int i = 0; i < a.Length; i++)
    {
        //Convertir la cadena en int momentanamente
        string bridgea = a[i].ToString();
        string bridgeb = b[i].ToString();

        if (int.Parse(bridgea) - int.Parse(bridgeb) < 0)
        {
            bridgea = (int.Parse(bridgea) + 10).ToString();
            arrastre = arrastre-1;
        }
        
        resultado[i] = int.Parse(bridgea) - int.Parse(bridgeb);
        if (arrastre != 0)
        {
            resultado[i] = resultado[i] + arrastre;
        }
        if (resultado[i] >= 10)
        {
            arrastre = resultado[i] / 10;
            resultado[i] = (resultado[i] % 10);  
        }    
    }
    //Agregar el signo menos
    bool negative = false;
    for (int i = 0; i < resultado.Length; i++)
    {
        if (resultado[i] < 0)
        {
            negative = true;
        }
    }
    resultado[0] = resultado[0] + 1;
    //Pasar los valores del array respuesta a la cadena resultado
    for (int i = 0; i < resultado.Length; i++)
    {
        if (resultado[i] < 0)
        {
            resultado[i] = -1 * resultado[i];
            respuesta += resultado[i].ToString();   
        }
        else
        {
            respuesta += resultado[i].ToString();   
        }
    }
    if (negative == true)
    {
        respuesta += "-";
    }
    
    char[] puente3 = respuesta.ToCharArray();
    Array.Reverse(puente3);
    respuesta = new string(puente3);
    return respuesta;
}

System.Console.WriteLine(RestarCadenas("18", "5"));
*/


/*Contando positivos
Implemente un m´etodo que devuelva un array con todos los elementos positivos
del array a.*/
/*
int[] EliminarNegativos(int[] x){
    List<int> respuestalist = new List<int>();

    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] >= 0)
        {
            respuestalist.Add(x[i]);
        }
    }
    return respuestalist.ToArray();
}

int[] a = {-1,2,4,5};

for (int i = 0; i < EliminarNegativos(a).Length; i++)
{
    System.Console.WriteLine(EliminarNegativos(a)[i]);
}
*/


/*
Conjuntos
Sean A y B dos conjuntos representados a partir de arrays. Implementa los
m´etodos que devuelvan los resultados correspondientes a las siguientes operaciones entre conjuntos:
a)
Intersecci´on (A ∩ B).
/*
int[] a = {2,4,6,8};
int[] b = {1,2,4,5,7,8};

int[] Interseccion(int[] x, int[] y){
    List<int> interseccion = new List<int>();

    for (int i = 0; i < Math.Min(x.Length, y.Length); i++)
    {
        for (int o = 0; o < Math.Max(x.Length, y.Length); o++)
        {
            if (x.Length < y.Length)
            {
                if (x[i] == y[o])
                {
                    interseccion.Add(x[i]);   
                }
            }
            else
            {
                if (y[i] == x[o])
                {
                    interseccion.Add(y[i]);   
                }
            }
        }
    }

    return interseccion.ToArray();
}
Interseccion(a, b);
*/

/*
b)
Uni´on (A ∪ B).
/*
int[] a = {2,4,6,8};
int[] b = {1,2,4,5,7,8};

int[] Union(int[] x, int[] y){
    List<int> union = new List<int>();

    union = x.ToList();
    foreach (var item in y)
    {
        union.Add(item);
    }
    int[] z = union.ToArray();
    return (int[])z.Distinct();
}
Union(a, b);
*/

/*
c)
Subconjunto(A ⊂ B)
*/
/*
int[] a = {2,4,8};
int[] b = {1,2,4,5,7,8};
bool Subconjunto(int[] x, int[] y){
    int contador = 0;
    bool respuesta = false;

    for (int i = 0; i < Math.Min(x.Length, y.Length); i++)
    {
        for (int o = 0; o < Math.Max(x.Length, y.Length); o++)
        {
            if (x.Length < y.Length)
            {
                if (x[i] == y[o])
                {
                    contador++;
                }
            }
            else
            {
                if (x[o] == y[i])
                {
                    contador++;
                }
            }
        }
    }
    
    if (contador == Math.Min(x.Length, y.Length))
    {
        respuesta = true;
    }
    return respuesta;
}
System.Console.WriteLine(Subconjunto(a, b));
*/

/*Rotando
Implemente un m´etodo que modifique el array a de forma que al concluir la ejecuci´on del m´etodo el array a contenga los mismos elementos que conten´ıa originalmente pero rotados en sus posiciones tantas veces como indique el par´ametro
veces, si veces es positivo a la derecha y si el par´ametro es negativo, entonces a la
izquierda. Note que si el par´ametro veces es 0 entonces el array no se modifica.
Por ejemplo, si rotamos el array 25, 40, 17, 83, 9 2 veces, entonces obtenemos
el array 83, 9, 25, 40, 17 y si lo rotamos -2 veces entonces nos queda 17, 83, 9,
25, 40*/

/*Rotando
Implemente un m´etodo que modifique el array a de forma que al concluir la ejecuci´on del m´etodo el array a contenga los mismos elementos que conten´ıa originalmente pero rotados en sus posiciones tantas veces como indique el par´ametro
veces, si veces es positivo a la derecha y si el par´ametro es negativo, entonces a la
izquierda. Note que si el par´ametro veces es 0 entonces el array no se modifica.
Por ejemplo, si rotamos el array 25, 40, 17, 83, 9 2 veces, entonces obtenemos
el array 83, 9, 25, 40, 17 y si lo rotamos -2 veces entonces nos queda 17, 83, 9,
25, 40*/
/*
int[] a = {2,5,4,3,6};
int[] Rotar(int[] x, int rotaciones){
    int contador = rotaciones;

    for (int q = 0; q <= rotaciones; q++)
    {
        int first = x[0];

        for (int i = 0; i < x.Length-1; i++)
        {
            x[i] = x[i + 1];
        }
        x[x.Length-1] = first;
    }
    return x;
}
Rotar(a, 2);
*/

