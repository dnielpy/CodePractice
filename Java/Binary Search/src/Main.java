class Search{
    public int BinarySearch(int x, Integer[]y) {
        int l = 0, r = y.length - 1;
        while (l <= r) {
            int m = l + (r - l) / 2;
            if (y[m] == x)
                return m;
            if (y[m] < x)
                l = m + 1;
            else
                r = m - 1;
        }
        return -1;
    }
}
public class Main {
    public static void main(String[] args) {
        Integer[] a = {1,2,3,4,5,6,7,8};
        Search b = new Search();
        Integer c = b.BinarySearch(7, a);
        System.out.printf(c.toString());
    }
}