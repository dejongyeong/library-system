--DROP TABLE
DROP TABLE Rentals;
DROP TABLE Members;
DROP TABLE Subjects;
DROP TABLE Countries;
DROP TABLE Books;
DROP TABLE BookRentalItems;
DROP TABLE Month_Reference;

--CREATE TABLE
--Members
CREATE TABLE Members
(MemID numeric(4),
 PPSNo char(9) NOT NULL UNIQUE,
 Surname char(20) NOT NULL,
 Forename char(20) NOT NULL,
 DOB DATE NOT NULL,
 Gender char(1) NOT NULL,
 Street char(25) NOT NULL,
 Town char(20) NOT NULL,
 County char(20) NOT NULL,
 Phone char(14) NOT NULL,
 Email char(40) NOT NULL UNIQUE,
 Reg_Date DATE NOT NULL,
 Books_Borrow numeric(1) DEFAULT 0,
 Fine_Bal numeric(4,2) DEFAULT 0,
 Mem_Status char(1) DEFAULT 'A',
 Dereg_Date DATE,
 CONSTRAINT pk_Members PRIMARY KEY(MemID));
 
 --Books
 CREATE TABLE Books
 (BookID numeric(4),
  ISBN char(13) NOT NULL,
  ClassNo char(7) NOT NULL,
  Title char(110) NOT NULL,
  SubjectCode char(3) NOT NULL,
  Author char(35) NOT NULL,
  Edition numeric(2) NOT NULL,
  Price numeric(5,2) NOT NULL,
  NoPages numeric(4) NOT NULL,
  PubName char(35) NOT NULL,
  CountryCode char(3) NOT NULL,
  YearPublish char(4) NOT NULL,
  PurchaseDate DATE NOT NULL,
  Book_Status char(1) NOT NULL,
  CONSTRAINT pk_Books PRIMARY KEY(BookID),
  CONSTRAINT fk_Books_Subjects FOREIGN KEY(SubjectCode) REFERENCES Subjects,
  CONSTRAINT fk_Books_Countries FOREIGN KEY(CountryCode) REFERENCES Countries);
 
 --Rentals
 CREATE TABLE Rentals
 (LoanID numeric(5),
  MemID numeric(4) NOT NULL,
  BorrowDate DATE NOT NULL,
  DueDate DATE NOT NULL,
  CONSTRAINT pk_Rentals PRIMARY KEY(LoanID),
  CONSTRAINT fk_Members FOREIGN KEY(MemID) REFERENCES Members);
 
 --BookRentalItems
 CREATE TABLE BookRentalItems
 (LoanID numeric(5),
  BookID numeric(4),
  ReturnDate DATE,
  FineAmount numeric(4,2) DEFAULT 0,
  CONSTRAINT pk_BookRentalItems PRIMARY KEY(LoanID,BookID),
  CONSTRAINT fk_Rentals FOREIGN KEY(LoanID) REFERENCES Rentals,
  CONSTRAINT fk_RentalItems_Books FOREIGN KEY(BookID) REFERENCES Books);
  
 --Reference Table
 --Subjects
CREATE TABLE Subjects 
(SubjectCode char(3),
 SubjectName char(35) NOT NULL,
 CONSTRAINT pk_SubjectCode PRIMARY KEY(SubjectCode));
 
--Reference Table
--Countries 
CREATE TABLE Countries
(CountryCode char(3),
 CountryName char(45) NOT NULL,
 CONSTRAINT pk_CountryCode PRIMARY KEY(CountryCode));
 
--Reference Table
--Month_Reference
CREATE TABLE Month_Reference
(Months char(9),
 Value numeric(6,2) DEFAULT 0,
 CONSTRAINT pk_Months PRIMARY KEY(Months));

