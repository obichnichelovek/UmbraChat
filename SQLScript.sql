create database UmbraDB;
use UmbraDb;

create table [User]
(
	ID UNIQUEIDENTIFIER primary key default NEWID(),
	Username nvarchar(50) not null,
	[Password] nvarchar(100) not null
);

insert into [User] values (NEWID(), 'admin', 'you_will_never_guess');
insert into [User] values (NEWID(), 'saba', '31/10/2006');
insert into [User] values (NEWID(), 'user', 'password');
insert into [User] values (NEWID(), 'bot', '01010');