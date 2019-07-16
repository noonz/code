-- Noonz STY1211
-- Lab 4
-- my_guitar_shop database

-- Question 1: Join the categories table and products table, and return these columns:
-- category_name, product_name, list_price
-- Sort by: category_name, product_name
SELECT 
    category_name, product_name, list_price
FROM
    my_guitar_shop.categories c 
    JOIN my_guitar_shop.products p
        ON c.category_id = p.category_id
ORDER BY category_name , product_name;

-- Question 2: Join the customers table to the addresses table and return these columns:
-- first_name, last_name, line1, city, state, zip_code
-- Return one row for each address with an email of allan.sherwood@yahoo.com
SELECT
    first_name, last_name, line1 AS address, city, state, zip_code
FROM
    my_guitar_shop.customers c 
    JOIN my_guitar_shop.addresses a
        ON c.customer_id = a.customer_id
WHERE
    c.email_address = 'allan.sherwood@yahoo.com';
    
-- Question 3: Join the customers table to the addresses table and return these columns:
-- first_name, last_name, line1, city, state, zip_code
-- Return one row for each customer, but only return addresses that are the shipping
-- address for a customer
SELECT
    first_name, last_name, line1, city, state, zip_code
FROM
    my_guitar_shop.customers c 
    JOIN my_guitar_shop.addresses a
        ON c.customer_id = a.customer_id;

-- Question 4: Join the customers, orders, order_items, and products tables. 
-- This statement should return these columns: last_name, first_name, order_date,
-- product_name, item_price, discount_amount, and quantity. Use aliases.
-- Sort by: last_name, order_date, and product_name
SELECT
    last_name, first_name, order_date, product_name, item_price, discount_amount, quantity
FROM
    my_guitar_shop.customers c 
    JOIN my_guitar_shop.orders o
        ON c.customer_id = o.customer_id
    JOIN my_guitar_shop.order_items oi
        ON o.order_id = oi.order_id
    JOIN my_guitar_shop.products p
        ON oi.product_id = p.product_id
ORDER BY
    last_name, order_date, product_name;
    
-- Question 5: Write a select statement that returns the product_name and list_price
-- columns from the Products table.
-- Return one row for each product that has the same list price as another product
-- Sort by: product_name
SELECT
    p1.product_name, p1.list_price
FROM
    my_guitar_shop.products p1
    JOIN my_guitar_shop.products p2
        ON p1.list_price = p2.list_price AND
        p1.product_name != p2.product_name
ORDER BY
    product_name;
    
-- Question 6: Write a select statement that returns two columns:
-- category_name --> the category_name column from the Categories table
-- product_id --> the product_id column from the Products table
-- Return one row for each category that has never been used.
SELECT
    c.category_name, p.product_id
FROM 
    my_guitar_shop.categories c
    LEFT JOIN my_guitar_shop.products p
        ON c.category_id = p.category_id
WHERE
    p.product_id IS NULL;
    
-- Question 7: Use the UNION operator to generate a result set consisting
-- of three columns from the Orders table:
-- ship_status -> a calculated column that contains a value of shipped or not shipped
-- order_id -> the order_id column
-- order_date -> the order_date column
-- If the order has a value in the ship_date column, the ship_status column should
-- contain a value of SHIPPED. otherwise, it should contain a value of NOT SHIPPED.
-- Sort by: order_date
SELECT
    'SHIPPED' AS ship_status, order_id, order_date
FROM
    my_guitar_shop.orders o
WHERE
    o.ship_date IS NOT NULL
    
UNION

SELECT
    'NOT SHIPPED' AS ship_status, order_id, order_date
FROM
    my_guitar_shop.orders o
WHERE
    o.ship_date IS NULL
ORDER BY
    order_date;