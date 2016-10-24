DROP DATABASE IF EXISTS PoSDB;
CREATE DATABASE PoSDB; 
USE PoSDB;


create table products(
	id int primary key not null,
	name varchar(255) not null,
	price decimal(15,2) not null,
	quantity int not null,
	description varchar(255) not null
);

create table sales_tracker(
	id int primary key not null,
	name varchar(255) not null,
	price decimal(15,2) not null,
	date_sold datetime not null,
	quantity_at_date_sold int not null,

	foreign key name references products(name),
	foreign key price references products(price)
);

create table order(
	id int primary key not null,
	name varchar(255) not null,
	price decimal(15,2) not null,
	total_quantity int not null,
	total_price decimal(15,2) not null,
	customer_payment decimal(15,2) not null,
	customer_change decimal(15,2) not null,

	foreign key name references products(name),
	foreign key price references products(price)
);