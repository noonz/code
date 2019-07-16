/**
 * Exercise14
 */
import java.util.Scanner;
public class Exercise14 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);

        System.out.print("Enter amount of girls in class: ");
        int girls=keyboard.nextInt();
        
        System.out.print("Enter amount of boys in class: ");
        int boys=keyboard.nextInt();
        double total_students=girls+boys;

        System.out.println("Percent of each gender in class\nGirls: %"+
        girls/total_students*100+"\nBoys: %"+boys/total_students*100);
    }
}