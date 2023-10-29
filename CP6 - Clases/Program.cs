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
}

class Program
{
    static void Main(){
        int[] x = {1,2,3,54,9};

        MyArray objeto1 = new MyArray(x);

        objeto1.Rotar(-2);            
    }
}