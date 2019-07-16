/**
 * Exercise08
 */
import java.util.Scanner;
public class Exercise08 {

    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);
        int cookie_calories=75;
        System.out.print("Enter amount of cookies you ate: ");
        int answer = keyboard.nextInt();

        System.out.println("You ate a total of "+answer*cookie_calories+
        " calories.");
    }
}