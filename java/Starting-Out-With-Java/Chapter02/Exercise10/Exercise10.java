/**
 * Exercise10
 */
import java.util.Scanner;
public class Exercise10 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);

        System.out.print("Enter test 1 score: ");
        int test_one=keyboard.nextInt();

        System.out.print("Enter test 2 score: ");
        int test_two=keyboard.nextInt();

        System.out.print("Enter test 3 score: ");
        int test_three=keyboard.nextInt();
        int avg=(test_one+test_two+test_three)/3;

        System.out.println("\nAverage test score: "+avg);
    }
}