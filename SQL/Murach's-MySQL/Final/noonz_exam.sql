-- noonz
-- Database Design STY1211
-- Final Practical Exam

USE om;

-- Question 1
SELECT customer_first_name, o.order_id, o.order_date, od.order_qty
FROM customers c JOIN orders o ON c.customer_id = o.customer_id
	JOIN order_details od ON o.order_id = od.order_id
WHERE order_qty > 1;

-- Question 2
SELECT order_qty, FORMAT(order_qty, 1) AS format_qty,
	CONVERT(order_qty, SIGNED) AS convert_qty, 
    CAST(order_qty AS SIGNED) AS cast_qty
FROM order_details;

-- Question 4
DROP DATABASE IF EXISTS DBFinal;
CREATE DATABASE DBFinal;
USE DBFinal;

-- Create Tables
CREATE TABLE genres
(
	genre_id		INT				PRIMARY KEY			AUTO_INCREMENT,
    name			VARCHAR(75)		NOT NULL,
    description		VARCHAR(100)	NOT NULL
);

CREATE TABLE movies
(
	member_id		INT				PRIMARY KEY			AUTO_INCREMENT,
    name			VARCHAR(75)		NOT NULL,
    description		VARCHAR(100)	NOT NULL,
    release_year	YEAR			NOT NULL,
    genre_id		INT				NOT NULL,
    CONSTRAINT movies_fk_genre
		FOREIGN KEY (genre_id) REFERENCES genres (genre_id)
);
