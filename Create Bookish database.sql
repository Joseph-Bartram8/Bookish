CREATE DATABASE bookish;

USE bookish;

CREATE TABLE books (
	book_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	book_name VARCHAR(255) NOT NULL,
	author VARCHAR(255) NOT NULL
)

CREATE TABLE customers (
	customer_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	customer_name VARCHAR(255) NOT NULL
)
DROP TABLE book_copies;
CREATE TABLE book_copies (
	copy_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	customer_name VARCHAR(50) NOT NULL,
	book_id INT NOT NULL,

	return_date date NOT NULL,
)