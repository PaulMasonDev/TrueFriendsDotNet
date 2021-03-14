IF OBJECT_ID(N'dbo.Friends') IS NULL BEGIN
	CREATE TABLE dbo.Friends(
		Id int NOT NULL IDENTITY(1,1),
		FirstName nvarchar(50) NOT NULL,
		LastName nvarchar(50),
		CreatedDate datetime NOT NULL CONSTRAINT dv_EmailAddresses_CreatedDate DEFAULT GETDATE(),
		ModifiedDate datetime NULL,
		CONSTRAINT pk_Friends PRIMARY KEY CLUSTERED (Id)
	);
END;