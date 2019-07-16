/*Dave Nunez STY1211 Database Design
Chapter 11 Questions: 1,2,4
Question 1:
Write a script that adds an index to the AP database for the zip
code field in the Vendors table.*/
USE ap;
CREATE INDEX vendors_zip_code_ix ON vendors (vendor_zip_code);

/*Question 2:
Write a script that contains the CREATE TABLE statements needed to
implement the following design in the EX database:

Members             Members_groups          Groupss
member_id --------- member_id       _______ group_id
first_name          group_id ______|        group_name
last_name
address
city
state
phone

These tables provide for members of an association, and each member can be
registered in one or more groups within the association.
The member_id and group_id columns are the primary keys of the Members
and Groups tables, and these columns are foreign keys in the
Members_groups table.*/
USE ex;
DROP TABLE IF EXISTS members_groups;
DROP TABLE IF EXISTS members;
DROP TABLE IF EXISTS groupss;

CREATE TABLE members 
(
member_id   INT         PRIMARY KEY   AUTO_INCREMENT,
first_name  VARCHAR(20) NOT NULL,
last_name   VARCHAR(20) NOT NULL,
address     VARCHAR(50) NOT NULL,
city        CHAR(3),
phone       VARCHAR(15)
);

CREATE TABLE groupss
(
group_id    INT         PRIMARY KEY   AUTO_INCREMENT,
group_name  VARCHAR(50) NOT NULL
);

CREATE TABLE members_groups
(
member_id   INT         NOT NULL,
group_id    int         NOT NULL,
CONSTRAINT members_groups_fk_members FOREIGN KEY (member_id)
    REFERENCES members (member_id),
CONSTRAINT members_groups_fk_groups FOREIGN KEY (group_id)
    REFERENCES groupss (group_id)
);

/*Question 4:
Write an ALTER TABLE statement that adds two new columns to the
Members table created in exercise 2.
Add one column for annual dues that provides for three digits to
the left of the decimal point and two to the right. This column
should have a default value of 52.50.
Add one column for the payment date.*/
USE ex;
ALTER TABLE members
    ADD annual_dues     DECIMAL(5,2)    DEFAULT 52.50;
ALTER TABLE members
    ADD payment_date    DATE;