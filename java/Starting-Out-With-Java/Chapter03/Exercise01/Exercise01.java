/**
 * Exercise01: Roman Numerals
 * Write a program that prompts the user to Enter a number between 1-10.
 * The program should display the Roman Numeral equivalent for that number.
 */
import java.util.Scanner;
public class Exercise01 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);

        System.out.printf("Enter a number between 1-10: ");
        int number=keyboard.nextInt();

        switch(number){
            case 1:
                System.out.printf("Roman numeral: I");
                break;
            case 2:
                System.out.printf("Roman numeral: II");
                break;
            case 3:
                System.out.printf("Roman numeral: III");
                break;
            case 4:
                System.out.printf("Roman numeral: IV");
                break;
            case 5:
                System.out.printf("Roman numeral: V");
                break;
            case 6:
                System.out.printf("Roman numeral: VI");
                break;
            case 7:
                System.out.printf("Roman numeral: VII");
                break;
            case 8:
                System.out.printf("Roman numeral: VIII");
                break;
            case 9:
                System.out.printf("Roman numeral: IX");
                break;
            case 10:
                System.out.printf("Roman numeral: X");
                break;
            default:
                System.out.printf("Number not in range 1-10.");
                break;
        }
        
    }
}