/*Noonz STY 1211
Lab 05
my_guitar_shop database
 ** Note: Subqueries are only working with safe update mode turned off.***/

/*Question 1
Write an INSERT statement that adds this row to the Categories table:
category_name: Brass
Code the INSERT statement so MySQL automatically generates the
category_id column*/
INSERT my_guitar_shop.categories (category_name)
VALUES ('Brass');

/*Question 2
Write an UPDATE statement that modifies the row you just added to the Categories
table. This statement should change the category_name column to 'Woodwinds',
and it should use the category_id column to identify the row*/
UPDATE my_guitar_shop.categories
SET category_name = 'Woodwinds'
WHERE category_id =
    (SELECT category_id
    WHERE category_name = 'Brass');

/*Question 3
Write a DELETE statement that deletes the row you added to the Categories
table in exercise 1. This statement should use the category_id column
to identify the row.*/
DELETE FROM my_guitar_shop.categories
WHERE category_id = 
    (SELECT category_id
    WHERE category_name = 'Brass' OR category_name = 'Woodwinds');

/*Question 4
Write an INSERT statement that adds this row to the Products table:
product_id:         The next automatically generated ID
category_id:        4
product_code:       dgx_640
product_name:       Yamaha DGX 640 88-Key Digital Piano
description:        Long description to come.
list_price:         799.99
discount_percent:   0
date_added:         Today's date/time.
Use a column list for this statement.*/
INSERT my_guitar_shop.Products (product_id,category_id,product_code,product_name,
description,list_price,discount_percent,date_added)
VALUES (DEFAULT,4,'dgx_640','Yamaha DGX 640 88-Key Digital Piano','Long description to come',
799.99,0,SYSDATE());

/*Question 5
Write an UPDATE statement that modifies the product you added in exercise 4.
This statement should change the discount_percent column from 0% to 35%.*/
UPDATE my_guitar_shop.Products
SET discount_percent = 35
WHERE product_code = 'dgx_640';

/*Question 6
Write an INSERT statement that adds this row to the Customers table:
email_address:      rick@raven.com
password:           (empty string)
first_name:         Rick
last_name:          Raven
Use a column list for this statement.*/
INSERT my_guitar_shop.Customers (email_address,password,first_name,last_name)
VALUES ('rick@raven.com','','Rick','Raven');

/*Question 7
Write an UPDATE statement that modifies the Customers table. Change the password
column to 'secret' for the customer with an email address of rick@raven.com.*/
UPDATE my_guitar_shop.Customers
SET password = 'secret'
WHERE email_address = 'rick@raven.com';

/*Question 8
Write an UPDATE statement that modifies the Customers table. Change the password
column to 'reset' for every customer in the table. If you get an error due to safe-update mode,
you can add a LIMIT clause to update the first 100 rows of the table.
(This should update all rows in the table)*/
UPDATE my_guitar_shop.Customers
SET password = 'reset'
LIMIT 100;

/*Question 9: Reset my_guitar_shop.
Open the script named create_my_guitar_shop.sql that's in the mgs_ex_starts directory.
Then, run this script. That should restore the data that's in the database.*/