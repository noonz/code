/**
 * Exercise19
 */
public class Exercise19 {

    public static void main(String[] args) {
        // Joe's initial stock purchases details
        int shares=1000;
        double purchase_price_per=32.87,commission=0.02;
        double total_purchase=shares*purchase_price_per;
        double purchase_commission=total_purchase*commission;

        // Joe's stock sale details
        double price_sold_per=33.92;
        double total_sale=shares*price_sold_per;
        double sale_commission=total_sale*commission;

        System.out.println("Joe paid $"+(total_purchase+purchase_commission)+
        " for his stock (with commission).");
        System.out.println("Joe paid $"+purchase_commission+" in comission.");
        System.out.println("\nJoe sold his stock for $"+
        (total_sale+sale_commission)+" (with commission).");
        System.out.println("Joe paid another sale comission of $"+
        sale_commission);

        double profit=(total_sale+sale_commission)-+
        (total_purchase+purchase_commission);

        System.out.println("\nJoe's profit was $"+profit);
    }
}