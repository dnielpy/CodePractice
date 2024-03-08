using System;

int EncontrarGanador(int[] rueda, int jugadores, int[] pasos){
    int ganador = 0;
    List<int> Tablero = rueda.ToList();
    Dictionary<int, int>IDvsPuntos = new Dictionary<int, int>();
    int[] players = new int[jugadores];

    //Array con los id d los jugadores
    for (int i = 0; i < jugadores; i++)
    {
        players[i] = i;
    }

    //Metodo para rotaar el array k veces <--
    void Rotar(int k){
        for (int i = 0; i < k; i++)
        {
            Tablero.Add(Tablero[0]);
            Tablero.Remove(Tablero[0]);
        }
    }

    //Agregar players a diccionario
    for (int i = 0; i < jugadores; i++)
    {
        IDvsPuntos.Add(i, 0);
    }

    int contador = 0;
    for (int i = 0; i < pasos.Length; i++)
    {
        if (contador == jugadores)
        {
            contador = 0;
        }
        Rotar(pasos[i]);
        IDvsPuntos[contador] += Tablero[0];
        contador++;
    }

    int max = IDvsPuntos.Values.Max(); 

    ganador = IDvsPuntos.FirstOrDefault(x => x.Value == max).Key;
    
    return ganador;
}


 int[] rueda1 = { 5, 10, 15, 20, 30 }; 
 int jugadores1 = 2; 
 int[] pasos1 = { 0, 0};

EncontrarGanador(rueda1, jugadores1, pasos1);