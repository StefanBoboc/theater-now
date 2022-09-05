insert into CLIENTS values(10,'Pop','Alex','popa@gmail.com',null);
insert into CLIENTS values(20,'Ionescu','Ana','ionescu.a@gmail.com',to_date('18-02-1999','DD-MM-YYYY'));
insert into CLIENTS values(30,'Gabor','Mara','gabor.m@gmail.com',to_date('06-12-1987','DD-MM-YYYY'));
insert into CLIENTS values(40,'Suciu','Matei','suciu.m@gmail.com',to_date('18-05-2001','DD-MM-YYYY'));
insert into CLIENTS values(50,'Avram','George','avram.g@gmail.com',null);
insert into CLIENTS values(60,'Pop','Alex','popa.a@gmail.com',null);
insert into CLIENTS values(70,'Mincu','Daria','mincu.d@yahoo.com',to_date('28-09-2000','DD-MM-YYYY'));

insert into CARDS values(1,'09','23','Visa',30);
insert into CARDS values(2,'04','21','Mastercard',50);
insert into CARDS values(3,'07','22','Mastercard',70);
insert into CARDS values(4,'11','21','Citibank',60);
insert into CARDS values(5,'04','23','Visa',40);
insert into CARDS values(6,'01','24','AmericanExpress',20);

insert into DIRECTOR values(1,'Felix Alexa', 'Alex Ifrim');
insert into DIRECTOR values(2,'Sica Alexandrescu', 'Vlad Musteriu');
insert into DIRECTOR values(3,'Mara Barbu', 'Mara Barbu');
insert into DIRECTOR values(4,'Mihai Bendeac', 'Alexandra Matei');
insert into DIRECTORS values(5,'Sergiu Nicolaescu', 'Dan Nasta');

insert into SHOWS values(10,'Divort in ziua nuntii', 2, 3, 2002, 50, 4, 3);
insert into SHOWS values(11,'Ursul', 3, 3.5, 2010, 20, 2, 3);
insert into SHOWS values(12,'Necasatoria', 2, 4, 2010, 15, 5, 2);
insert into SHOWS values(13,'Cursa de soareci', 2, 2, 1999, 33, 6, 3);
insert into SHOWS values(14,'O noapte furtunoasa', 3, 5, 1999, 45, 4, 1);
insert into SHOWS values(15,'Doi pe o banca', 2, null, 2019, 27, 4, 4);
insert into SHOWS values(16,'Colectionarul', 2, null, 2021, 16, 4, 2);
insert into SHOWS values(17,'Meciul de comedie', 2, 4, 2011, 17, 2, 2);
insert into SHOWS values(18,'Avarul', 2, 4, 2021, 28, 04, 04);
insert into SHOWS values(19,'Salut', 2, 3, 2018, 20, 04, 02);
insert into SHOWS values(20,'Inca una si ma duc', 2, 3, 2018, 20, 04, 02);

insert into RESERVATIONS values(101, 10, 10, to_date('04-11-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(102, 11, 10, to_date('13-10-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(103, 12, 10, to_date('25-03-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(104, 10, 70, to_date('04-12-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(105, 11, 70, to_date('28-08-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(106, 12, 70, to_date('11-01-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(107, 13, 70, to_date('14-08-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(108, 17, 20, to_date('07-12-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(109, 17, 20, to_date('12-08-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(110, 10, 40, to_date('23-10-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(111, 13, 20, to_date('14-08-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(112, 10, 10, to_date('01-06-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(113, 10, 70, to_date('14-10-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(114, 10, 60, to_date('30-10-2021','DD-MM-YYYY'));
insert into RESERVATIONS values(115, 10, 40, to_date('15-06-2020','DD-MM-YYYY'));
insert into RESERVATIONS values(116, 10, 30, to_date('05-06-2020','DD-MM-YYYY'));