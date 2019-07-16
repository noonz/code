/*noonz
Question 1:
Write a SELECT statement that returns these columns from the Invoices table:
    - The invoice_total column
    - A column that uses the ROUND function to return the invoice_total
    column with 1 decimal digit
    - A column that uses the ROUND function to return the invoice_total
    column with no decimal digits.*/
SELECT invoice_total,
         ROUND(invoice_total,1) AS one_digit,
         ROUND(invoice_total,0) AS no_digits
FROM ap.invoices;


/*Question 2:
Write a SELECT statement that returns these columns from the Date_Sample table
in the EX database:
    - A column that uses the DATE_FORMAT function to return the start_date
    column with its month name abbreviated and its month, day, and two-digit
    year separated by slashes
    - A column that uses the DATE_FORMAT function to return the start_date
    column with its month and day returned as integers with no leading zeros, a
    two-digit year, and all date parts separated by slashes.
    - A column that uses the DATE_FORMAT function to return the start_date
    column with only the hours and minutes on a 12-hour clock with an am/pm
    indicator.
    - A column that uses the DATE_FORMAT function to return the start_date
    column with its month returned as an integer with no leading zeros, its
    month, day, and two-digit year separated by slashes, and its hours and 
    minutes on a 12-hour clock with an am/pm indicator.*/
SELECT 
    DATE_FORMAT(start_date, '%b/%d/%y') AS first_format,
    DATE_FORMAT(start_date, '%e/%c/%y') AS second_format,
    DATE_FORMAT(start_date, '%l:%i %p') AS third_format,
    DATE_FORMAT(start_date, '%e/%d/%y %l:%i %p') AS fourth_format
FROM
    ex.Date_Sample;

/*Question 3:
Write a SELECT statement that returns these columns from the Vendors table:
    - The vendor_name column
    - The vendor_name column in all capital letters
    - The vendor_phone column
    - A column that displays the last four digits of each phone number
When you get that working right, add the columns that follow to the result
set. This is more difficult because these columns require the use of functions
within functions.
    - The vendor_phone column with the parts of the number separated by dots,
    as in 555.555.5555
    - A column that displays the second word in each vendor name if there is one
    and blanks if there isn't.*/
SELECT vendor_name,
         UPPER(vendor_name) AS upper_case,
         vendor_phone,
         SUBSTRING_INDEX(vendor_phone,'-', -1) AS last_four_digits,
         -- Search for brackets, spaces and hyphens and replace them with .
         REPLACE(REPLACE(REPLACE(REPLACE
         (vendor_phone, '(', ''), ')', '.'), '-','.'), ' ', '') AS dot_sep,
         SUBSTRING(vendor_name,
            LOCATE(' ',vendor_name),
            LOCATE(' ',vendor_name,
            LOCATE(' ',vendor_name) + 1) - LOCATE(' ', vendor_name)) AS word_2
FROM ap.vendors;

/*Question 4:
Write a SELECT statement that returns these columns from the Invoices table:
    - The invoice_number column
    - The invoice_date column
    - The invoice_date column plus 30 days
    - The payment_date column
    - A column named days_to_pay that shows the number of days between the
    invoice date and the payment date
    - The number of the invoices date's month
    - The four-digit year of the invoice date
When you have this working, add a WHERE clause that retrieves just the
invoices for the month of May based on the invoice date, not the number of
the invoice month.*/
SELECT invoice_number,
        invoice_date,
        DATE_ADD(invoice_date, INTERVAL 30 DAY) AS add_30_days,
        payment_date,
        DATEDIFF(payment_date,invoice_date) AS days_to_pay,
        MONTH(invoice_date) AS 'month',
        YEAR(invoice_date) AS 'year'
FROM ap.invoices
WHERE invoice_date BETWEEN '2014-05-01' AND '2014-05-31';