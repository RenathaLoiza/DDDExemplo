use AluguelVeiculos
go

create table dbo.Veiculo(
	VeiculoId int primary key IDENTITY(1,1) NOT NULL,
	Placa varchar(7) NOT NULL,
	AnoFabricacao int NOT NULL,
	TipoVeiculoId int NOT NULL,
	Estado char (2) NOT NULL,
	MontadoraId int NOT NULL,
	Alugado bit not NULL,
	)