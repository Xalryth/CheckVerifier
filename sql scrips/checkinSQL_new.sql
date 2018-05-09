create database checkin;
use checkin;

create table location(
locationid smallint not null identity(1, 1),
shortname varchar(2) not null unique,
fullname varchar(32) not null unique,

primary key(locationid)
);

create table usertype(
usertypeid smallint not null identity(1, 1),
usertype varchar(32) not null unique,

primary key(usertypeid)
);

create table cardtype(
cardtypeid tinyint not null identity(1, 1),
cardtype varchar(32) not null unique,

primary key(cardtypeid)
);

create table logtype(
logtypeid tinyint not null identity(1, 1),
logtype varchar(32) not null unique,

primary key(logtypeid)
);

create table cuser(
userid int not null identity(1, 1),
unilogin varchar(16) not null unique,
usertypeid smallint not null,
locationid smallint not null,

primary key(userid),
foreign key(usertypeid) references usertype(usertypeid)
on update cascade,
foreign key(locationid) references location(locationid)
on update cascade
);

create table card(
cardid varchar(8) not null,
userid int not null,
cardtypeid tinyint not null,
creationdate date not null default(getdate()),
expirationdate date,

primary key(cardid),
foreign key(userid) references cuser(userid)
on update cascade
on delete cascade,
foreign key(cardtypeid) references cardtype(cardtypeid)
on update cascade
);

create table stamp(
stampdate date not null default(getdate()),
userid int not null,
checkin time default(current_timestamp),
checkout time default(current_timestamp),
flags smallint not null default(0),
flex float default(0),

primary key(stampdate, userid),
foreign key(userid) references cuser(userid)
on update cascade
on delete cascade
);

create table log(
logid bigint not null identity(1, 1),
logtext varchar(128) not null,
logtypeid tinyint not null,
created datetime not null default(current_timestamp),

primary key(logid),
foreign key(logtypeid) references logtype(logtypeid)
on update cascade
);

create index locationI on location(locationid);
create index usertypeI on usertype(usertypeid);
create index cardtypeI on cardtype(cardtypeid);
create index logtypeI on logtype(logtypeid);
create index cuserI on cuser(userid);
create index cardI on card(cardid);
create index stampI on stamp(stampdate);
create index logI on log(logtypeid);

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE checkin.CreateStamp
	@userid int,
	@flags smallint
AS
BEGIN
	SET NOCOUNT ON;
	insert into stamp values(default, @userid, default, null, @flags, null);
END
GO

-- Card Expiration
--Does this work? - Passport
CREATE FUNCTION checkin.CardExpired (@cardId varchar(8))  
RETURNS BIT  
WITH EXECUTE AS CALLER  
AS  
BEGIN
     RETURN GETDATE() > (SELECT expirationdate FROM card WHERE cardid = @cardId);  
END  
GO  