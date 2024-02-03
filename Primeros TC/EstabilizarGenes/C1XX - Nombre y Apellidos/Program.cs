string Estabilizar(string cadena){
    List<string>solucion = new List<string>();

    int repeticiones = cadena.Length / 4;

    for (int x = 0; x < cadena.Length; x++)
    {
        int contador = 0;
        for (int y = 0; y < cadena.Length; y++)
        {
            if (cadena[x] == cadena[y])
            {
                contador++;
                if (contador > repeticiones)
                {
                solucion.Add(cadena[y].ToString());
                contador = 0;
                }
            }
            
        }
    }


    return solucion.ToString();
}


Estabilizar("AATTGGGA");