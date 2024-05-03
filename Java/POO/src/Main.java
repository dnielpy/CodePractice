import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Objects;

class MyArray{
    public Integer[] items ;
    private int getCount() {
        return items.length;
    }
    public MyArray(Integer[] enteros){
        items = enteros;
    }
    public int CheckPosition(int i){
        return items[i];
    }
    public void Invertir(){
        int[] y = new int[getCount()];
        for (int i = 0; i < getCount(); i++) {
            y[i] = items[i];
        }
        for (int i = 0; i < getCount(); i++) {
            items[i] = y[getCount()-1-i];
        }
    }
    public void EliminarPos(int pos){
        List<Integer> temp = new ArrayList<Integer>();
        for (int i = 0; i < items.length; i++) {
            temp.add(items[i]);
        }
        temp.remove(pos);
        items = temp.toArray(new Integer[0]);   //Castear una lista en un array
    }

    public void EliminarOcurrencias(Integer x){
        List<Integer> temp = new ArrayList<Integer>();
        for (int i = 0; i < items.length; i++) {
            temp.add(items[i]);
        }
        while (temp.contains(x)) {
            temp.remove(x);         //Joyita
        }
        items = temp.toArray(new Integer[0]);   //Castear una lista en un array
    }
    public void Insertar(int x, int y){
        List<Integer> temp = new ArrayList<Integer>();
        for (int i = 0; i < items.length; i++) {
            temp.add(items[i]);
        }
        temp.add(x, y);
        items = temp.toArray(new Integer[0]);   //Castear una lista en un array
    }
    public void Rotar(int n){
        List<Integer> temp = new ArrayList<Integer>();
        for (int i = 0; i < items.length; i++) {
            temp.add(items[i]);
        }
        if (n > 0) {    //derecha
            for (int i = 0; i < n; i++) {
                temp.addFirst(temp.getLast());
                temp.removeLast();
            }
        }
        if (n < 0) {
            for (int i = 0; i > n; i--) {
                temp.addLast(temp.getFirst());
                temp.removeFirst();
            }

        }
        items = temp.toArray(new Integer[0]);   //Castear una lista en un array
    }
}

public class Main {
    public static void main(String[] args) {
        Integer[] b = {1,2,3,4};
        MyArray a = new MyArray(b);
        a.Rotar(-2);
        System.out.printf(Arrays.toString(a.items));
    }
}