//M´ınima diferencia entre dos n´umerosEscriba un m´etodo que dado un array de n´umeros enteros devuelva la menor delas diferencias entre cualquier par de elementos.
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
