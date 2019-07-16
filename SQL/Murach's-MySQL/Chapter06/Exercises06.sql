/*noonz
Question 1: Write a SELECT statement that returns one row for each vendor
in the Invoices table that contains these columns:
    The vendor_id column from the Vendors table
    The sum of the invoice_total columns in the Invoices table for that vendor
This should return 34 rows.*/
SELECT vendor_id,
         SUM(invoice_total) AS total_of_invoices
FROM ap.invoices
JOIN ap.vendors USING(vendor_id)
GROUP BY  vendor_id;

/*Question 2:
Write a SELECT statement that returns one row for each vendor that contains
these columns:
    The vendor_name column from the Vendors table
    The sum of the payment_total columns in the Invoices table for that vendor
Sort the result set in DESC sequence by the payment total sum for each vendor*/
SELECT vendor_name,
         SUM(payment_total) AS total_payment
FROM ap.vendors
JOIN ap.invoices USING(vendor_id)
GROUP BY  vendor_name
ORDER BY  total_payment DESC; 
/*Question 3:
Write a SELECT statement that returns one row for each vendor that contains
three columns:
    The vendor_name column from the Vendors table
    The count of the invoices in the Invoices table for each vendor
    The sum of the invoice_total columns in the Invoices table for each vendor
Sort the result set so the vendor with the most invoices appears first*/
SELECT vendor_name,
         COUNT(i.vendor_id) AS total_invoices,
         SUM(i.invoice_total) AS total_invoice_sum
FROM ap.vendors v JOIN ap.invoices i USING(vendor_id)
GROUP BY vendor_name
ORDER BY total_invoices DESC;

/*Question 4:
Write a SELECT statement that returns one row for each general ledger account
number that contains three columns:
    The account_description column from the General_Ledger_Accounts table
    The count of the items in the Invoice_Line_Items table that have the same
    account_number
    The sum of the line_item_amount columns in the Invoice_Line_Items table
    that have the same account_number
Return only those rows where the count of the line items is greater than 1. This
should return 10 rows.*/
SELECT g.account_description,
         COUNT(li.line_item_amount) AS line_item_count,
        SUM(li.line_item_amount) AS sum_of_line_items
FROM ap.General_Ledger_Accounts g
JOIN ap.Invoice_Line_Items li USING(account_number)
GROUP BY account_description
HAVING line_item_count > 1
ORDER BY sum_of_line_items DESC;

/*Question 5:
Modify the solution to exercise 4 so it returns only invoices dated in the
second quarter of 2014 (April 1, 2014 to June 30, 2014). This should still
return 10 rows but with some different line items counts for each vendor. Hint:
Join to the Invoices table to code a search condition based on invoice_date.*/
SELECT g.account_description,
         COUNT(li.line_item_amount) AS line_item_count,
         SUM(li.line_item_amount) AS sum_of_line_items
FROM ap.General_Ledger_Accounts g
JOIN ap.Invoice_Line_Items li USING(account_number)
JOIN ap.invoices i USING(invoice_id)
WHERE invoice_date
    BETWEEN '2014-04-1' AND '2014-06-30'
GROUP BY  account_description
HAVING line_item_count > 1
ORDER BY  sum_of_line_items DESC;

/*Question 6:
Write a SELECT statement that answers this question: What is the total amount
invoiced for each general ledger account number? Return these columns:
    The account number from the Invoice_Line_Items table
    The sum of the line item amounts from the Invoice_Line_Items table
Use the WITH ROLLUP operator to include a row that gives the grand total.
This should return 22 rows.*/
SELECT li.account_number,
         SUM(li.line_item_amount) AS sum_of_line_items
FROM ap.General_Ledger_Accounts g
JOIN ap.Invoice_Line_Items li USING(account_number)
GROUP BY account_number WITH ROLLUP;

/*Question 7:
Write a SELECT statement that answers this question: Which vendors are being
paid from more than one account? Return these columns:
    The vendor name from the Vendors table
    The count of distinct general ledger accounts that apply to that vendor's
    invoices
This should return 2 rows.*/
SELECT vendor_name, COUNT(DISTINCT li.account_number) AS total_paying_accounts
FROM ap.vendors v
JOIN ap.invoices i USING(vendor_id)
JOIN ap.invoice_line_items li USING(invoice_id)
GROUP BY vendor_name
HAVING total_paying_accounts > 1;