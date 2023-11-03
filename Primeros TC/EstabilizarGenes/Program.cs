class Program
{
    static void Main(){
        static string EstabilizaGen(string gen)
            {
                string solucion = "";

                string[] CadenasPosibles = new string[gen.Length];

                //Algoritmo para saber si un gen está definido
                bool Definido(string cadena){
                    string[] genes = {"A", "G", "T", "C"};
                    for (int x = 0; x < genes.Length; x++)
                    {
                        int contador = 0;
                        for (int y = 0; y < cadena.Length; y++)
                        {
                            if (genes[x] == cadena[y].ToString())
                            {
                                contador++;
                                if (contador > 2)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    return true;
                }

                string Eliminar(string cadena, string subcadena){
                    string respuesta = "";
                    string cadena_bridge = "";
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        cadena_bridge = "";
                        cadena_bridge += cadena[i];
                        for (int x = i+1; x < cadena.Length; x++)
                        {
                            cadena_bridge += cadena[x].ToString();
                            if (cadena_bridge == subcadena)
                            {
                                //Crear algo para devolver cadena sin que contenga subcadena
                                
                            }
                        }
                    }
                    return respuesta;
                }

                System.Console.WriteLine(Eliminar(gen, "TC"));
                return solucion;
            }
            EstabilizaGen("AATCGG");
        }
    }