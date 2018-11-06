
USE [DockerTestDb];
GO

CREATE TABLE dbo.Products (
    [Id] int NOT NULL IDENTITY,
    [Name] varchar(500) NOT NULL,
	[Price] Decimal(18,2) NOT NULL,
    CONSTRAINT [PK_ProductId] PRIMARY KEY ([Id])
);
GO



INSERT INTO dbo.Products (Name,Price) VALUES ('Laptop', 1000.00)
INSERT INTO dbo.Products (Name,Price) VALUES ('Mouse', 10.00)
INSERT INTO dbo.Products (Name,Price) VALUES ('Monitor', 200.00)
INSERT INTO dbo.Products (Name,Price) VALUES ('Head phone', 100.00)


GO