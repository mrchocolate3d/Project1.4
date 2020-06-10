CREATE TABLE roles(
	roleID INT,
	roleDescription VARCHAR(20),
	PRIMARY KEY (roleID)
);

CREATE TABLE employees(
	employeeID INT NOT NULL,
	roleID INT,
	firstName VARCHAR(45),
	lastName VARCHAR(45),
	email VARCHAR(90),
	phoneNumber INT
	PRIMARY KEY (employeeID),
	FOREIGN KEY (roleID) REFERENCES roles(roleID),
);

CREATE TABLE [login](
	loginCode INT NOT NULL,
	employeeID INT,
	PRIMARY KEY(loginCode),
	FOREIGN KEY (employeeID) REFERENCES employees(employeeID)
);

CREATE TABLE [tables](
	tableID INT NOT NULL,
	[status] varchar(20),
	PRIMARY KEY(tableID)
);

CREATE TABLE orders(
	orderID INT NOT NULL,
	tableID INT NOT NULL,
	employeeID INT NOT NULL,
	feedback VARCHAR(250),
	DateOrder DateTime,
	paymentID int,
	orderComplete bit,
	PRIMARY KEY (orderID),
	FOREIGN KEY (tableID) REFERENCES  [tables](tableID),
	FOREIGN KEY (employeeID) REFERENCES employees(employeeID),
);

ALTER TABLE orders ADD orderComplete bit;

SELECT * FROM orders;
SELECT * FROM Order_MenuItem where orderID = 1;

UPDATE orders SET tableID = 4 WHERE orderID = 3;

UPDATE orders SET tableID = 4 WHERE orderID = 3;
UPDATE orders SET tableID = 4 WHERE orderID = 3;
UPDATE orders SET tableID = 4 WHERE orderID = 3;


CREATE TABLE categories(
	categoryID INT,
	categoryType VARCHAR(10),
	categoryDescription VARCHAR(25),
	PRIMARY KEY (categoryID)
);

CREATE TABLE menuItem(
	menuItemID INT IDENTITY(1,1),
	categoryID INT,
	price FLOAT,
	amount INT,
	itemName VARCHAR(50),
	timeApproximate FLOAT,
	PRIMARY KEY (menuItemID),
	FOREIGN KEY (categoryID) REFERENCES categories(categoryID)
);


CREATE TABLE Order_MenuItem(
	orderID INT,
	MenuItemID INT,
	quantity INT,
	[status] INT,
	state_time DATETIME,
	comment VARCHAR(250),
	FOREIGN KEY (orderID) REFERENCES  orders(orderID),
	FOREIGN KEY (MenuItemID) REFERENCES  MenuItem(MenuItemID),
);

select itemName, price, quantity, orderID from Order_MenuItem inner join menuItem on menuItem.menuItemID = Order_MenuItem.MenuItemID where orderID = 1;

CREATE TABLE payment(
	paymentID  INT  NOT NULL,
	orderID INT,
	employeeID INT,
	paymentMethod VARCHAR(10),
	dateOrder DATETIME,
	vat  float,
	tip float,
	totalPrice float,
	PRIMARY KEY (paymentID),
	fOREIGN KEY (orderID) REFERENCES orders(orderID),
	FOREIGN KEY (employeeID) REFERENCES employees(employeeID)
);

SELECT * FROM tables;

/*Insert*/

INSERT INTO [login] (loginCode) VALUES (2020);

Select (loginCode) FROM [login];


/*Sharelyn's MENU statements*/
INSERT INTO categories (categoryID,categoryType,categoryDescription) VALUES (1,'Lunch','lunchMain');
INSERT INTO categories (categoryID,categoryType,categoryDescription) VALUES (2,'Lunch','Specials');
INSERT INTO categories (categoryID,categoryType,categoryDescription) VALUES (3,'Lunch','Bites');

INSERT INTO categories (categoryID,categoryType,categoryDescription) VALUES (4,'Dinner','Starters');
INSERT INTO categories (categoryID,categoryType,categoryDescription) VALUES (5,'Dinner','Mains');
INSERT INTO categories (categoryID,categoryType,categoryDescription) VALUES (6,'Dinner','Desserts');

/*Sharelyn's LUNCH statements*/
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (1,9.50,25,'SALADE NIÇOISE',5.20);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (1,8.00,50,'FRENCH OMLETTE',7.50);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (1,9.50,46,'FENNEL DAUPHINOISE',10.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (1,8.50,30,'QUICHE OF THE DAY',8.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (2,8.95,20,'CROQUE MONSIEUR - TOAST',7.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (2,9.50,20,'CROQUE MADAME - TOAST',7.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (2,6.95,15,'HOMEMADE SOUP OF THE DAY',9.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (2,7.50,10,'HOMEMADE ONIONSOUP',9.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (3,7.50,55,'TORTILLA CHIPS',5.50);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (3,5.95,35,'CRUDITÉS WITH OLIVE-ANCHOVY AIOLI',7.50);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (3,5.50,20,'TOAST BELGIAN PRÉPARÉ',6.50);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (3,4.95,35,'BREAD',4.50);

/* Sharelyn's DINNER statements*/
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,6.95,15,'HOMEMADE SOUP OF THE DAY',9.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,7.50,10,'HOMEMADE ONIONSOUP',9.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,8.95,35,'BEEF CARPACCIO',10.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,8.95,30,'ESCARGOTS',10.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,9.50,25,'GOATCHEESE',5.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,27.50,20,'TENDERLOIN FROM BLACK ANGUS',20.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,19.95,25,'BUTCHER STEAK',25.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,25.50,35,'LAMB CHOPS',20.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,18.50,18,'RATATOUILLE',15.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,22.50,20,'FRENCH FISH STEW',15.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,32.50,10,'WHOLE LOBSTER',25.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (6,7.95,25,'CRÈME BRÛLÉE',10.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (6,8.75,32,'CHOCOLATE CRUMBLE',11.50);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (6,7.95,29,'DAME BLANCHE',12.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (6,12.50,25,'CHEESE',15.00);

