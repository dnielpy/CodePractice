interface vehicle {
    Vehicle createVehicule(int id);
}


class Vehicle{

}

class Car extends Vehicle {

}

//Vehicle Factory
class VehicleFactory implements vehicle {   //this class returns differents kind of Vehicle depends of conditions
    @Override
    public Vehicle  createVehicule(int id){
        if (id == 1) {
            return new Car();
        }
        else {
            return null;
        }
    }
}


public class Main {
    public static void main(String[] args) {

    }
}