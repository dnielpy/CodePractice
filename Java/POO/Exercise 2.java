import javax.sound.midi.SysexMessage;
import java.util.Random;
import java.util.Scanner;

class Person{
    protected String name = "";
    protected int age = 0;
    protected int id;
    protected String gender = "M";
    protected double height = 0;
    protected double weight = 0;

    public Person(){
        id = generateID();
    }

    public Person(String Name, int Age, String Gender){
        name = Name;
        age = Age;
        gender = Gender;
        id = generateID();
    }
    public Person(String Name, int Age, String Gender, double Height, double Weight){
        name = Name;
        age = Age;
        gender = Gender;
        height = Height;
        weight = Weight;
        id = generateID();
    }
    public int checkBMI(){  //-1, 0, 1
        double BMI =  weight/height;
        if (BMI < 20) {
            return -1;
        }
        if (BMI >= 20 && BMI <= 25) {
            return  0;
        }
        else {
            return 1;
        }
    }
    public boolean isAdult(){
        if (age >= 18){
            return true;
        }
        else {
            return false;
        }
    }
    public String checkGender(){
        if (gender == "M") {
            return "M";
        }
        else {
            return "F";
        }
    }
    public int generateID(){
        Random random = new Random();
        int rand = random.nextInt(100000);
        return  rand;
    }

    public String toString() {
        return "Person{" +
                "name='" + name + '\'' +
                ", age=" + age +
                ", id=" + id +
                ", gender='" + gender + '\'' +
                ", height=" + height +
                ", weight=" + weight +
                '}';
    }

    public String getName(){
        return name;
    }

    public double getHeight() {
        return height;
    }

    public double getWeight() {
        return weight;
    }

    public int getAge() {
        return age;
    }

    public String getGender() {
        return gender;
    }
    public void setName(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    public void setHeight(double height) {
        this.height = height;
    }
}

public class Main {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        System.out.print("¿Cuál es tu nombre? ");
        String nombre = entrada.nextLine();
        System.out.print("Ingresa la edad: ");
        int edad = entrada.nextInt();
        System.out.print("Ingresa el genero: ");
        String genero = entrada.nextLine();
        System.out.print("Ingresa el peso: ");
        int peso = entrada.nextInt();
        System.out.print("Ingresa la altura: ");
        int altura = entrada.nextInt();

        Person person1 = new Person(nombre, edad, genero, peso, altura);
        Person person2 = new Person("daniel", 21, "M");
        Person person3 = new Person();

        person3.setName("camion");
        person3.setAge(50);
        person3.setGender("M");
        person3.setHeight(10.0);
        person3.setWeight(20.0);

        System.out.printf(String.valueOf(person1.toString()));
        System.out.printf(String.valueOf(person2.toString()));
        System.out.printf(String.valueOf(person3.toString()));
    }
}


