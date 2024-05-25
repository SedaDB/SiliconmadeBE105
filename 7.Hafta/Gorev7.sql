USE Gorev7
GO
INSERT INTO [User] (Email, FirstName, LastName, [Password], RoleId, CreatedAt)
VALUES
('seller1@example.com', 'John', 'Doe', 'password123', 1, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
('seller2@example.com', 'Jane', 'Doe', 'password123', 1, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
('buyer1@example.com', 'Jim', 'Beam', 'password123', 2, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
('buyer2@example.com', 'Jack', 'Daniels', 'password123', 2, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
('buyer3@example.com', 'Johnny', 'Walker', 'password123', 2, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE()));
GO
INSERT INTO Category (Name, Color, IconCssClass, CreatedAt)
VALUES
('Electronics', 'FF5733', 'icon-electronics', DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
('Books', '33FF57', 'icon-books', DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
('Clothing', '3357FF', 'icon-clothing', DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
('Toys', 'FF33A6', 'icon-toys', DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
('Sports', 'A633FF', 'icon-sports', DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE()));
GO
INSERT INTO Product (SellerId, CategoryId, Name, Price, Details, StockAmount, CreatedAt)
VALUES
(1, 1, 'Smartphone', 699.99, 'A high-end smartphone with 128GB storage.', 10, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(1, 2, 'Novel', 19.99, 'A best-selling novel.', 50, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(1, 3, 'T-shirt', 9.99, 'A cotton t-shirt.', 100, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(1, 4, 'Action Figure', 29.99, 'An action figure from a popular movie.', 30, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(1, 5, 'Soccer Ball', 24.99, 'A standard size 5 soccer ball.', 20, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(2, 1, 'Laptop', 999.99, 'A powerful laptop with 16GB RAM.', 5, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(2, 2, 'Cookbook', 29.99, 'A cookbook with various recipes.', 25, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(2, 3, 'Jeans', 39.99, 'A pair of denim jeans.', 60, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(2, 4, 'Board Game', 49.99, 'A fun board game for all ages.', 15, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(2, 5, 'Tennis Racket', 89.99, 'A lightweight tennis racket.', 10, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(1, 1, 'Tablet', 399.99, 'A tablet with a 10-inch screen.', 12, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(1, 2, 'Biography', 24.99, 'An inspiring biography.', 40, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(1, 3, 'Jacket', 49.99, 'A warm winter jacket.', 25, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(1, 4, 'Puzzle', 14.99, 'A 1000-piece puzzle.', 35, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE())),
(1, 5, 'Basketball', 29.99, 'An official size basketball.', 18, DATEADD(DAY, -ABS(CHECKSUM(NEWID()) % 365), GETDATE()));
GO
