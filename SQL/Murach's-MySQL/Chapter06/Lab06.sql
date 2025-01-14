/*noonz
Database Design STY1211
Question 1:
Write a SELECT statement that returns these columns:
The count of the number of orders in the Orders table
The sum of the tax_amount columns in the Orders table*/
SELECT COUNT(*) AS number_of_orders,
        SUM(tax_amount) AS total_tax_sum
FROM my_guitar_shop.orders;

/*Question 2:
Write a SELECT statement that returns one row for each category that has 
products with these columns:
    The category_name column from the Categories table
    The count of the products in the Products table
    The list price of the most expensive product in the Products table
Sort the result set so the category with the most products appears first*/
SELECT DISTINCT
    c.category_name,
    COUNT(p.product_id) AS number_of_products,
    MAX(p.list_price) AS most_expensive_product
FROM
    my_guitar_shop.categories c
        JOIN
    my_guitar_shop.products p USING (category_id)
GROUP BY c.category_name
ORDER BY COUNT(p.product_id) DESC;

/*Question 3:
Write a SELECT statement that returns one row for each customer that
has orders with these columns:
-The email_address column from the Customers table
-The sum of the item price in the Order_Items table multiplied by the
    quantity in the Order_Items table
-The sum of the discount amount column in the Order_Items table
    multiplied by the quantity in the Order_Items table
Sort the result set in descending sequence by the item price total
for each customer*/
SELECT DISTINCT email_address,
         SUM(item_price*quantity) AS total_item_price,
         SUM(discount_amount * quantity) AS total_discount_amount
FROM my_guitar_shop.customers c
JOIN my_guitar_shop.orders o
    ON c.customer_id = o.customer_id
JOIN my_guitar_shop.order_items oi
    ON o.order_id = oi.order_id
GROUP BY email_address
ORDER BY total_item_price DESC;

/*Question 4:
Write a SELECT statement that returns one row for each customer that has
orders with these columns:
    The email_address from the Customers table
    A count of the number of orders
    The total amount for each order (Hint: First, subtract the discount
    amount from the price. Then, multiply by the quantity.)
Return only those rows where the customer has more than 1 order.
Sort the result set in descending sequence by the sum of the line item amounts*/
SELECT DISTINCT c.email_address,
        COUNT(o.order_id) AS number_of_orders,
        SUM((item_price - discount_amount)*quantity) AS total_amount
FROM my_guitar_shop.customers c
JOIN my_guitar_shop.orders o
    ON c.customer_id = o.customer_id
JOIN my_guitar_shop.order_items oi
    ON oi.order_id = o.order_id
GROUP BY c.email_address
HAVING COUNT(o.order_id) > 1
ORDER BY total_amount DESC;

/*Question 5:
Modify the solution to exercise 4 so it only counts and totals line items that
have an item_price value that's greater than 400*/
SELECT c.email_address,
        COUNT(o.order_id) AS number_of_orders,
        SUM((item_price - discount_amount)*quantity) AS total_amount
FROM my_guitar_shop.customers c
JOIN my_guitar_shop.orders o
    ON c.customer_id = o.customer_id
JOIN my_guitar_shop.order_items oi
    ON oi.order_id = o.order_id
WHERE oi.item_price > 400
GROUP BY c.email_address
HAVING COUNT(o.order_id) > 1
ORDER BY total_amount DESC;

/*Question 6:
Write a SELECT statement that answers this question: What is the total amount
ordered for each product? Return these columns:
    The product name from the Products table
    The total amount for each product in the Order_Items (Hint: You can
    calculate the total amount by subtracting the discount amount from the
    item price and then multiplying it by the quantity)
Use the WITH ROLLUP operator to include a row that gives the grand total.
Note: Once you add the WITH ROLLUP operator, you may need to use MySQL
Workbench's Execute SQL Script button instead of its Execute Current Statement
button to execute this statement.*/
SELECT p.product_name,
         SUM((oi.item_price-oi.discount_amount)*oi.quantity) AS total_amount
FROM my_guitar_shop.products p
JOIN my_guitar_shop.order_items oi
    USING (product_id)
GROUP BY  product_name WITH ROLLUP;

/*Question 7:
Write a SELECT statement that answers this question: Which customers have
ordered more than one product? Return these columns:
    The email address from the Customers table
    The count of distinct products from the customer's orders*/
SELECT email_address,
         COUNT(o.order_id) AS total_products
FROM my_guitar_shop.customers c
JOIN my_guitar_shop.orders o
    USING (customer_id)
JOIN my_guitar_shop.order_items oi
    USING (order_id)
GROUP BY  email_address
HAVING total_products > 1;