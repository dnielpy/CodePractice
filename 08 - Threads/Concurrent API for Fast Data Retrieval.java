import java.lang.InterruptedException;
import java.util.concurrent.*;

class CustomerAPI {
    int price = 100;
    int availability = 1;   //0 false - 1 true
    int delivery_time = 4; //hours

    private void Await(int seconds){
        try {
            Thread.sleep(seconds * 1000);
        }catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
    public int getPrice() {
        return price;
    }
    public int getAvailability() {
        Await(3);
        return this.availability;
    }

    public int getDelivery_time() {
        Await(4);
        return delivery_time;
    }

    public CustomerAPI(){

    }
}

class ClientAPI extends Thread{
    private CustomerAPI customer_api;

    public ClientAPI(CustomerAPI customerAPI){
        customer_api = customerAPI;
    }

    public int[] getFastData() throws ExecutionException, InterruptedException {
        //Aqui va la logica concurrente
        int[] data = new int[3];

        //We create the threads we need
        ExecutorService executorservice = Executors.newFixedThreadPool(3);

        //Define what task we need
        Callable<Integer> priceCallable = () -> customer_api.getPrice();
        Callable<Integer> availabilityCallable = () -> customer_api.getAvailability();
        Callable<Integer> deliveryCallable = () -> customer_api.getDelivery_time();

        //Send this tasks to the ExecutorService
        Future<Integer> priceFuture = executorservice.submit(priceCallable);
        Future<Integer> availabilityFuture = executorservice.submit(availabilityCallable);
        Future<Integer> deliveyFuture = executorservice.submit(deliveryCallable);

        data[0] = priceFuture.get();
        data[1] = availabilityFuture.get();
        data[2] = deliveyFuture.get();

        executorservice.shutdown();

        return data;
    }

    //Non-Concurrent Getter
    public int[] getSlowData() {
        int[] data = new int[3];
        data[0] = customer_api.getPrice();
        data[1] = customer_api.getAvailability();
        data[2] = customer_api.getDelivery_time();
        return data;
    }
}

public class Main {
    public static void main(String[] args) throws ExecutionException, InterruptedException {
        CustomerAPI customerAPI = new CustomerAPI();
        ClientAPI clientAPI = new ClientAPI(customerAPI);

        long inicio = System.nanoTime();
        // Ejecuta la función aquí
        clientAPI.getSlowData();
        long fin = System.nanoTime();
        long tiempoEjecucion = fin - inicio;
        System.out.println("Lineal function procces-time: " + tiempoEjecucion + " nanosegundos");

        long inicio2 = System.nanoTime();
        // Ejecuta la función aquí
        clientAPI.getFastData();
        long fin2 = System.nanoTime();
        long tiempoEjecucion2 = fin2 - inicio2;
        System.out.println("Concurrent function procces-time" + tiempoEjecucion2 + " nanosegundos");

    }
}
