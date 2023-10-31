public class MyArray
{
    private int[] items;

    public int Count(){
        return items.Length;
    }
    public MyArray(int[] enteros){
        items = enteros;
    }

    public int Chequear(int i){
        return items[i];
    }
    public void Reverse(){
        Array.Reverse(items);
    }
    public void Delete(int pos){
        int[] posdeleted = new int[items.Length];
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != pos)
            {
                posdeleted[i] = items[i];
            }
        }
        for (int i = 0; i < posdeleted.Length; i++)
        {
            items[i] = posdeleted[i];
        }
        Array.Resize(ref items, items.Length - 1);
        System.Console.WriteLine(items.Length);
    }
    public void Insertar(int pos, int x){
        int[] posagregated = new int[items.Length + 1];
        for (int i = 0; i < posagregated.Length; i++)
        {
            if (i < pos)
            {
                posagregated[i] = items[i];
            }
            if (i == pos)
            {
                posagregated[i] = x;
            }
            if (i > pos)
            {
                posagregated[i] = items[i-1];
            }
        }
        Array.Resize(ref items, items.Length+1);
        for (int i = 0; i < posagregated.Length; i++)
        {
            items[i] = posagregated[i];
        }
    }
    public void Rotar(int x){
        if (x > 0)
        {
            for (int i = 0; i < x; i++)
            {
            int[] temp= new int[items.Length];
            for (int t = 0; t < items.Length; t++)
            {
                temp[t] = items[t];
            }
            int last = items[items.Length - 1];
            for (int y = 0; y < items.Length - 1; y++)
            {
                items[y+1] = temp[y];
            }
            items[0] = last;
        }
        }
        if (x < 0)
        {
            x = -1*x;
            for (int i = 0; i < x; i++)
            {
            int[] temp= new int[items.Length];
            for (int t = 0; t < items.Length; t++)
            {
                temp[t] = items[t];
            }
            int first = items[0];
            for (int y = 0; y < items.Length - 1; y++)
            {
                items[y] = temp[y+1];
            }
            items[items.Length-1] = first;
            }
        }  
    }   

    public void InvertirSubcadenas(int[] x, int y){
        List<int> resultado = new List<int>();
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] % y == 0) //El numero es multiplo de k
            {
                if (i + 1 - y >= 0) //Si existen k lugares antes del numero en el array
                {
                    for (int t = 0; t <= i; t++)
                    {
                        if (resultado.Contains(x[i-t]) == false)
                        {
                            resultado.Add(x[i-t]);
                        }
                    }
                }
            }
        }
    }

    public void BoubbleSort(int[] x){
        while(true){
        bool changes = false;
        for (int i = 0; i < x.Length; i++)
        {
            if (i+1 < x.Length)
            {
                int bridge = 0;
                if (x[i] > x[i+1])
                {
                    bridge = x[i];
                    x[i] = x[i+1];
                    x[i+1] = bridge;
                    changes = true;
                }
            }
            if (changes == false)
            {
                break;
            }
        }
        }
    }
}

class Program
{
    static void Main(){
        int[] x = {4,3,1,9,5,7};

        MyArray objeto1 = new MyArray(x);

        objeto1.BoubbleSort(x);           
    }
}