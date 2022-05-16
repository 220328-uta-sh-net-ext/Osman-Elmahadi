---DROP TABLE Types;
-- CREATE TABLE Types (
--     Name NVARCHAR(50) PRIMARY KEY
--     );

--DROP TABLE Restaurants;
CREATE TABLE Restaurants (
    Name NVARCHAR(50) PRIMARY Key,
    Type NVARCHAR(50) FOREIGN KEY REFERENCES Type (Name),
    City NVARCHAR(60),
    State NVARCHAR(70),
    Phone INT,
    Reviews NVARCHAR(10)
);
--DROP TABLE RestaurantReviews;
CREATE TABLE RestaurantReviews (
    Name NVARCHAR(90) PRIMARY KEY,
    Rating INT,
    Note NVARCHAR(1000)
);
ALTER DATABASE SCOPED CONFIGURATION 
  SET VERBOSE_TRUNCATION_WARNINGS = ON;

INSERT INTO Restaurants (Name, City, State, Reviews) VALUES
('Salt n Straw', 'Portland','OR', null),
('Pita House', 'Battle Ground','Washington', 3),
('Barnaby\u0027s', 'Houston' ,'TX', null),
('Palermo\u0027s', 'Chicago','IL', null),
('Carrabba\u0027s' , 'Kalamazoo','MI', null),
('Dave\u0027s Hot Chicken', 'San Bernardino','CA', 3),
('El Charrito', 'Stamford' ,'CT', null),
('Red Lobster', 'Richmond','VA', null),
('Roscoe\u0027s Chicken and Waffles', 'Los Angeles','CA', null);

SELECT * FROM Restaurants;
SELECT * FROM RestaurantReviews;

INSERT INTO RestaurantReviews (Name, Rating, Note) VALUES
('Salt n Straw', 3, 'Not sure about the cookies'),
('Pita House', 5, 'Super friendly owner'),
('Barnaby\u0027s', 4, 'amazing cookies'),
('Palermo\u0027s', 5, 'Really good pizza'),
('Carrabba\u0027s', 5, 'Fettuccine is amazing'),
('Dave\u0027s Hot Chicken', 5, 'Their Chicken Sandwich is better than Popeyes'),
('El Charrito', 5, 'Their hot sauce is amazing'),
('Red Lobster', 3, null),
('Roscoe\u0027s Chicken and Waffles', 3, null);