--Reference: http://www.pagecurl.net/wp-content/uploads/2015/02/BISAC-List-259x300.png
--Populate Subjects Table
--A
INSERT INTO Subjects
VALUES('ATQ','Antiques and Collections');
INSERT INTO Subjects
VALUES('ARC','Architecture');
INSERT INTO Subjects
VALUES('ART','Art');
--B
INSERT INTO Subjects
VALUES('BBL','Bibles');
INSERT INTO Subjects
VALUES('BIO','Biography and Autobiography');
INSERT INTO Subjects
VALUES('BMS','Body, Mind and Spirit');
INSERT INTO Subjects
VALUES('BAE','Business and Economics');
--C
INSERT INTO Subjects
VALUES('CGN','Comics and Graphics Novels');
INSERT INTO Subjects
VALUES('CPT','Computers');
INSERT INTO Subjects
VALUES('CKG','Cooking');
INSERT INTO Subjects
VALUES('CAH','Crafts and Hobbies');
--D
INSERT INTO Subjects
VALUES('DSN','Design');
INSERT INTO Subjects
VALUES('DRM','Drama');
--E
INSERT INTO Subjects
VALUES('EDC','Education');
--F
INSERT INTO Subjects
VALUES('FAR','Family and Relationships');
INSERT INTO Subjects
VALUES('FCT','Fiction');
INSERT INTO Subjects
VALUES('FLS','Foreign Language Study');
--G
INSERT INTO Subjects
VALUES('GAM','Games');
INSERT INTO Subjects
VALUES('GRD','Gardening');
--H
INSERT INTO Subjects
VALUES('HAF','Health and Fitness');
INSERT INTO Subjects
VALUES('HST','History');
INSERT INTO Subjects
VALUES('HSE','House and Home');
INSERT INTO Subjects
VALUES('HUM','Humor');
--J
INSERT INTO Subjects
VALUES('JFC','Juvenile Fiction');
INSERT INTO Subjects
VALUES('JNF','Juvenile Non-Fiction');
--L
INSERT INTO Subjects
VALUES('LAD','Language Arts and Disciplines');
INSERT INTO Subjects
VALUES('LAW','Law');
INSERT INTO Subjects
VALUES('LCO','Literary Collections');
INSERT INTO Subjects
VALUES('LCR','Literary Criticism');
--M
INSERT INTO Subjects
VALUES('MTH','Mathematics');
INSERT INTO Subjects
VALUES('MDC','Medical');
INSERT INTO Subjects
VALUES('MSC','Music');
--N
INSERT INTO Subjects
VALUES('NTR','Nature');
--P
INSERT INTO Subjects
VALUES('PFA','Performing Arts');
INSERT INTO Subjects
VALUES('PET','Pets');
INSERT INTO Subjects
VALUES('PHL','Philosophy');
INSERT INTO Subjects
VALUES('PTG','Photography');
INSERT INTO Subjects
VALUES('PTY','Poetry');
INSERT INTO Subjects
VALUES('POS','Political Science');
INSERT INTO Subjects
VALUES('PSY','Psychology');
--R
INSERT INTO Subjects
VALUES('RFR','Reference');
INSERT INTO Subjects
VALUES('RLG','Religion');
--S
INSERT INTO Subjects
VALUES('SCN','Science');
INSERT INTO Subjects
VALUES('SLH','Self-Help');
INSERT INTO Subjects
VALUES('SOS','Social Science');
INSERT INTO Subjects
VALUES('SAR','Sports and Recreation');
INSERT INTO Subjects
VALUES('STA','Study Aids');
--T
INSERT INTO Subjects
VALUES('TAE','Technology and Engineering');
INSERT INTO Subjects
VALUES('TPT','Transportation');
INSERT INTO Subjects
VALUES('TVL','Travel');
INSERT INTO Subjects
VALUES('TRC','True Crime');
  
