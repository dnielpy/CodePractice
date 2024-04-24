//M´ınima diferencia entre dos n´umerosEscriba un m´etodo que dado un array de n´umeros enteros devuelva la menor delas diferencias entre cualquier par de elementos.
/*
int MenorDiferencia(int[] x){
    int menor = 11110;
    for (int i = 0; i < x.Length; i++)
    {
        int bridge = Math.Max(x[0], x[1]) - Math.Min(x[0], x[1]);
        for (int t = 0; t < x.Length; t++)
        {
            if (Math.Max(x[i], x[t]) - Math.Min(x[i], x[t]) > bridge)
            {
                bridge = Math.Max(x[i], x[t]) - Math.Min(x[i], x[t]);
            }
            if (bridge < menor)
            {
            menor = bridge;
            }
        }
        
    }
    return menor;
}

int[] a = {1,3,56,8,23,5};
MenorDiferencia(a);
*/

//Criba de Erat´ostenesEscriba un m´etodo que dado un entero n devuelva un array de bool de tama˜non.El array resultante debe tener valor true en la posici´on i si el n´umero enteroi es primo. En caso contrario, tendr´a valor f alse.Por ejemplo, para n = 10, el array resultante debe ser: true, true, f alse,f alse, true, f alse, true, f alse, true, true
/*
bool[] Primo(int x){
    bool[] clasificacion = new bool[x + 1];
    for (int i = 0; i < clasificacion.Length; i++)
    {
        if (i != 0 && Math.Max(2, i) % Math.Min(2, i) != 0)
        {
            clasificacion[i] = true;
        }
    }
    return clasificacion;
}
Primo(5);
*/


//¿Cu´antos n´umeros?Escriba un m´etodo que reciba un entero k y un array de valores y devuevlacu´antos de esos valores se repiten exactamente k veces.
/*
int[] Repeticiones(int k, int[] x){
    List<int> repeticiones = new List<int>();
    for (int i = 0; i < x.Length; i++)
    {
        int contador = 0;
        for (int t = 0; t < x.Length; t++)
        {
            if (x[i] == x[t])
            {
                contador++;
            }
        }
        if (contador == k)
        {
            repeticiones.Add(x[i]);
            break;
        }
    }
    return repeticiones.ToArray();
}
int[] a = {1,2,34,6,7,7,7};
Repeticiones(3, a);
*/

//¿Cu´antos n´umeros? 2Escriba un m´etodo que reciba un entero k y un array de valores distintos entreellos y devuelva cu´antos pares de valores existen que, al sumarlos, dan comoresultado k.
/*
int Repeticiones2(int k, int[] x){
    int suma = 0;
    for (int i = 0; i < x.Length; i++)
    {
        for (int t = i; t < x.Length; t++)
        {
            if (x[i] + x[t] == k)
            {
                suma++;
            }
        }
    }
    return  suma;
}
int[] a = {1,2,34,6,7, 4, -1};
Repeticiones2(3, a);
*/

//Problema de la distribuci´on del ChocolateDado un array de N valores donde cada valor representa la cantidad de chocolates en un paquete, se quieren repartir estos paquetes entre varios estudiantes.Determine c´omo distribuirlos de forma tal que se satisfagan las siguientescondiciones:- Cada estudiante recibe un paquete- La diferencia entre la cantidad de chocolates del estudiante con la m´ınimacantidad y la del estudiante con la m´axima cantidad es m´ınima.