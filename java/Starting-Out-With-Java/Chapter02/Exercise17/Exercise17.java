/**
 * Exercise17
 */
import java.util.Scanner;
public class Exercise17 {

    public static void main(String[] args) {
        Scanner keyboard=new Scanner(System.in);
        // Recipe ingredients per 48 cookies
        double c_of_sugar=1.5,c_of_butter=1,c_of_flour=2.75;
        // Recipe ingredients per cookie
        double per_cookie_sugar=c_of_sugar/48,per_cookie_butter=c_of_butter/48;
        double per_cookie_flour=c_of_flour/48;

        System.out.print("Enter amount of cookies to make: ");
        int cookies=keyboard.nextInt();

        System.out.println("\nApprox. Ingredients for your batch in cups\n"+
        "Sugar: "+per_cookie_sugar*cookies+"\nButter: "+
        per_cookie_butter*cookies+"\nFlour: "+per_cookie_flour*cookies);
    }
}