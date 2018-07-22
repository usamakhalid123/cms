create database crime
use crime
create table login
(
username varchar(20),
password varchar(20)

)
--insert into  login  (username, password) values ('usama','khalid');
--select * from login;
create table criminal_info
(
 c_id int primary key,
 cname varchar(30),
 cnickname varchar (30),
 cgendor varchar (10),
 ccontact int ,
 ccrime varchar (30),
 ccnic int,
 ccity varchar (30),
 cage int ,
 caddress varchar (30)
 )
 create table report (
 r_fir_id int primary key,
 rcase varchar (30),
 rcriminalname varchar (30),
 rinvestofficer varchar (30),
 rname varchar (30),
 rage varchar (30),
 rcontact int ,
 rcnic int ,
  r_id int ,
 rgendor varchar (30),
 rpunishment varchar (30),
 raddress varchar (30)

  )
  create table fir (
  f_fir_id int primary key,
  fcriminalname varchar (30),
  fcase varchar (30),
  finvestofficer varchar (30),
  fpersonname varchar (30),
  fpcontact int ,
  fpgendor varchar (30),
  fpaddress varchar (30),
  fvvictimname varchar (30),
  fvgendor varchar (30),
  fvaddress varchar (30),
    varchar (30)
  )
  create table complaint (
  compid int primary key,
  crname varchar (30),
  cremail varchar (30),
  crcomplain varchar (30),
  croccupation varchar (30),
  crcontact int,
  crgendor varchar(30),
  craddress varchar (30),
  culpritname varchar (30),
  culpritgendor varchar (30),
  culpritaddress varchar (30) 
  )

  delete from report where r_fir_id=4
	  select * from report
