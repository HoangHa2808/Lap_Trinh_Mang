create Database SocketChat
go

use SocketChat
go

create Table Users (
	id nvarchar(50) Primary key,
	username nvarchar(50),
	password nvarchar(50),
	name nvarchar(50),
);
go

insert into Users Values(1,'ha','123',N'Đoàn Cao Nhật Hạ');
go
insert into Users Values(2,'du','123',N'Bùi Văn Du');
go

create Table Rooms (
	id nvarchar(50) Primary key,
	name nvarchar(50),
);
go

insert into Rooms Values(1,'roomchat1');
go
insert into Rooms Values(2,'roomchat2');
go
insert into Rooms Values(3,'roomchat3');
go

create Table Participants (
	id nvarchar(50) Primary key,
	userId nvarchar(50) REFERENCES Users(id),
	roomId nvarchar(50) REFERENCES Rooms(id),
);

insert into Participants Values(1,1);
go
insert into Participants Values(1,2);
go
insert into Participants Values(2,1);
go
insert into Participants Values(3,1);
go
insert into Participants Values(3,2);
go

create Table MessPrivate (
	id nvarchar(50) Primary key,
	userId_send nvarchar(50) REFERENCES Users(id),
	userId_receiver nvarchar(50) REFERENCES Users(id),
	message_body nvarchar(255),
	create_at DateTime,
);

create Table MessRoom (
	id nvarchar(50) Primary key,
	roomId nvarchar(50) references Rooms(id),
	userId nvarchar(50) REFERENCES Users(id),
	message_body nvarchar(255),
	create_at DateTime,
);


select * from Users where Users.username = 'ha' and Users.password = '123'