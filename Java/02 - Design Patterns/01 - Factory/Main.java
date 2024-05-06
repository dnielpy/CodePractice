import java.awt.*;
import java.util.concurrent.locks.ReadWriteLock;

interface Order{
    int getCost();
    String getDeliveryTime();
}

//Orders Objects
class RegularOrder implements Order{
    @Override
    public int getCost() {
        return 100;
    }

    @Override
    public String getDeliveryTime() {
        return "1 day";
    }
}
class RushOrder implements Order{
    @Override
    public int getCost() {
        return 200;
    }

    @Override
    public String getDeliveryTime() {
        return "4 hours";
    }
}
class InternationalOrder implements Order{
    @Override
    public int getCost() {
        return 500;
    }

    @Override
    public String getDeliveryTime() {
        return "7 days";
    }
}

//Objects Factory
class OrdersFactory {
    public Order createOrder(int id) {
        if (id == 1) {
            return new RegularOrder();
        }
        if (id == 2) {
            return new RushOrder();
        }
        if (id == 3) {
            return new InternationalOrder();
        }
        else {
            return null;
        }
    }
}

//Recipe of all orders
class Recipe{
    Order[] my_orders;
    int real_cost;
    String real_delivery_time = "";

    //Constructor
    public Recipe(Order[] MyOrders){
        my_orders = MyOrders;
        realCost();
        setRealDeliveryTime();
    }
    //Get real cost
    private void realCost(){
        for (int i = 0; i < my_orders.length; i++) {
            real_cost += my_orders[i].getCost();
        }
    }
    private void setRealDeliveryTime(){
        for (int i = 0; i < my_orders.length; i++) {
            if (my_orders[i].getDeliveryTime() == "1 week") {
                real_delivery_time = "1 week";
                break;
            }
            if (my_orders[i].getDeliveryTime() == "1 day") {
                real_delivery_time = "1 day";
                break;
            }
            if (my_orders[i].getDeliveryTime() == "4 hours") {
                real_delivery_time = "4 hours";
                break;
            }
        }
    }
    public String getRecipe(){
        return "Your order its been procesed. Cost: " + String.valueOf(real_cost) + "\nDelivery Time: "+ real_delivery_time;
    }
}

class Main{
     public static void main(String[] args) {
         OrdersFactory ordenes = new OrdersFactory();
         Order orden_1 = ordenes.createOrder(1);


         System.out.println(String.valueOf(orden_1.getCost()));
     }

}