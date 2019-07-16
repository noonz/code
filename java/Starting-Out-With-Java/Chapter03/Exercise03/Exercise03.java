/**
 * Exercise03: Body Mass Index
 * Write a program that calculates and displays a person's BMI. The BMI is often
 * used to determine whether a person with a sedentary lifestyle is overweight
 * or underweight for his or her height. A person's BMI is calculated with the
 * following forumla:
 *      BMI = Weight x 703 / Height(sq.)
 * Where weight is measured in pounds and height is measured in inches. The
 * program should display a message indicating whether the person has optimal
 * weight, is underweight, or is overweight. A sedentary person's weight is 
 * considered optimal if his or her BMI is between 18.5 and 25. If the BMI is
 * less than 18.5, the person is considered underweight. If the BMI value is
 * greater than 25, the person is considered overweight.
 */
import java.util.Scanner;
public class Exercise03 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);

        System.out.printf("BMI Calculator\nEnter your weight in LBS: ");
        double weight=keyboard.nextDouble();

        System.out.printf("Enter your height in inches: ");
        int height=keyboard.nextInt();

        double bmi=weight*703/(height*height);
        System.out.printf("BMI: %.1f.\n",bmi);

        if(bmi < 18.5){
            System.out.printf("You're underweight.");
        }
        else if(bmi>=18.5 && bmi<=25){
            System.out.printf("Your weight is optimal.");
        }
        else{
            System.out.printf("You're overweight.");
        }
    }
}