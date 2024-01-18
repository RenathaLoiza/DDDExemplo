use AluguelVeiculos
go

create table VeiculoPreco(
	TipoVeiculo int not null,
	Preco decimal (18,0) not null,
	MaxAluguel int not null
	)

	use AluguelVeiculos
	go

	insert into VeiculoPreco (TipoVeiculo, Preco, MaxAluguel)
Values (1, '400', 45),
	   (2, '175', 30),
	   (3, '127', 20)

	  select * from VeiculoPreco