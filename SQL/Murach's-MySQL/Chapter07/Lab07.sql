/*noonz
Database Design STY1211
Question 1:
Write a SELECT statement that returns the same result set as this SELECT
statement, but don't use a join. Instead, use a subquery in a WHERE clause that 
uses the IN keyword.
SELECT DISTINCT category_name
FROM categories c JOIN products p
    ON c.category_id = p.category_id
ORDER BY category_name*/
SELECT DISTINCT category_name AS Instruments
FROM my_guitar_shop.categories
WHERE category_id IN 
    (SELECT DISTINCT category_id
    FROM my_guitar_shop.products)
ORDER BY  Instruments;

/*Question 2:
Write a SELECT statement that answers this question: Which products have a list
price that's greater than the average list price for all products?
Return the product_name and list_price columns for each product.
Sort the results by the list_price column in descending sequence.*/
SELECT product_name,
        list_price
FROM my_guitar_shop.products
WHERE list_price > 
    (SELECT AVG(list_price)
    FROM my_guitar_shop.products)
ORDER BY  list_price DESC;

/*Question 3:
Write a SELECT statement that returns the category_name column from the
Categories table.
Return one row for each category that has never been assigned to any product in
the Products table. To do that, use a subquery introduced with the NOT EXISTS
operator.*/
SELECT category_name
FROM my_guitar_shop.categories
WHERE NOT EXISTS 
    (SELECT *
    FROM my_guitar_shop.products
    WHERE category_id = categories.category_id);

/*Question 4:
Write a SELECT statement that returns three columns: email_address, order_id,and
the order total for each customer. To do this, you can group the result set by
the email_address and order_id columns. In addition, you must calculate the
order total from the columns in the Order_Items table.

Write a second SELECT statement that uses the first SELECT statement in its FROM
clause. The main query should return two columns: the customer's email address
and the largest order for that customer. To do this, you can group the result
set by the email_address.*/
SELECT c.email_address,
         o.order_id,
         SUM(oi.item_price * oi.quantity - oi.discount_amount) AS order_total
FROM my_guitar_shop.customers c
JOIN my_guitar_shop.orders o
    USING(customer_id)
JOIN my_guitar_shop.Order_Items oi 
    USING(order_id)
GROUP BY c.email_address, o.order_id;

SELECT email_address,
         MAX(order_total) AS largest_order
FROM 
    (SELECT c.email_address,
         o.order_id,
         SUM(oi.item_price * oi.quantity - oi.discount_amount) AS order_total
    FROM my_guitar_shop.customers c
    JOIN my_guitar_shop.orders o 
        USING(customer_id)
    JOIN my_guitar_shop.Order_Items oi 
        USING(order_id)
    GROUP BY  c.email_address, o.order_id) AS query_one
GROUP BY  email_address;

/*Question 5:
Write a SELECT statement that returns the name and discount percent of each
product that has a unique discount percent. In other words, don't include
products that have the same discount percent as another product.
Sort the reults by the product_name column.*/
SELECT product_name,
         discount_percent
FROM my_guitar_shop.products p1
WHERE discount_percent NOT IN 
    (SELECT discount_percent
    FROM my_guitar_shop.products p2
    WHERE p1.product_id != p2.product_id)
ORDER BY  product_name;

/*Question 6:
Use a correlated subquery to return on row per customer, representing the
customer's oldest order (the one with the earliest date). Each row should
include these three columns: email_address, order_id, and order_date.*/
SELECT c.email_address,
         o.order_id,
         DATE_FORMAT(o.order_date,'%e-%b-%Y') AS oldest_order
FROM my_guitar_shop.customers c
JOIN my_guitar_shop.orders o 
    USING(customer_id)
WHERE o.order_date = 
    (SELECT MIN(o.order_date)
    FROM my_guitar_shop.orders
    WHERE o.customer_id = c.customer_id)
GROUP BY email_address;

/*Question 7:
Write an INSERT statement that adds this row to the Customers table:
email_address:      rick@raven.com
password:           (empty string)
first_name:         Rick
last_name:          Raven
Use a column list for this statement.*/
INSERT INTO my_guitar_shop.customers 
    (email_address,password,first_name,last_name)
VALUES ('rick@raven.com','','Rick','Raven')

/*Question 8:
Write an UPDATE statement that modifies the Customers table. Change the password
column to 'secret' for the customer with an email address of rick@raven.com.*/
UPDATE my_guitar_shop.customers
SET password = 'secret'
WHERE email_address = 'rick@raven.com';

/*Question 9:
Write an UPDATE statement that modifies the Customers table. Change the
password column to 'reset' for every customer in the table. If you get an error
due to safe-update mode, you can add a LIMIT clause to update the first 100 rows
of the table. (This should update all rows in the table.)*/
UPDATE my_guitar_shop.customers
SET password = 'reset';

/*Restore your database to default.*/