/**
 * Exercise12
 */
import java.util.Scanner;
public class Exercise12 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);

        System.out.print("Enter the name of your favourite city: ");
        String city=keyboard.next();

        System.out.println("Characters: "+city.length());
        System.out.println("First character: "+city.charAt(0));
        System.out.println("Upper: "+city.toUpperCase());
        System.out.println("Lower: "+city.toLowerCase());
    }
}