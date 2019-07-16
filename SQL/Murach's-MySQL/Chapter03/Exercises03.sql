/*noonz
Question 6:
Write a SELECT statement that returns three columns from the Vendors table:
vendor_name, vendor_contact_last_name, and vendor_contact_first_name.
Then, run this statement to make sure it works correctly.
Add an ORDER BY clause to this statement that sorts the result set by
last name and then first name, both in ascending sequence. Then, run this
statement again to make sure it works correctly. This is a good way to 
build and test a statement, one clause at a time.*/
SELECT 
    vendor_name,
    vendor_contact_last_name,
    vendor_contact_first_name
FROM
    ap.vendors
ORDER BY vendor_contact_last_name , vendor_contact_first_name;

/* Question 7:
Write a SELECT statement that returns one column from the Vendors table named
full_name that joins the vendor_contact_last_name and vendor_contact_first_name
columns.
Format this column with the last name, a comma, a space, and the first name like
this: Doe, John
Sort the result set by last name and then first name in ascending sequence.
Return only the contacts whose last name begins with the letters A,B,C, or E.
This should retrieve 41 rows.*/
SELECT 
    CONCAT(vendor_contact_last_name,
            ', ',
            vendor_contact_first_name) AS full_name
FROM
    ap.vendors
WHERE
    vendor_contact_last_name REGEXP '^[A-C|E]'
ORDER BY vendor_contact_first_name;

/* Question 8:
Write a SELECT statement that returns these column names and data from
the Invoices table:
Due Date        The invoice_due_date column
Invoice Total   The invoice_total column
10%             10% of the value of invoice_total
Plus 10%        The value of invoice_total plus 10%
Return only the rows with an invoice total that's greater or equal to 500
and less than or equal to 1000. This retrieve 12 rows.
Sort the result set in descending sequence by invoice_due_date.*/
SELECT 
    invoice_due_date,
    invoice_total,
    ROUND(invoice_total * .10, 2) AS '10%',
    ROUND(invoice_total + (invoice_total * .10), 2) AS 'Plus 10%'
FROM
    ap.invoices
WHERE
    invoice_total >= 500
        AND invoice_total <= 1000
ORDER BY invoice_due_date DESC;

/* Question 9:
Write a SELECT statement that returns these columns from the Invoices
table:
invoice_number          The invoice_number column
invoice_total           The invoice_total column
payment_credit_total    Sum of the payment_total and credit_total columns
balance_due             The invoice_total column minus the payment_total and
                        credit_total columns
Return only invoices that have a balance due that's greater than $50.
Sort the result set by balance due in descending sequence.
Use the LIMIT clause so the result set contains only the rows with the 5
largest balances.*/
SELECT 
    invoice_number,
    invoice_total,
    ROUND(payment_total + credit_total, 2) AS payment_credit_total,
    ROUND(invoice_total - (payment_total + credit_total),
            2) AS balance_due
FROM
    ap.invoices
WHERE
    invoice_total - (payment_total + credit_total) > 50
ORDER BY invoice_total - (payment_total + credit_total) DESC
LIMIT 5;

/* Question 10:
Write a SELECT statement that returns these colums from the Invoices table:
invoice_number      The invoice_number column
invoice_date        The invoice_date column
balance_die         The invoice_total column minus the payment_total
                    and credit_total columns
payment_date        The payment_date column
Return only the rows where the payment_date column contains a null value.
This should retrieve 11 rows.*/
SELECT 
    invoice_number,
    invoice_date,
    ROUND(invoice_total - (payment_total + credit_total),
            2) AS balance_due,
    payment_date
FROM
    ap.invoices
WHERE
    payment_date IS NULL;
    
/* Question 11:
Write a SELECT statement without a FROM clause that uses the CURRENT_DATE
function to return the current date in its default format.
Use the DATE_FORMAT function to format the current date in this format:
mm-dd-yyyy
This displays the month, day, and four-digit year of the current date.
Give this column an alias of current_date. To do that, you must enclose the
alias in quotes since that name is already used by the CURRENT_DATE function.*/
SELECT 
    CURRENT_DATE,
    DATE_FORMAT(CURRENT_DATE, '%m-%d-%Y') AS 'current_date';servicerequest
    
/* Question 12:
Write a SELECT statement without a FROM clause tht creates a row with
these columns:
starting_principal          Starting principal of $50,000
interest                    6.5% of the principal
principal_plus_interest     The principal plus the interest
To calculate the third column, add the expressions you used for the first
two columns.*/
SELECT 
    50000 AS starting_principal,
    ROUND(50000 * .065, 2) AS interest,
    ROUND(50000 + (50000 * .065), 2) AS principal_plus_interest;