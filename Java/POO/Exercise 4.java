import java.util.Arrays;
import java.util.Dictionary;
import java.util.OptionalLong;

//Class Appliance
class Appliance{
    String[] availables_colors = {"white", "black", "red", "blue", "gray"};
    char[] availables_energy = {'A', 'B', 'C', 'D', 'E', 'F'};

    int price = 100;
    double weight = 5;
    String color = "white";
    char energy_consumition = 'F';

    //Constructors
    public Appliance(){
    }
    public Appliance(int Price, double Weight){
        price = Price;
        weight = Weight;
    }
    public Appliance(int Price, String Color, char Energy, double Weight){
        price = Price;
        weight = Weight;
        color = Color;
        energy_consumition = Energy;
        checkEnergyConsumition();
    }

    //Getters
    public int getPrice() {
        return price;
    }
    public String getColor() {
        return color;
    }
    public char getEnergy_consumition() {
        return energy_consumition;
    }
    public double getWeight() {
        return weight;
    }

    //checkEnergyConsumitions
    private void checkEnergyConsumition(){
        int indice = Arrays.binarySearch(this.availables_energy, this.energy_consumition);
        if (!(indice >= 0)) {
            this.energy_consumition = 'F';
        }
    }

    //checkColor
    private void checkColor(){
        this.color.toLowerCase();
        if (!(Arrays.asList(this.availables_colors).contains(this.color))) {
            this.color = "white";
        }
    }

    //finalPrice
    public void finalPrice(){
        int[] energy_prices = {100, 80, 60, 50, 30, 10};
        int[] weight_prices = {10, 50, 80, 100};

        //Incress price by energy
        int energy_indices = Arrays.binarySearch(this.availables_energy, this.energy_consumition);
        this.price = this.price + energy_prices[energy_indices];

        //Incress price by weight
        int aument = 0;
        if (this.weight >= 0 && this.weight <= 19) {
            aument = 10;
        }
        if (this.weight >= 20 && this.weight <= 49) {
            aument = 50;
        }
        if (this.weight >= 50 && this.weight <= 79) {
            aument = 80;
        }
        if (this.weight >= 80) {
            aument = 100;
        }
        this.price = this.price + aument;
    }
}

//SubClass WashingMachine
class WashingMachine extends Appliance{
    int load = 5;

    //Constructors
    public WashingMachine(){
        super();
    }
    public WashingMachine(int Price, double Weight){
        super(Price, Weight);
    }
    public  WashingMachine(int Price, double Weight, String Color, char Energy, int Load){
        super(Price, Color, Energy, Weight);
        load = Load;
    }

    //Getter
    public int getLoad() {
        return load;
    }

    //finalPrice()
    public void finalPrice(){
        super.finalPrice();
        if (load > 30) {
            this.price += 50;
        }
    }
}

//SubClass Television
class Television extends Appliance{
    int resolution = 20;
    boolean TDT_tuner = false;

    //Contructors
    public Television(){
        super();
    }

    public Television(int Price, double Weight){
        super(Price, Weight);
    }
    public Television(int Price, double Weight, String Color, char Energy, int Resolution, boolean TDT){
        super(Price, Color, Energy, Weight);
        resolution = Resolution;
        TDT_tuner = TDT;
    }

    //Getters
    public int getResolution() {
        return resolution;
    }
    public boolean getTDT_Tuner(){
        return TDT_tuner;
    }

    //finalPrice
    public void finalPrice(){
        super.finalPrice();
        if (this.resolution > 40) {
            if (this.TDT_tuner == true) {
                this.price = (int) (this.price * 1.3);
                this.price += 50;
            }
            else {
                this.price += 50;
            }
        }
    }


}

public class Main {
    public static void main(String[] args) {
        Appliance[] electrodomesticos = new Appliance[5];

        electrodomesticos[0] = new Television(300, 20);
        electrodomesticos[1] = new WashingMachine(300, 20);
        electrodomesticos[2] = new Television(40, 400);
        electrodomesticos[3] = new WashingMachine(300, 40, "White", 'E', 7);
        electrodomesticos[4] = new Television(200, 20, "Black", 'E', 50, true);

        int television_prices = 0;
        int washingmachine_prices = 0;

        for (int i = 0; i < electrodomesticos.length; i++) {
            electrodomesticos[i].finalPrice();
            if (electrodomesticos[i] instanceof Television){
                television_prices += electrodomesticos[i].getPrice();
            }
            if (electrodomesticos[i] instanceof WashingMachine){
                washingmachine_prices += electrodomesticos[i].getPrice();
            }
        }

        System.out.println("El precio de todos los televisores es: " + String.valueOf(television_prices));
        System.out.println("El precio de todas las lavadoras es: " + String.valueOf(washingmachine_prices));

    }
}
