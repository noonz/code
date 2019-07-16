/**
 * Exercise13
 */
import java.util.Scanner;
public class Exercise13 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);
        double tax=.0675,tip=.20;

        System.out.print("Enter bill amount: $");
        double price=keyboard.nextDouble(),total=price+(tax*price)+
        ((price+price*tax)*tip);

        System.out.println("Price: $"+price+"\nTax: $"+price*tax+"\nTip: $"+
        (price+price*tax)*tip+"\nTotal: $"+total);
    }
}