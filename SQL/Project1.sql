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
select * from roles;
select * from Order_MenuItem;
select * from orders;
select * from menuItem;


insert into roles (roleID,roleDescription) values (3,'Chef');
insert into roles (roleID,roleDescription) values (4,'Bar');


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

select * from categories;

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

UPDATE menuItem SET itemName = 'SaladeNicoise' WHERE itemName='SALADE NIÇOISE';
UPDATE menuItem SET itemName = 'FrenchOmlette' WHERE itemName='FRENCH OMLETTE';
UPDATE menuItem SET itemName = 'FennelDauphinoise' WHERE itemName='FENNEL DAUPHINOISE';
UPDATE menuItem SET itemName = 'QuicheOfTheDay' WHERE itemName='QUICHE OF THE DAY';
UPDATE menuItem SET itemName = 'CroqueMonsieurToast' WHERE itemName='CROQUE MONSIEUR - TOAST';
UPDATE menuItem SET itemName = 'CroqueMadameToast' WHERE itemName='CROQUE MADAME - TOAST';
UPDATE menuItem SET itemName = 'HomemadeSoup' WHERE itemName='HOMEMADE SOUP OF THE DAY';
UPDATE menuItem SET itemName = 'OnionSoup' WHERE itemName='HOMEMADE ONIONSOUP';
UPDATE menuItem SET itemName = 'TortillaChips' WHERE itemName='TORTILLA CHIPS';
UPDATE menuItem SET itemName = 'CruditesOliveAioliToast' WHERE itemName='CRUDITÉS WITH OLIVE-ANCHOVY AIOLI';
UPDATE menuItem SET itemName = 'BelgianPrepare' WHERE itemName='TOAST BELGIAN PRÉPARÉ';
UPDATE menuItem SET itemName = 'Bread' WHERE itemName='BREAD';

UPDATE menuItem SET itemName = 'HomemadeSoupOfTheDay' WHERE menuItemID=139;

Delete from menuItem where menuItemID between 13 AND 138;

select * from menuItem;

SELECT menuItemID, price FROM menuItem WHERE itemName = 'TortillaChips';


UPDATE menuItem SET amount = 0 WHERE itemName='OnionSoup';
UPDATE menuItem SET amount = 0 WHERE itemName='QuicheOfTheDay';
UPDATE menuItem SET amount = 3 WHERE itemName='HomemadeSoup';

select * from orders;

/* Sharelyn's DINNER statements*/
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,6.95,15,'HomemadeSoup',9.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,7.50,10,'OnionSoup',9.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,8.95,35,'BeefCarpaccio',10.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,8.95,30,'Escargots',10.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (4,9.50,25,'GotaCheese',5.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,27.50,20,'TenderloinBlackAngus',20.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,19.95,25,'ButcherSteak',25.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,25.50,35,'LambChops',20.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,18.50,18,'Ratatouille',15.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,22.50,20,'FrenchFishStew',15.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (5,32.50,10,'WholeLobster',25.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (6,7.95,25,'CremeBrulee',10.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (6,8.75,32,'ChocolateCrumble',11.50);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (6,7.95,29,'DameBlanche',12.00);
INSERT INTO menuItem (categoryID,price,amount,itemName,timeApproximate) VALUES (6,12.50,25,'Cheese',15.00);

INSERT INTO orders (tableID,employeeID,orderComplete) VALUES (2,1,0);

select * from orders;
/*
insert into categories
values (7, 'Drinks', 'Soft Drinks'),
(8, 'Drinks', 'Hot Drinks'),
(9, 'Drinks', 'Beers'),
(10, 'Drinks', 'Wines')
*/
select * from login;
Delete from orders where orderID = 12;

SELECT orderID FROM orders WHERE tableID = 2 AND employeeID = 1 AND orderComplete = 0;


INSERT INTO orders (tableID,employeeID,orderComplete) VALUES (3,1,0);

insert into menuItem ( categoryID, price, amount, itemName)
values ( 7, 2.5, 75, 'CocaCola'),
( 7, 2.5, 3, 'Sprite'),
( 7, 2.5, 10, 'FantaOrange'),
( 7, 2.5, 78, 'BitterLemon'),
( 7, 2.5, 36, 'Tonic'),
( 7, 2.5, 0, 'GingerAle'),
( 7, 2.5, 76, 'LiptonIcedTea'),
( 8, 2.5, 57, 'Coffee'),
( 8, 2.5, 77, 'Tea'),
( 8, 3.4, 2, 'FreshMintTea'),
( 8, 3, 32, 'Espresso'),
( 8, 3.5, 27, 'Cappuccino'),
( 9, 2.4, 89, 'Heineken Small'),
( 9, 3.5, 51, 'Heineken Medium'),
( 9, 2.9, 49, 'Palm'),
( 9, 3.9, 38, 'Duvel'),
( 9, 4.9, 3, 'Corona'),
( 10, 16.9, 32, 'SauvignonBottle'),
( 10, 2.9, 12, 'SauvignonGlass'),
( 10, 16.9, 35, 'MerlotBottle'),
( 10, 2.9, 175, 'MerlotGlass'),
( 10, 16.9, 25, 'RoseBottle'),
( 10, 2.9, 125, 'RoseGlass')


