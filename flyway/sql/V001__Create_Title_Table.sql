use[DockerTestDb];

GO
CREATE TABLE [Products] (
    [Id] int NOT NULL IDENTITY,
    [Name] varchar(500) NOT NULL,
	[Price] Decimal(18,2) NOT NULL,
    CONSTRAINT [PK_ProductId] PRIMARY KEY ([Id])
);
GO



INSERT INTO [Products] (Name,Price) VALUES ('Laptop', 1000.00)
INSERT INTO [Products] (Name,Price) VALUES ('Mouse', 10.00)
INSERT INTO [Products] (Name,Price) VALUES ('Monitor', 200.00)

GO