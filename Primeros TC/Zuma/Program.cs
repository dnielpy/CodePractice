int[] Simula(int[] pista, int[] posiciones, int[] colores){
    List<int> Tablero = pista.ToList();
    for (int x = 0; x < posiciones.Length; x++)
    {
        int color = colores[x];
        int posicion = posiciones[x];
        if (posiciones[x] < 0)
        {
            Tablero.Insert(0, color);
        }
        if (posicion > Tablero.Count())
        {
            Tablero.Add(color);
        }
        else
        {
            Tablero.Insert(posicion, color);
        }

        //Chequear si hay que explotar
        while (true)
        {
            bool done = false;
            int tamaño = Tablero.Count;
            for (int y = 0; y < Tablero.Count; y++)
            {
                int k = y;
                while (k < tamaño && Tablero[k] == Tablero[y])
                {
                    k++;
                }
                if (k - y >= 3)
                {
                    Tablero.RemoveRange(y, k-y);  
                    done = true;              
                    break;
                }
             }
            if (!done)
            {
                break;
            }
        }
    }
    return Tablero.ToArray();
}

int[] col1 = {1,1,2,1,3};
int[] pos1 = {3,0,2,0,0};
int[] pista1 = {};
Simula(pista1, pos1, col1);
