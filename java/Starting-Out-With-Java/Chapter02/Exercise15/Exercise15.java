/**
 * Exercise15
 */
public class Exercise15 {

    public static void main(String[] args) {
        int shares=600;
        double share_purchase=21.77,commission=0.02;
        double total_stock_price=shares*share_purchase;
        double total_cost=total_stock_price+(total_stock_price*commission);

        System.out.println("Amount paid for stock: $"+total_stock_price+
        "\nCommission: $"+total_stock_price*commission+"\nTotal amount: $"+
        total_cost);
    }
}