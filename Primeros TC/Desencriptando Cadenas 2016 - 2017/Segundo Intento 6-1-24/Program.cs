string Desencriptar(char[] alfabeto, char caracter, string mensaje)
    {
        //Sacar el elemento que mas se repite en un array
        int[] repitencias = new int[mensaje.Length];
        for (int x = 0; x < mensaje.Length; x++)
        {
            for (int y = 0; y < mensaje.Length; y++)
            {
                if (mensaje[x] == mensaje[y])
                {
                    repitencias[x] = repitencias[x] + 1;
                }
            }
        }

        //sacar la posicion donde se encuentra la maxima repitencia
        int max = repitencias.Max();
        int posicion = Array.IndexOf(repitencias, max); // => esta es la posicion del elemento que hay que cambiar
        char caractermasrepetido = mensaje[posicion];
        List<string> respuesta = new List<string>();

        //Sakr k
        //sacar k del caracter cambiado
        int kx = 0;
        for (int x = 0; x < alfabeto.Length; x++)
        {
            if (alfabeto[x] == caractermasrepetido)
            {
                kx = x;
            }
        }

        //sacar k del caracter original
        int ky = 0;
        for (int x = 0; x < alfabeto.Length; x++)
        {
            if (alfabeto[x] == caracter)
            {
                ky = x;
            }
        }

        int k = ky - kx;

        if (k < 0)
        {
            k = mensaje.Length + k - 1;
        }
        else
        {
            k = ky - kx;  
        }

        //agregar los caracteres a respuesta
        for (int i = 0; i < mensaje.Length; i++)
        {
            int index = Array.IndexOf(alfabeto, mensaje[i]) + k;
            if (index < alfabeto.Length)
            {
                respuesta.Add(alfabeto[index].ToString()) ;  
            }
            else
            {
                index = index - alfabeto.Length;
                respuesta.Add(alfabeto[index].ToString()) ;  
            }
        }
        
        string resultado = "";
        
        for (int i = 0; i < respuesta.Count; i++)
        {
            resultado += respuesta[i].ToString();
        }

        return resultado;
    }


char[] alfabeto1 = { 'x', '-', 'Q', '1', '*', '0', 'c', 'L', '[' };
char caracter1 = '1';
string msjEncriptado1 = "*[*[xx1-*cL";


System.Console.WriteLine(Desencriptar(alfabeto1, caracter1, msjEncriptado1));