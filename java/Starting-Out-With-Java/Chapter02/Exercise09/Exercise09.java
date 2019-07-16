/**
 * Exercise09
 */
import java.util.Scanner;
public class Exercise09 {

    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);

        System.out.print("Enter miles travelled: ");
        int miles=keyboard.nextInt();

        System.out.print("Enter gallons of gas used: ");
        double gas=keyboard.nextDouble(), mpg=miles/gas;

        System.out.print("Total MPG: " + mpg);
    }
}