-- Noonz STY 1211
-- Database Design, Chapter 3 Lab 3

-- Question 1
SELECT
    product_code, product_name, list_price, discount_percent
FROM
    my_guitar_shop.products
ORDER BY
    list_price DESC;

-- Question 2
SELECT 
    CONCAT(last_name, ', ', first_name) AS full_name
FROM
    my_guitar_shop.customers
WHERE
    last_name REGEXP '^[M-Z]'
ORDER BY 
    last_name;

-- Question 3
SELECT
    product_name AS Products,
    list_price AS Price,
    date_added AS 'Date'
FROM
    my_guitar_shop.products
WHERE
    list_price BETWEEN 500 AND 2000
ORDER BY
    date_added DESC;

-- Question 4
SELECT
    product_name AS Products,
    list_price AS Price,
    ROUND(discount_percent) AS "Discount Percent",
    ROUND((list_price * (discount_percent/100)),2) AS "Discount Amount",
    list_price - ROUND((list_price * (discount_percent/100)),2) AS "Discounted Price"
FROM
    my_guitar_shop.products
ORDER BY
    list_price - ROUND((list_price * (discount_percent/100)),2) DESC
LIMIT
    5;

-- Question 5
SELECT
    item_id AS Item_id,
    item_price AS Price,
    discount_amount AS Discount,
    quantity AS Quantity,
    ROUND(item_price * quantity,2) AS "Total Price",
    ROUND(discount_amount * quantity,2) AS "Discount Total",
    ROUND((item_price - discount_amount) * quantity,2) AS "Item Total"
FROM
    my_guitar_shop.order_items
WHERE
    (item_price - discount_amount) * quantity > 500
ORDER BY
    (item_price - discount_amount) * quantity DESC;

-- Question 6
SELECT
    order_id,
    order_date,
    ship_date
FROM
    my_guitar_shop.orders
WHERE
    ship_date IS NULL;

-- Question 7
SELECT
    CURRENT_DATE AS today_unformatted,
    DATE_FORMAT(CURRENT_DATE, '%e-%b-%y') AS today_formatted;

-- Question 8
SELECT
    100 AS Price,
    .07 AS Tax,
    100 * .07 AS "Tax Amount",
    (100 + (100*.07)) AS Total;
