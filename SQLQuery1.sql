Create database hostel

Create table rooms(
roomNo bigint not null primary key,
roomStatus varchar(250) not null,
Booked varchar(150) default 'No'
)

roomNo,roomStatus

select * from rooms