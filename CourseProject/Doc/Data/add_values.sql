CREATE OR REPLACE FUNCTION public.add_values()
 RETURNS void
 LANGUAGE sql
AS $function$
	insert into home_postoffice (id ,"name" , address)
	values
	(1,'post office 1', 'address 1'),
	(2,'post office 2', 'address 2'),
	(3,'post office 3', 'address 3');
	insert into home_publishinghouse (id ,"name",address)
	values
	(1,'publishing house 1', 'address 561'),
	(2,'publishing house 2', 'address 651'),
	(3,'publishing house 3', 'address 831');
	insert into home_publication (id,"name", publishing_house_id)
	values
	(1,'publication 1',1),
	(2,'publication 2',2),
	(3,'publication 3',3),
	(4,'publication 4',1),
	(5,'publication 5',3),
	(6,'publication 6',3),
	(7,'publication 7',2),
	(8,'publication 8',2),
	(9,'publication 9',1),
	(10,'publication 10',2),
	(11,'publication 11',2),
	(12,'publication 12',1);
	insert into home_release (id,price,count,publication_id,post_office_id)
	values
	(1,10,30,1,1),
	(2,15,50,2,2),
	(3,30,1000,3,3),
	(4,20,300,4,1),
	(5,100,100,5,2),
	(6,50,250,6,3),
	(7,60,150,7,1),
	(8,35,100,8,2),
	(9,40,70,9,3);
	insert into home_subscription (id,start_date, description,end_date , term,release_id)
	values
	(1,TO_DATE('12/11/2018', 'DD/MM/YYYY'),'Lorem ipsum dolor sit amet,
 	consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
	labore et dolore magna aliqua. Ut enim ad minim veniam,
 	quis nostrud exercitation ullamco laboris nisi ut aliquip
 	ex ea commodo consequat. Duis dfaute irure dolor in reprehenderit 
	in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
 	Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',TO_DATE('12/04/2019', 'DD/MM/YYYY'),5,1),
 	(2,TO_DATE('12/11/2018', 'DD/MM/YYYY'),'Lorem ipsum dolor sit amet,
 	consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
	labore et dolore magna aliqua. Ut enim ad minim veniam,
 	quis nostrud exercitation ullamco laboris nisi ut aliquip
 	ex ea commodo consequat. Duis aute irure dolor in reprehenderit 
	in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
 	Excepteur sint occaecat cupidatat nodfn proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',TO_DATE('12/01/2019', 'DD/MM/YYYY'),2,2),
 	(3,TO_DATE('12/11/2018', 'DD/MM/YYYY'),'Lorem ipsum dolor sit amet,
 	consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
	labore et dolore magna aliqua. Ut enim ad minim veniam,
 	quis nostrud exercitation ullamco laboris nisi ut aliquip
 	ex ea commodo consequat. Duis aute irure dolor in reprehenderit 
	in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
 	Excepteur sint occaecat cupidatat non proident, fdsunt in culpa qui officia deserunt mollit anim id est laborum.',TO_DATE('12/12/2018', 'DD/MM/YYYY'),1,3),
 	(4,TO_DATE('12/11/2018', 'DD/MM/YYYY'),'Lorem ipsum dolor sit amet,
 	consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
	labore et dolore magna aliqua. Ut enim ad minim veniam,
 	quis nostrud exercitation ullamco laboris nisi ut aliquip
 	ex ea commodo consequat. Duis aute irure dolor in reprehenderit 
	in voluptate velit esse cillum dvczolore eu fugiat nulla pariatur.
 	Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',TO_DATE('12/02/2019', 'DD/MM/YYYY'),3,4),
 	(5,TO_DATE('12/11/2018', 'DD/MM/YYYY'),'Lorem ipsum dolor sit amet,
 	consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
	labore et dolore magna aliqua. Ut enim ad minim veniam,
 	quis nostrud exercitation ullamco laboris nisi ut aliquip
 	ex ea commodo consequat. Duis aute irure dolor in reprehenderit 
	in voluptate velit esse cillum dolore eu fugiatsa nulla pariatur.
 	Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',TO_DATE('12/01/2019', 'DD/MM/YYYY'),2,5),
 	(6,TO_DATE('12/11/2018', 'DD/MM/YYYY'),'Lorem ipsum dolor sit amet,
 	consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
	labore et dolore magna aliqua. Ut enim ad minim veniam,
 	quis nostrud exercitation ullamco laboris ngfisi ut aliquip
 	ex ea commodo consequat. Duis aute irure dolor in reprehenderit 
	in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
 	Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',TO_DATE('12/11/2019', 'DD/MM/YYYY'),12,6);
 	insert into home_position (id,"name" , salary)
	values
	(1,'Postman',50),
	(2,'Operator',75),
	(3,'Manager',150);
	insert into home_employee (id,first_name,last_name,middle_name,email,phone,position_id,post_office_id)
	values                      
	(2,'Pakhom','Menshikov','Samsonovich','example1@gmail.com','+375333415378',1,1),
	(3,'Pakhom','Zakryatin','Nikanorovich','example2@gmail.com','+375333515378',1,1),
	(4,'Agap','Shein','Nikiforovich','example3@gmail.com','+375333615378',1,1),
	(5,'Vladlen','Mikhalitsyn','Samuilovich','example4@gmail.com','+375333715378',2,1),
	(6,'Varvara','Selezneva','Georgievna','example5@gmail.com','+375333225378',3,1),
	(7,'Efrosinya','Dvornikova','Davidovna','example6@gmail.com','+375333315378',1,2),
	(8,'Anna','Alliluyeva','Bronislavovna','example7@gmail.com','+375333216378',1,2),
	(9,'Agata','Domasha','Ippolitovna','example8@gmail.com','+375333221378',2,2),
	(10,'Zoya','Rodionova','Mikheevna','example9@gmail.com','+375333217778',3,2),
	(11,'Ksenia','Tabernakulova','Yulievna','example10@gmail.com','+375333211318',1,3),
	(12,'Terenty','Kotyash','Nikanorovich','example11@gmail.com','+375333245338',2,3),
	(13,'Margarita','Bandurkina','Timurovna','example12@gmail.com','+375333225379',2,3),
	(14,'Matvey','Sechenov','Onisimovich','example13@gmail.com','+375333216373',3,3);
	insert into home_region (id,"index" , post_office_id, postman_id)
	values
	(1,1,1,2),
	(2,2,1,3),
	(3,3,1,3),
	(4,4,1,4),
	(5,5,2,8),
	(6,6,2,8),
	(7,7,2,7),
	(8,8,2,8),
	(9,9,3,11),
	(10,10,3,11);
	insert into home_house (id,address,region_id)
	values
	(1,'Address house 1',1),
	(2,'Address house 2',2),
	(3,'Address house 3',3),
	(4,'Address house 4',4),
	(5,'Address house 5',5),
	(6,'Address house 6',6),
	(7,'Address house 7',7),
	(8,'Address house 8',8),
	(9,'Address house 9',9),
	(10,'Address house 10',10),
	(11,'Address house 11',1),
	(12,'Address house 12',2),
	(13,'Address house 13',3),
	(14,'Address house 14',4),
	(15,'Address house 15',5),
	(16,'Address house 16',6),
	(17,'Address house 17',7),
	(18,'Address house 18',8),
	(19,'Address house 19',9),
	(20,'Address house 20',10),
	(21,'Address house 21',1),
	(22,'Address house 22',2),
	(23,'Address house 23',3),
	(24,'Address house 24',4),
	(25,'Address house 25',5),
	(26,'Address house 26',6),
	(27,'Address house 27',7),
	(28,'Address house 28',7),
	(29,'Address house 29',8),
	(30,'Address house 30',9),
	(31,'Address house 31',10),
	(32,'Address house 32',1),
	(33,'Address house 33',2),
	(34,'Address house 34',3),
	(35,'Address house 35',4),
	(36,'Address house 36',5),
	(37,'Address house 37',6),
	(38,'Address house 38',7),
	(39,'Address house 39',8),
	(40,'Address house 40',9),
	(41,'Address house 41',10);
	insert into home_follower (id,first_name,last_name,middle_name,email,phone,house_id)
	values
	(1,'Timothy','Hayden','Diaz','example1001@gmail.com','+375333421378',1),
	(2,'Gavin','Luis','Bryant','example1002@gmail.com','+375333515148',2),
	(3,'Joseph','Hayden','Lopez','example1003@gmail.com','+375333635378',3),
	(4,'Thomas','Miguel','Miller','example1004@gmail.com','+375331315378',4),
	(5,'Evan','Bryan','Hughes','example1005@gmail.com','+375333225978',5),
	(6,'Mason','Adrian','Watson','example1006@gmail.com','+375333313518',6),
	(7,'Juan','Luke','Reed','example1007@gmail.com','+375333217128',7),
	(8,'John','John','Washington','example1008@gmail.com','+375333278958',8),
	(9,'Dominic','Steven','Thompson','example1009@gmail.com','+375333211238',9),
	(10,'Xavier','Anthony','Griffin','example10010@gmail.com','+375333456718',10),
	(11,'Ryan','Joseph','Barnes','example10011@gmail.com','+375333245123',11),
	(12,'Samuel','Blake','Thomas','example10012@gmail.com','+37533357179',12),
	(13,'Richard','Connor','Flores','example10013@gmail.com','+375333461373',13),
	(14,'Austin','Ethan','Peterson','example10014@gmail.com','+375333416578',14),
	(15,'Jack','Connor','Thompson','example10015@gmail.com','+375333511278',15),
	(16,'Gavin','James','Butler','example10016@gmail.com','+375333615498',16),
	(17,'Luis','Gavin','Martinez','example10017@gmail.com','+375333711238',17),
	(18,'Jackson','Landon','Davis','example10018@gmail.com','+375333451378',18),
	(19,'Colin','Landon','Thomas','example10019@gmail.com','+375333356128',19),
	(20,'Isaac','Cole','Wood','example10020@gmail.com','+375333216418',20);
$function$
;
