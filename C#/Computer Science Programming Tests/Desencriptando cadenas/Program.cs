using System;

string Desencriptar(char[] alfabeto, char caracter, string mensaje){
    //Deducir el caracter que mas se repite en mensaje
    char caracter_mas_repetido;
    Dictionary<char, int> LetraVSRepeticiones = new Dictionary<char, int>();
    for (int i = 0; i < mensaje.Length; i++)
    {
        int contador = 0;
        for (int j = 0; j < mensaje.Length; j++)
        {
            if (mensaje[i] == mensaje[j])
            {
                contador++;
            }
        }
        if (!LetraVSRepeticiones.ContainsKey(mensaje[i]))
        {
            LetraVSRepeticiones.Add(mensaje[i], contador);  
        }
    }
    int max = LetraVSRepeticiones.Values.Max();
    caracter_mas_repetido = LetraVSRepeticiones.FirstOrDefault(x => x.Value == max).Key;
    
    //Ver cual es la distancia en el alfabeto entre caracter_mas.. y caracter
    int distancia = Array.IndexOf(alfabeto, caracter) - Array.IndexOf(alfabeto, caracter_mas_repetido);

    char GetRealValue(char x){
        int distancialocal = Array.IndexOf(alfabeto, x) + distancia;
        if (distancialocal >= alfabeto.Length)
        {
            distancialocal = distancialocal - alfabeto.Length;
        }
        if (distancialocal < 0)
        {
            distancialocal = alfabeto.Length + distancialocal;
        }
        return alfabeto[distancialocal];     
    }
    //char x = GetRealValue('A');


    //Recorrer el mensaje y agregar a una lista los valores reales
    List<char> respuesta = new List<char>();

    for (int i = 0; i < mensaje.Length; i++)
    {
        respuesta.Add(GetRealValue(mensaje[i]));
    }
    string respuestax = "";
    for (int i = 0; i < respuesta.Count; i++)
    {
        respuestax += respuesta[i].ToString();
    }

    return respuestax;
}



 char[] alfabeto1 = { 'x', '-', 'Q', '1', '*', '0', 'c', 'L', '[' }; 
 char caracter1 = '1'; 
 string msjEncriptado1 = "*[*[xx1-*cL";

System.Console.WriteLine(Desencriptar(alfabeto1, caracter1, msjEncriptado1)); 