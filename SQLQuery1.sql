Create Table CrudTable (
	Id int Identity(1,1) Primary Key Not Null,
	Proveedor varchar(50) Not Null,
	Moneda varchar(50) Not Null,
	Monto float Not Null,
	Fecha date Not Null,
	Comentario varchar(100)
	);

Select * From CrudTable;

Select Id, Proveedor, Moneda, Monto, Fecha, Comentario From CrudTable;
