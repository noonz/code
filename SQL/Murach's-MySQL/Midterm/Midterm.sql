/*noonz
Midterm STY1211, alexamara database
Question 1:
Write a query that will retrieve all columns and rows from the owner table*/
SELECT * FROM alexamara.owner;

/*Question 2:
Write a query that will retrieve these columns from the servicerequest table:
Service ID          based on the ServiceID column
Description         description
Hour Difference     Calculated on EstHours - SpentHours rounded to nearest hour
Next Service Date   based on the NextServiceDate column, formatted 'DD-Mon-YYYY'
*/
SELECT 
    ServiceID,
    Description,
    ROUND(EstHours - SpentHours) AS 'Hour Difference',
    DATE_FORMAT(NextServiceDate, '%d-%b-%Y') as 'Next Service Date'
FROM
    alexamara.servicerequest;

/*Question 3:
Write a query that will retrieve marina names and boat names from the marina
and marinaslip tables using a join clause. Use an outer join so that all
records from the marina table are retrieved even if there is no matching record
in the marinaslip table. Use explicit syntax for the join.
Retrieve only records for Marinas named 'Alexamara East'*/
SELECT 
    m.name, ml.boatname
FROM
    alexamara.marina m
        LEFT JOIN
    alexamara.marinaslip ml USING (marinanum)
WHERE
    m.name = 'Alexamara East';

/*Question 4:
Write a query that will create a copy of the marinaslip table called
marinaslip_copy*/
CREATE TABLE marinaslip_copy
SELECT * FROM alexamara.marinaslip;

DROP TABLE marinaslip_copy;

/*Question 5:
Write a query that will add a new marina to the marina table. Use the following
values:
MarinaNum           Next generated ID
Name                Marina Twelve
Address             1000 Ramsey Rd
City                Las Vegas
State               NV
Zip                 54321*/
INSERT INTO alexamara.marina
VALUES (DEFAULT,'Marina Twelve','1000 Ramsey Rd','Las Vegas','NV',54321);

/*Question 6:
Write a query that will delete the record you added in the previous question.*/
DELETE FROM alexamara.marina
WHERE name = 'Marina Twelve';