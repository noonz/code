/**
 * Exercise16
 */
public class Exercise16 {

    public static void main(String[] args) {
        int customers=12467;
        
        System.out.println("Customers that purchase 1+ drinks per week: "+
        (int)(customers*.14)+"\nCustomers that prefer citrus-flavor: "+
        (int)(customers*.64));
    }
}