/**
 * Exercise07
 */
import java.util.Scanner;
public class Exercise07 {

    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);
        int purchase;
        double state_tax=0.04,country_tax=0.02;

        System.out.print("Enter a purchase amount: $");
        purchase = keyboard.nextInt();

        System.out.println("\nPurchase: $"+purchase+"\nState Sales Tax: $"+
        (purchase*state_tax)+"\nCountry Sales Tax: $"+(purchase*country_tax)+
        "\nTotal Sales Tax: $"+(purchase*state_tax+purchase*country_tax)+
        "\nTotal Sales: $"+(purchase+
        ((purchase*state_tax+purchase*country_tax))));
    }
}