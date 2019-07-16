/*noonz
Question 1:
Write a SELECT statement that returns these columns from the Invoices table:
    - The invoice_total column
    - A column that uses the FORMAT function to return the invoice_total
    column with 1 digit to the right of the decimal point
    - A column that uses the CONVERT function to return the invoice_total
    column as an integer
    - A column that uses the CAST function to return the invoice_total column
    as an integer.*/
SELECT invoice_total,
         FORMAT(invoice_total,1) AS total_format,
         CONVERT(invoice_total,SIGNED) AS total_convert,
         CAST(invoice_total AS SIGNED) AS total_cast
FROM ap.Invoices;

/*Question 2:
Write a SELECT statement that returns these columns from the Invoices table:
    - The invoice_date column
    - A column that uses the CAST function to return the invoice_date column
    with its full date and time
    - A column that uses the CAST function to return the invoice_date column
    with just the year and the month*/
SELECT invoice_date,
         CAST(invoice_date AS DATETIME) AS full_date_time,
         CAST(invoice_date AS CHAR(7)) AS year_and_month
FROM ap.Invoices;