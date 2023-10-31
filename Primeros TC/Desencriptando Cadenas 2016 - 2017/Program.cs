class Program
{
    static void Main(){
        string Desencriptr(char[] alfabeto, char caracter, string mensaje){
            string respuesta = "";
            char letra;
            int[] repitencias = new int[mensaje.Length];

//Metodo para sacar la cantidad de veces que se repiten las letras en el mensaje
            for (int i = 0; i < mensaje.Length; i++)
            {
                for (int x = 0; x < mensaje.Length; x++)
                {
                    if (mensaje[i] == mensaje[x])
                    {
                        repitencias[x]++;
                    }
                }
            }

            letra = mensaje[repitencias.Max()];    //El mayor de repitencias es la letra que mas se repite

            int posicionLetra = Array.IndexOf(alfabeto, letra);
            int posicionCharacter = Array.IndexOf(alfabeto, caracter);
            int k = posicionCharacter - posicionLetra;
            if (k < 0)
            {
                k = k *-1;
            }
            

            for (int i = 0; i < mensaje.Length; i++)
            {
                int posicion_corregida = Array.IndexOf(alfabeto, mensaje[i]) - k;
                
                if (posicion_corregida < 0)
                {
                    int bridge_position = posicion_corregida;
                    posicion_corregida = alfabeto.Length + bridge_position;
                }
                respuesta += alfabeto[posicion_corregida]; //Rotar el array
            }
        
            return respuesta;
        }

        char[] alfabeto = {'A', 'B', 'T', 'E'};
        System.Console.WriteLine(Desencriptr(alfabeto, 'A', "EAEBT"));
    }
}