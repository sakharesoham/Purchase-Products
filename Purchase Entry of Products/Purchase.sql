create database MobileShop
use MobileShop

create table Company
(
CompanyID bigint identity(1,1),
CompanyName nvarchar(200),
);

select * from Company
drop table Company
delete from Company where CompanyID<1000;

create procedure Pro_CompanyInsert
(
@CompanyID bigint=0,
@CompanyName nvarchar(200),
@CompanyTransactionId bigint
)

as
begin
if @CompanyTransactionId=1
begin
insert into Company(CompanyName) values (@CompanyName)
end
end

create procedure Pro_FetchCompany
as
begin
select CompanyName from Company
end

create procedure Pro_FetchCompanyID(@CompanyName nvarchar(200))
as 
begin
select CompanyID from Company where CompanyName=@CompanyName
end

create table Model
(
ModelID bigint identity(1,1),
CompanyName nvarchar(200),
ModelName nvarchar(200),
ModelDescription nvarchar(200)
);

select * from Model
delete from Model where ModelID<1000;
drop table Model
create procedure Pro_ModelInsert
(
@CompanyName nvarchar(200),
@ModelName nvarchar(200),
@ModelDescription nvarchar(200),
@ModelTransactionId bigint
)

as
begin
if @ModelTransactionId=1
begin
insert into Model(CompanyName,ModelName,ModelDescription) values(@CompanyName,@ModelName,@ModelDescription)
end
end


create table Supplier
(
SupplierID bigint identity(1,1),
SupplierName nvarchar(200),
SupplierMobileNumber bigint,
SupplierAddress nvarchar(200),
SupplierGSTin nvarchar(200),
SupplierBankAccountNumber bigint,
SupplierBankBranch nvarchar(200),
SupplierIFSC nvarchar(200),
SupplierBankCity nvarchar(200),
SupplierPaymentMethod varchar(200)
);

select * from Supplier
drop table Supplier
delete from Supplier where SupplierID<1000;

create procedure Pro_SupplierInsert
(
@SupplierID bigint=0,
@SupplierName nvarchar(200),
@SupplierMobileNumber bigint,
@SupplierAddress nvarchar(200),
@SupplierGSTin nvarchar(200),
@SupplierBankAccountNumber bigint,
@SupplierBankBranch nvarchar(200),
@SupplierIFSC nvarchar(200),
@SupplierBankCity nvarchar(200),
@SupplierPaymentMethod varchar(200),
@SupplierTransactionId bigint
)

as
begin
if @SupplierTransactionId=1
begin
insert into Supplier (SupplierName,SupplierMobileNumber,SupplierAddress,SupplierGSTin,SupplierBankAccountNumber,SupplierBankBranch,SupplierIFSC,
SupplierBankCity,SupplierPaymentMethod) values (@SupplierName,@SupplierMobileNumber,@SupplierAddress,@SupplierGSTin,@SupplierBankAccountNumber,@SupplierBankBranch,@SupplierIFSC,
@SupplierBankCity,@SupplierPaymentMethod)

end
end

create procedure Pro_SupplierName
as
begin
select SupplierName from Supplier
end


create procedure Pro_FetchSupplierID(@SupplierName nvarchar(200))
as 
begin
select SupplierID from Supplier where SupplierName=@SupplierName
end


create table NewProduct
(
ProductID bigint identity(1,1),
ProductName nvarchar(200),
CompanyName nvarchar(200),
ProductMRP bigint,
ProductSAC bigint,
ModelName nvarchar(200),
ProductDescription nvarchar(200),
ProductHSNCode bigint
);

select * from NewProduct;
drop table NewProduct
delete from NewProduct where ProductID<1000;

create procedure Pro_NewProductInsert
(
@ProductID bigint=0,
@ProductName nvarchar(200),
@CompanyName nvarchar(200),
@ProductMRP bigint,
@ProductSAC bigint,
@ModelName nvarchar(200),
@ProductDescription nvarchar(200),
@ProductHSNCode bigint,
@ProductTransactionId bigint

)

as
begin
if @ProductTransactionId=1
begin
insert into NewProduct(ProductName,CompanyName,ProductMRP,ProductSAC,ModelName,ProductDescription,ProductHSNCode) values
(@ProductName,@CompanyName,@ProductMRP,@ProductSAC,@ModelName,@ProductDescription,@ProductHSNCode)
end
end


create procedure Pro_FetchProductName
as
begin
select ProductName from NewProduct
end

