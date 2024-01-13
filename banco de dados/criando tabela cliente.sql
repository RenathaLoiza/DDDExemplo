
CREATE TABLE [dbo].[cliente](
PessoaId int identity (1,1)not null,
Nome varchar not null,
DataNascimento datetime not null,
Habilitação varchar (11)not null,
Estado char (2)not null

)