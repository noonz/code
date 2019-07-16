/**
 * Exercise02: Magic Dates
 * Write a program that asks the user to enter a month (in numeric form), a day
 * and a two-digit year. The program should then determine whether the month
 * times the day is equal to the year. If so, it should display a message saying
 * the date is magic. Otherwise, it should display a message saying the date
 * is not magic.
 */
import java.util.Scanner;
public class Exercise02 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);

        System.out.printf("Enter a month in numeric form(ie. 02): ");
        int month=keyboard.nextInt();

        System.out.printf("Enter a day in numeric form(ie. 02): ");
        int day=keyboard.nextInt();

        System.out.printf("Enter a two-digit year in numeric form(ie. 02): ");
        int year=keyboard.nextInt();

        if (month*day==year){
            System.out.printf("Your date is a magic date.");
        
        }
        else {
            System.out.printf("Your date is not a magic date.");
        }
    }
}