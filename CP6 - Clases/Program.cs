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
    
}

class Program
{
    static void Main(){
        int[] x = {1,2,3,54,1};

        MyArray objeto1 = new MyArray(x);

        objeto1.Insertar(3, 11);
    }
}