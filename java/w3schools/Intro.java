/*
Basic concepts and syntax for java
*/

import java.util.Scanner;

public class Intro {
    public static void main(String[] args) {
        // Hello World
        System.out.println("Hello World");

        // Variables
        int myNum = 15;
        String myName = "Dave";
        final int constantNum = 100;
        float myFloatNum = 15f;
        char myLetter = 'Z';
        boolean myBool = true;

        // if...else
        int grade = 80;
        char gradeLetter;

        if (grade >= 90) {
            gradeLetter = 'A';
        } else if (grade >= 70) {
            gradeLetter = 'B';
        } else if (grade >= 70) {
            gradeLetter = 'C';
        } else if (grade >= 60) {
            gradeLetter = 'D';
        } else {
            gradeLetter = 'F';
        }

        // switch statement
        switch (gradeLetter) {
            case 'A':
                System.out.println("You got an A!");
                break;
            case 'B':
                System.out.println("You got a B!");
                break;
            case 'C':
                System.out.println("You got a C");
                break;
            case 'D':
                System.out.println("You got a D");
                break;
            case 'F':
                System.out.println("You fail");
                break;
        }

        // using scanner for input
        Scanner keyb = new Scanner(System.in);
        System.out.print("Enter your name: ");

        String yourName = keyb.next();
        System.out.println("Hello " + yourName);

        // while loops
        int loopNum1 = 0;
        while (loopNum1 < 3) {
            System.out.println("while loop");
            loopNum1++;
        }

        // do while loop
        int loopNum2 = 0;
        do {
            System.out.println("do while loop");
            loopNum2++;
        } while (loopNum2 < 3);

        // for loop
        for (int i = 0; i < 3; i++) {
            System.out.println("For loop");
        }

        // for looping an array
        System.out.println("for looping arrays");
        String[] cars = { "BMW", "Ford", "Audi" };
        for (int i = 0; i < cars.length; i++) {
            System.out.println(cars[i]);
        }

        // foreach looping an array
        System.out.println("foreach looping arrays");
        for (String i : cars) {
            System.out.println(i);
        }

        // two-dimensional array
        System.out.println("two dimensional arrays");
        int[][] myNumbers = { { 1, 2, 3, 4 }, { 5, 6, 7 } };
        for (int i = 0; i < myNumbers.length; i++) {
            for (int j = 0; j < myNumbers[i].length; j++) {
                System.out.println(myNumbers[i][j]);
            }
        }

        keyb.close();
    }
}