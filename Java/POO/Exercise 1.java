class Account{
    private String holder;
    private double amount;
    public Account(String Holder){ //Only  Holder required
        holder = Holder;
        amount = 0.00;
    }
    public Account(String Holder, double Amount){  //Holder and Amount required
        holder = Holder;
        amount = Amount;
    }
    public String getHolder(){
        return  holder;
    }
    public double getAmount(){
        return amount;
    }
    public String toString(){
        return String.valueOf(getAmount());
    }
    public void deposite(double x){
        if (x > 0) {
            amount += x;
        }
    }
    public void withdraw(double x){
        x = x*(-1);
        if (x < 0) {
            if (amount + x < 0) {
                amount = 0;
            }
            else {
                amount = amount + x;
            }
        }
    }
}
public class Main {
    public static void main(String[] args) {
        Account myaccount = new Account("Daniel", 100);
        myaccount.withdraw(10000);
        System.out.printf(myaccount.toString());
    }
}