--Reference https://en.wikipedia.org/wiki/Books_published_per_country_per_year
--Populate Countries Table
--A
INSERT INTO Countries
VALUES('AFG','Afghanistan');
INSERT INTO Countries
VALUES('ALB','Albania');
INSERT INTO Countries
VALUES('DZA','Algeria');
INSERT INTO Countries
VALUES('AND','Andorra');
INSERT INTO Countries
VALUES('AGO','Angola');
INSERT INTO Countries
VALUES('ARG','Argentina');
INSERT INTO Countries
VALUES('ARM','Armenia');
INSERT INTO Countries
VALUES('AUS','Australia');
INSERT INTO Countries
VALUES('AUT','Austria');
INSERT INTO Countries
VALUES('AZE','Azerbaijan');
--B
INSERT INTO Countries
VALUES('BHR','Bahrain');
INSERT INTO Countries
VALUES('BLR','Belarus');
INSERT INTO Countries
VALUES('BEL','Belgium');
INSERT INTO Countries
VALUES('BEN','Benin');
INSERT INTO Countries
VALUES('BOL','Bolivia');
INSERT INTO Countries
VALUES('BWA','Botswana');
INSERT INTO Countries
VALUES('BRA','Brazil');
INSERT INTO Countries
VALUES('BRN','Brunei');
INSERT INTO Countries
VALUES('BFA','Burkina Faso');
--C
INSERT INTO Countries
VALUES('CAN','Canada');
INSERT INTO Countries
VALUES('CHL','Chile');
INSERT INTO Countries
VALUES('CHN','China');
INSERT INTO Countries
VALUES('COL','Colombia');
INSERT INTO Countries
VALUES('CRI','Costa Rica');
INSERT INTO Countries
VALUES('CUB','Cuba');
INSERT INTO Countries
VALUES('CYP','Cyprus');
INSERT INTO Countries
VALUES('CZE','Czech Republic');
--D
INSERT INTO Countries
VALUES('COD','Democratic Republic of Congo');
INSERT INTO Countries
VALUES('DNK','Denmark');
INSERT INTO Countries
VALUES('DOM','Dominican Republic');
--E
INSERT INTO Countries
VALUES('ECU','Ecuador');
INSERT INTO Countries
VALUES('EGY','Egypt');
INSERT INTO Countries
VALUES('SLV','El Salvador');
INSERT INTO Countries
VALUES('ERI','Eritrea');
INSERT INTO Countries
VALUES('ETH','Ethiopia');
--F
INSERT INTO Countries
VALUES('FJI','Fiji');
INSERT INTO Countries
VALUES('FIN','Finland');
INSERT INTO Countries
VALUES('FRA','France');
--G
INSERT INTO Countries
VALUES('GMB','Gambia');
INSERT INTO Countries
VALUES('GEO','Georgia');
INSERT INTO Countries
VALUES('DEU','Germany');
INSERT INTO Countries
VALUES('GHA','Ghana');
INSERT INTO Countries
VALUES('GRC','Greece');
INSERT INTO Countries
VALUES('GTM','Guatemala');
INSERT INTO Countries
VALUES('GUY','Guyana');
--H
INSERT INTO Countries
VALUES('HND','Honduras');
INSERT INTO Countries
VALUES('HKG','Hong Kong');
INSERT INTO Countries
VALUES('HUN','Hungary');
--I
INSERT INTO Countries
VALUES('ISL','Iceland');
INSERT INTO Countries
VALUES('IND','India');
INSERT INTO Countries
VALUES('IDN','Indonesia');
INSERT INTO Countries
VALUES('IRN','Iran');
INSERT INTO Countries
VALUES('ISR','Israel');
INSERT INTO Countries
VALUES('ITA','Italy');
INSERT INTO Countries
VALUES('IRL','Ireland');
--J
INSERT INTO Countries
VALUES('JPN','Japan');
INSERT INTO Countries
VALUES('JOR','Jordan');
--K
INSERT INTO Countries
VALUES('KAZ','Kazakhstan');
INSERT INTO Countries
VALUES('KEN','Kenya');
INSERT INTO Countries
VALUES('KWT','Kuwait');
INSERT INTO Countries
VALUES('KGZ','Kyrgyzstan');
--L
INSERT INTO Countries
VALUES('LAO','Laos');
INSERT INTO Countries
VALUES('LVA','Latvia');
INSERT INTO Countries
VALUES('LBN','Lebanon');
INSERT INTO Countries
VALUES('LBY','Libya');
INSERT INTO Countries
VALUES('LUX','Luxembourg');
--M
INSERT INTO Countries
VALUES('MDG','Madagascar');
INSERT INTO Countries
VALUES('MWI','Malawi');
INSERT INTO Countries
VALUES('MYS','Malaysia');
INSERT INTO Countries
VALUES('MLI','Mali');
INSERT INTO Countries
VALUES('MLT','Malta');
INSERT INTO Countries
VALUES('MUS','Mauritius');
INSERT INTO Countries
VALUES('MEX','Mexico');
INSERT INTO Countries
VALUES('MCO','Monaco');
INSERT INTO Countries
VALUES('MNG','Mongolia');
INSERT INTO Countries
VALUES('MAR','Morocco');
INSERT INTO Countries
VALUES('MMR','Myanmar');
--N
INSERT INTO Countries
VALUES('NAM','Namibia');
INSERT INTO Countries
VALUES('NPL','Nepal');
INSERT INTO Countries
VALUES('NLD','Netherlands');
INSERT INTO Countries
VALUES('NZL','New Zealand');
INSERT INTO Countries
VALUES('NIC','Nicaragua');
INSERT INTO Countries
VALUES('NGA','Nigeria');
INSERT INTO Countries
VALUES('NOR','Norway');
--O
INSERT INTO Countries
VALUES('OMN','Oman');
--P
INSERT INTO Countries
VALUES('PAK','Pakistan');
INSERT INTO Countries
VALUES('PSE','Palestine');
INSERT INTO Countries
VALUES('PAN','Panama');
INSERT INTO Countries
VALUES('PNG','Papua New Guinea');
INSERT INTO Countries
VALUES('PRY','Paraguay');
INSERT INTO Countries
VALUES('PER','Peru');
INSERT INTO Countries
VALUES('PHL','Philippines');
INSERT INTO Countries
VALUES('POL','Poland');
INSERT INTO Countries
VALUES('PRT','Portugal');
--Q
INSERT INTO Countries
VALUES('QAT','Qatar');
--R
INSERT INTO Countries
VALUES('ROU','Romania');
INSERT INTO Countries
VALUES('RUS','Russian Federation');
INSERT INTO Countries
VALUES('REU','Reunion');
--S
INSERT INTO Countries
VALUES('SAU','Saudi Arabia');
INSERT INTO Countries
VALUES('SGP','Singapore');
INSERT INTO Countries
VALUES('SVK','Slovakia');
INSERT INTO Countries
VALUES('KOR','South Korea');
INSERT INTO Countries
VALUES('ESP','Spain');
INSERT INTO Countries
VALUES('LKA','Sri Lanka');
INSERT INTO Countries
VALUES('SUR','Suriname');
INSERT INTO Countries
VALUES('SWE','Sweden');
INSERT INTO Countries
VALUES('CHE','Switzerland');
INSERT INTO Countries
VALUES('SYR','Syrian Arab Republic');
INSERT INTO Countries
VALUES('ZAF','South Africa');
--T
INSERT INTO Countries
VALUES('TWN','Taiwan');
INSERT INTO Countries
VALUES('TJK','Tajikistan');
INSERT INTO Countries
VALUES('TZA','Tanzania');
INSERT INTO Countries
VALUES('THA','Thailand');
INSERT INTO Countries
VALUES('TUN','Tunisia');
INSERT INTO Countries
VALUES('TUR','Turkey');
INSERT INTO Countries
VALUES('TKM','Turkmenistan');
--U
INSERT INTO Countries
VALUES('UGA','Uganda');
INSERT INTO Countries
VALUES('UKR','Ukraine');
INSERT INTO Countries
VALUES('ARE','United Arab Emirates');
INSERT INTO Countries
VALUES('GBR','United Kingdom');
INSERT INTO Countries
VALUES('USA','United States');
INSERT INTO Countries
VALUES('URY','Uruguay');
INSERT INTO Countries
VALUES('UZB','Uzbekistan');
--V
INSERT INTO Countries
VALUES('VEN','Venezuela');
INSERT INTO Countries
VALUES('VNM','Vietnam');
--Z
INSERT INTO Countries
VALUES('ZWE','Zimbabwe');

--Populate Month_Reference Table
INSERT INTO Month_Reference(Months)
VALUES('JANUARY');
INSERT INTO Month_Reference(Months)
VALUES('FEBRUARY');
INSERT INTO Month_Reference(Months)
VALUES('MARCH');
INSERT INTO Month_Reference(Months)
VALUES('APRIL');
INSERT INTO Month_Reference(Months)
VALUES('MAY');
INSERT INTO Month_Reference(Months)
VALUES('JUNE');
INSERT INTO Month_Reference(Months)
VALUES('JULY');
INSERT INTO Month_Reference(Months)
VALUES('AUGUST');
INSERT INTO Month_Reference(Months)
VALUES('SEPTEMBER');
INSERT INTO Month_Reference(Months)
VALUES('OCTOBER');
INSERT INTO Month_Reference(Months)
VALUES('NOVEMBER');
INSERT INTO Month_Reference(Months)
VALUES('DECEMBER');

COMMIT;