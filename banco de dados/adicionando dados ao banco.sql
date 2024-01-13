USE [AluguelVeiculos]
GO

INSERT INTO [dbo].[Veiculo]
           ([Placa]
           ,[AnoFabricacao]
           ,[TipoVeiculoId]
           ,[Estado]
           ,[MontadoraId]
           ,[Alugado])
     VALUES
           ('abc1234', 2020, 1, 'SP', 1, 1),
		   ('abc1254', 2022, 2, 'MG', 1, 1),
		   ('abc1264', 2024, 3, 'PR', 1, 1),
		   ('abc1274', 2023, 1, 'MG', 1, 0),
		   ('abc1294', 2023, 3, 'SP', 1, 0),
		   ('abc1204', 2023, 2, 'SP', 1, 0)
GO


