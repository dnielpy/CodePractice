import java.util.Scanner;

class Vehicle{
    protected int cost;
    protected String production_time;

    public int getCost(){
        return cost;
    }
    public String getProduction_time() {
        return production_time;
    }
}

class Car extends Vehicle {
    private int cost = 1000;
    private String production_time = "1 month";
    @Override
    public int getCost() {
        return cost;
    }
    @Override
    public String getProduction_time() {
        return production_time;
    }
}

class Moto extends Vehicle {
    private int cost = 500;
    private String production_time = "2 weeks";
    @Override
    public int getCost() {
        return cost;
    }
    @Override
    public String getProduction_time() {
        return production_time;
    }
}

class Camion extends Vehicle {
    private int cost = 3000;
    private String production_time = "4 month";
    @Override
    public int getCost() {
        return cost;
    }
    @Override
    public String getProduction_time() {
        return production_time;
    }
}

//Vehicle Factory
class VehicleFactory {   //this class returns differents kind of Vehicle depends of conditions
    public Vehicle  createVehicle(int id){
        if (id == 1) {
            return new Car();
        }
        if (id == 2) {
            return new Moto();
        }
        if (id == 3) {
            return new Camion();
        }
        else {
            return null;
        }
    }
}


public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        VehicleFactory factory = new VehicleFactory();
        Vehicle[] vehicles = new Vehicle[10]; // Máximo de 10 vehículos
        int vehicleCount = 0;

        while (true) {
            System.out.println("nMenú de vehículos:");
            System.out.println("1. Crear coche");
            System.out.println("2. Crear moto");
            System.out.println("3. Crear camión");
            System.out.println("4. Ver vehículo");
            System.out.println("5. Salir");
            System.out.print("Ingrese una opción: ");
            int option = sc.nextInt();

            switch (option) {
                case 1:
                    vehicles[vehicleCount++] = factory.createVehicle(1);
                    System.out.println("Coche creado");
                    break;
                case 2:
                    vehicles[vehicleCount++] = factory.createVehicle(2);
                    System.out.println("Moto creada");
                    break;
                case 3:
                    vehicles[vehicleCount++] = factory.createVehicle(3);
                    System.out.println("Camión creado");
                    break;
                case 4:
                    if (vehicleCount == 0) {
                        System.out.println("No hay vehículos para mostrar");
                    } else {
                        for (int i = 0; i < vehicleCount; i++) {
                            System.out.println("nVehículo #" + (i + 1));
                            System.out.println("  Costo: " + vehicles[i].getCost());
                            System.out.println("  Tiempo de producción: " + vehicles[i].getProduction_time());
                        }
                    }
                    break;
                case 5:
                    System.out.println("Saliendo...");
                    sc.close();
                    return;
                default:
                    System.out.println("Opción inválida");
            }
        }
    }
}
