USE ThiASP
GO
CREATE PROC sp_list_cat
AS
	SELECT CatID, CatName FROM dbo.tblCat
GO
CREATE PROC sp_list_pro_catid
@catid INT
AS
	SELECT COUNT(ProID), ProID, ProName, ProDescription, dbo.tblPro.CatID, dbo.tblCat.CatName FROM dbo.tblPro INNER JOIN dbo.tblCat ON tblCat.CatID = tblPro.CatID WHERE dbo.tblPro.CatID = @catid GROUP BY ProID, ProName, ProDescription, dbo.tblPro.CatID, dbo.tblCat.CatName
GO
create PROC sp_list_pro
AS
	SELECT ProID, ProName, ProDescription, dbo.tblPro.CatID FROM dbo.tblPro 
GO
CREATE PROC sp_Delete_pro
@proid INT
AS
	DELETE dbo.tblPro WHERE ProID = @proid;
GO

CREATE PROC sp_update_pro
@proid INT,
@proname NVARCHAR(50),
@prodes NVARCHAR(250),
@catid INT
AS
	UPDATE dbo.tblPro SET ProName = @proname, ProDescription = @prodes, CatID = @catid WHERE ProID = @proid 
GO
CREATE PROC sp_Add_pro
@proname NVARCHAR(50),
@prodes NVARCHAR(250),
@catid INT
AS
	INSERT INTO dbo.tblPro
	(
	    ProName,
	    ProStatus,
	    ProDescription,
	    CatID
	)
	VALUES
	(   @proname, -- ProName - nvarchar(50)
	    1,   -- ProStatus - int
	    @prodes, -- ProDescription - nvarchar(50)
	    @catid    -- CatID - int
	    )
GO