/**
 * Exercise18
 */
import java.util.Scanner;
public class Exercise18 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);
        String name,age,city,college,profession,animal,pet_name;
        
        System.out.print("Enter your name: ");
        name=keyboard.next();

        System.out.print("Enter an age: ");
        age=keyboard.next();

        System.out.print("Enter a city name: ");
        city=keyboard.next();

        System.out.print("Enter a college name: ");
        college=keyboard.next();

        System.out.print("Enter a profession: ");
        profession=keyboard.next();

        System.out.print("Enter an animal: ");
        animal=keyboard.next();

        System.out.print("Enter a pet name: ");
        pet_name=keyboard.next();

        System.out.print("There was a person named "+name+" who lived in "+
        city+". At the age of "+age+", "+name+" went to college at "+college+
        ". "+name+" graduated and went to work as a "+profession+". Then, "+
        name+" adopted a(n) "+animal+" named "+pet_name+". They both lived"+
        " happily ever after!");

    }
}