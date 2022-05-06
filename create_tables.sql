/*create database schoolportfolio;
use schoolportfolio;
create table School (PK_school mediumint unsigned auto_increment primary key,
name_school varchar(100),
address_school varchar(100),
date_create_school date);

create table Users (PK_users mediumint unsigned primary key auto_increment,
Login_user varchar(30) unique,
Password_user varchar(30),
Surname varchar(40),
First_name varchar(40),
Second_name varchar(40),
Date_birth date,
Number_phone varchar(18),
Address_mail varchar(50),
FK_School mediumint unsigned,
foreign key (FK_School) references School(PK_school));

create table Teacher (PK_teacher mediumint unsigned primary key auto_increment,
FK_user mediumint unsigned,
foreign key (FK_user) references Users(PK_users));

create table class (PK_class mediumint unsigned primary key auto_increment,
number_class tinyint unsigned,
leater char,
FK_teacher mediumint unsigned,
Foreign key (FK_teacher) references Teacher(PK_teacher));

create table pupil (PK_pupil mediumint unsigned primary key auto_increment,
FK_user mediumint unsigned,
FK_class mediumint unsigned,
Foreign key (FK_class) references Class(PK_class),
foreign key (FK_user) references Users(PK_users));

create table position (PK_position tinyint unsigned primary key auto_increment,
name_position varchar(40));

create table Administration (PK_administration mediumint unsigned primary key auto_increment,
FK_user mediumint unsigned,
FK_position tinyint unsigned,
foreign key (FK_user) references Users(PK_users),
Foreign key (FK_position) references Position (PK_position));

create table System_administrator (PK_System_administrator mediumint unsigned primary key auto_increment,
FK_user mediumint unsigned,
foreign key (FK_user) references Users(PK_users));

/*===========================================================*/
/*
INSERT INTO school (`name_school`, `address_school`) VALUES ('МБОУ СОШ № 1 г. Рубцовска', 'ул. Светлова, 90, Рубцовск, Россия');


INSERT INTO position (`name_position`) VALUES ('Директор');
INSERT INTO position (`name_position`) VALUES ('Завуч по учебной работе');
INSERT INTO position (`name_position`) VALUES ('Завуч по учебно-воспитательной работе');

INSERT INTO `schoolportfolio`.`users` (`PK_users`, `Login_user`, `Password_user`, `Surname`, `First_name`, `Second_name`, `Date_birth`, `Number_phone`, `Address_mail`, `FK_School`) VALUES ('1', 'sysadmin', '1', 'Мошкин', 'Дмитрий', '-', '1986-10-02', '+7 (912) 923-09-12', 'moshkinda@yandex.ru', '1');

INSERT INTO `schoolportfolio`.`system_administrator` (`FK_user`) VALUES ('1');*/


create table level_achiv (PK_lvl mediumint unsigned primary key auto_increment,
name_lvl varchar(50));

create table Kind_Of_Activity (PK_activity mediumint unsigned primary key auto_increment,
name_activity varchar(350)
);

create table place (PK_place mediumint unsigned primary key auto_increment,
name_place varchar(20)
);

create table achivements (PK_achivement mediumint unsigned primary key auto_increment,
FK_lvl mediumint unsigned,
FK_activity mediumint unsigned,
FK_place mediumint unsigned,
balls mediumint unsigned,
foreign key (FK_lvl) references level_achiv(PK_lvl),
foreign key (Fk_activity) references Kind_Of_Activity (PK_activity),
foreign key (Fk_place) references place (PK_place));

create table contest_and_event (PK_event  mediumint unsigned primary key auto_increment,
name_event varchar(100),
date_event date,
place_event varchar(100),
FK_place_event mediumint unsigned, 
foreign key (Fk_place_event) references place (PK_place));

create table participation (PK_participation mediumint unsigned primary key auto_increment,
FK_pupil mediumint unsigned,
FK_achivements mediumint unsigned,
FK_event  mediumint unsigned,
foreign key (FK_pupil) references pupil(PK_pupil),
foreign key (FK_achivements) references achivements(PK_achivement),
foreign key (FK_event) references contest_and_event(PK_event)
);


/* update datatable */

create table terrain_coefficients (PK_Terr_Coeff mediumint unsigned primary key auto_increment,
terrain_factor_name varchar(50),
terrain_factor_balls tinyint unsigned);

create table event_coefficients (pk_event_coeff mediumint unsigned primary key auto_increment,
name_event_coefficient varchar(300),
event_coefficient_balls tinyint unsigned);

create table events(PK_event  mediumint unsigned primary key auto_increment,
name_event varchar(100),
date_event date,
geogr_place varchar(100),
fk_place_factor mediumint unsigned,
FK_event_coefficient mediumint unsigned,
FK_win_coeff mediumint unsigned,
availability_place boolean,
foreign key (fk_place_factor) references terrain_coefficients(PK_Terr_Coeff),
foreign key (FK_event_coefficient) references event_coefficients(pk_event_coeff));

create table prize_winning_coefficient (pk_win_coeff mediumint unsigned primary key auto_increment,
name_win_coeff varchar(50),
win_coeff_balls tinyint unsigned);

create table participation (PK_participation mediumint unsigned primary key auto_increment,
FK_pupil mediumint unsigned,
FK_event  mediumint unsigned,
foreign key (FK_pupil) references pupil(PK_pupil),
foreign key (FK_event) references events(PK_event),
foreign key (FK_win_coeff) references prize_winning_coefficient(pk_win_coeff)
);






