create procedure Pro_FetchProductID(@ProductName nvarchar(200))
as 
begin
select ProductID from NewProduct where ProductName=@ProductName
end

create table PurchaseEntry
(
PurchaseID bigint identity(1,1),
PurchaseDate date,
PurchaseSupplierName nvarchar(200),
PurchaseContactNumber bigint,
PurchaseProductName nvarchar(200),
PurchaseHSNCode bigint,
PurchaseCompanyName nvarchar(200),
PurchaseModelName nvarchar(200),
PurchaseGSTRate bigint,
PurchaseQuantity bigint,
PurchaseRate bigint,
PurchaseAmount bigint,
PurchaseTotalAmount bigint,
PurchaseGST bigint,
PurchaseNetAmount bigint,
PurchasePaidAmount bigint,
PurchaseRemainingAmount bigint,
)

select * from PurchaseEntry;

drop table PurchaseEntry
delete from PurchaseEntry where PurchaseID<1000;
create procedure Pro_PurchaseInsert
(
@PurchaseID bigint=0,
@PurchaseDate date,
@PurchaseSupplierName nvarchar(200),
@PurchaseContactNumber bigint,
@PurchaseProductName nvarchar(200),
@PurchaseHSNCode bigint,
@PurchaseCompanyName nvarchar(200),
@PurchaseModelName nvarchar(200),
@PurchaseGSTRate bigint,
@PurchaseQuantity bigint,
@PurchaseRate bigint,
@PurchaseAmount bigint,
@PurchaseTotalAmount bigint,
@PurchaseGST bigint,
@PurchaseNetAmount bigint,
@PurchasePaidAmount bigint,
@PurchaseRemainingAmount bigint,
@PurchaseTransactionId int
)

as
begin
if @PurchaseTransactionId=1
begin
insert into PurchaseEntry
(PurchaseDate,
PurchaseSupplierName,
PurchaseContactNumber ,
PurchaseProductName ,
PurchaseHSNCode ,
PurchaseCompanyName ,
PurchaseModelName ,
PurchaseGSTRate ,
PurchaseQuantity ,
PurchaseRate,
PurchaseAmount ,
PurchaseTotalAmount ,
PurchaseGST ,
PurchaseNetAmount ,
PurchasePaidAmount ,
PurchaseRemainingAmount)

values
(
@PurchaseDate,
@PurchaseSupplierName,
@PurchaseContactNumber ,
@PurchaseProductName ,
@PurchaseHSNCode ,
@PurchaseCompanyName ,
@PurchaseModelName ,
@PurchaseGSTRate ,
@PurchaseQuantity ,
@PurchaseRate,
@PurchaseAmount ,
@PurchaseTotalAmount ,
@PurchaseGST ,
@PurchaseNetAmount ,
@PurchasePaidAmount ,
@PurchaseRemainingAmount
)
end
end

create table Reciept
(
RecieptID bigint identity(1,1),
DateandTime date,
InvoiceNumber bigint,
SupplierName nvarchar(200),
Product nvarchar(200),
Company nvarchar(200),
Model nvarchar(200),
HSNCode bigint,
Quantity bigint,
Rate bigint,
GSTRate bigint,
GSTAmount bigint,
Amount bigint,
PaidAmount bigint,
RemainingAmount bigint
)
drop table Reciept
select * from Reciept;

delete from Reciept where RecieptID<1000;

alter procedure Pro_RecieptInsert
(
@RecieptID bigint=0,
@DateandTime date,
@InvoiceNumber bigint,
@SupplierName nvarchar(200),
@Product nvarchar(200),
@Company nvarchar(200),
@Model nvarchar(200),
@HSNCode bigint,
@Quantity bigint,
@Rate bigint,
@GSTRate bigint,
@GSTAmount bigint,
@Amount bigint,
@PaidAmount bigint,
@RemainingAmount bigint,
@RecieptTransactionId int
)

as
begin
if @RecieptTransactionId=1
begin
insert into Reciept(DateandTime,InvoiceNumber,SupplierName,Product,Company, Model,HSNCode,Quantity,Rate,GSTRate,GSTAmount,Amount,PaidAmount,RemainingAmount) 
values(@DateandTime,@InvoiceNumber,@SupplierName,@Product,@Company,@Model,@HSNCode,@Quantity,@Rate,@GSTRate,@GSTAmount,@Amount,@PaidAmount,@RemainingAmount)
end
end
