--Testing Purpose
--Members
INSERT INTO Members(MemID, PPSNo, Surname, Forename, DOB, Gender, Street, Town, County, Phone, Email, Reg_Date)
VALUES(1,'1234565AS','SMITH','JOHN','04-NOV-93','M','ABBEY STREET','TRALEE','KERRY','083 5678457','smithjohn@gmail.com','22-JAN-17');

INSERT INTO Members(MemID, PPSNo, Surname, Forename, DOB, Gender, Street, Town, County, Phone, Email, Reg_Date)
VALUES(2,'2345767DF','KEE','JOYCE','06-NOV-91','F','NORTH CIRCULAR ROAD','TRALEE','KERRY','066 5678457','joycekee@gmail.com','22-JAN-17');

INSERT INTO Members(MemID, PPSNo, Surname, Forename, DOB, Gender, Street, Town, County, Phone, Email, Reg_Date)
VALUES(3,'5845627GH','SIMPSON','JOHN','07-NOV-90','M','PRINCESS STREET','TRALEE','KERRY','077 5677477','johnsimpson@gmail.com','21-JAN-17');

--Books
INSERT INTO Books(BookID, ISBN, ClassNo, Title, SubjectCode, Author, Edition, Price, NoPages, PubName, CountryCode, YearPublish, PurchaseDate, Book_Status)
VALUES(1,'9847564522','001-SWP','SOFTWARE ENGINEERING PROECT','CPT','SOMMERVILLE',3,45.60,350,'SOMMERVILLE PUBLISHER','GBR',1995,'21-FEB-2016','A');

INSERT INTO Books(BookID, ISBN, ClassNo, Title, SubjectCode, Author, Edition, Price, NoPages, PubName, CountryCode, YearPublish, PurchaseDate, Book_Status)
VALUES(2,'9847005411','001-NWK','NETWORKING FUNDAMENTALS','CPT','CISCO',3,55.60,450,'CISCO PUBLISHER','IRL',1998,'21-FEB-2016','A');

INSERT INTO Books(BookID, ISBN, ClassNo, Title, SubjectCode, Author, Edition, Price, NoPages, PubName, CountryCode, YearPublish, PurchaseDate, Book_Status)
VALUES(3,'9541852061','001-WEB','WEB DESIGN','CPT','JOE BLOGGS',5,35.60,250,'BLOGGS PUBLISHER','USA',2010,'21-FEB-2015','A');

COMMIT;

--Rentals and BookRentalItems Data can be inserted through the system.