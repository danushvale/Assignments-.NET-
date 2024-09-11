Create Database  ProductDB

CREATE TABLE Product (
    productID INT PRIMARY KEY,
    name VARCHAR(100),
    price INT,
    quantity INT,
    category VARCHAR(50)
);

INSERT INTO Product (productID, name, price, quantity, category) VALUES
(1, 'Sony Headphones', 3999, 120, 'Electronics'),
(2, 'Samsung Galaxy Charger', 1499, 80, 'Electronics'),
(3, 'DeWalt Drill', 6999, 60, 'Hardware'),
(4, 'Black & Decker Hammer', 2199, 90, 'Hardware'),
(5, 'Nike Running Shoes', 4999, 200, 'Accessories'),
(6, 'Adidas Sports Bag', 3499, 150, 'Accessories');

Select * from Product