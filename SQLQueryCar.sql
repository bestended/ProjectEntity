create proc carAdd
@carName nvarchar(50),
@carCapacity int,
@carDriverName nvarchar(50),
@carExpense int
as begin
insert into Araclar(carName,carCapacity,carDriverName,carExpense)
values(@carName,@carCapacity,@carDriverName,@carExpense)
end


alter proc CarUpDate
@carNumber int,
@carName nvarchar(50),
@carCapacity int,
@carDriverName nvarchar(50),
@carExpense int,
@customerNumber int,
@shipmentNum int
as begin
update Araclar
set
carName=@carName,
carCapacity=@carCapacity,
carDriverName=@carDriverName,
carExpense=@carExpense,
customerNumber=@customerNumber,
shipmentNum=@shipmentNum
where carNumber=@carNumber
end


create proc carDel
@carNum int
as begin
delete from Araclar
where carNumber=@carNum
end


create proc carList
as begin
select * from Araclar
end








