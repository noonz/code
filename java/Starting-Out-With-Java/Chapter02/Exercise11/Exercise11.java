/**
 * Exercise11
 */
import java.util.Scanner;
public class Exercise11 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);

        System.out.print("Enter price of your circuit board: $");
        double price=keyboard.nextDouble(),profit=price*0.4;

        System.out.print("Price: $"+price+"\nProfit(40%): $"+profit+
        "\nTotal: $"+(price+profit));
    }
}