/**
 * Exercise04: Test scores and Grade
 * Write a program that has variables to hold three test scores. The program
 * should ask the user to enter three test scores and then assign the values
 * entered to the variables. The program should display the average of the test
 * scores and the letter grade that is assigned for the test score average. Use
 * the grading scheme in the following table:
 * 90-100 ---> A
 * 80-89  ---> B
 * 70-79  ---> C
 * 60-69  ---> D
 * <60    ---> F
 */
import java.util.Scanner;
public class Exercise04 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);

        System.out.printf("Enter test 1 score: ");
        double test_one=keyboard.nextDouble();

        System.out.printf("Enter test 2 score: ");
        double test_two=keyboard.nextDouble();

        System.out.printf("Enter test 3 score: ");
        double test_three=keyboard.nextDouble();

        double avg_score=(test_one+test_two+test_three)/3;

        if(avg_score>=90)
            System.out.printf("Your average is: %.0f\nGrade: A",avg_score);
        else if(avg_score>=80)
            System.out.printf("Your average is: %.0f\nGrade: B",avg_score);
        else if(avg_score>=70)
            System.out.printf("Your average is: %.0f\nGrade: C",avg_score);
        else if(avg_score>=60)
            System.out.printf("Your average is: %.0f\nGrade: D",avg_score);
        else
            System.out.printf("Your average is: %.0f\nGrade: FAIL",avg_score);
    }
}