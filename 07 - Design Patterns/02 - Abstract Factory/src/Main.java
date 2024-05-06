abstract class Example1{
    public void exampleMethod(){
        System.out.println("Metoddo de la clase Example 1");
    }
}
class Example2 extends Example1{
}

public class Main {
    public static void main(String[] args) {
        Example2 a = new Example2();
        a.exampleMethod();

    }
}