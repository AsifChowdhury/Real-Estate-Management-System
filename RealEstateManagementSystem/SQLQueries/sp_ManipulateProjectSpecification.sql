ALTER PROC sp_ManipulateProjectSpecification
    @projectId int, @specificationTypeId int, @specificationDetails nvarchar(max)
AS
IF EXISTS(SELECT * FROM ProjectSpec WHERE ProjectID = @projectId AND SpecTypeId = @specificationTypeId)
BEGIN
    UPDATE ProjectSpec
	   SET SpecDetails = @specificationDetails
    WHERE SpecTypeId = @specificationTypeId AND ProjectId = @projectId
END
ELSE
BEGIN
    INSERT INTO ProjectSpec
	   (SpecTypeId, ProjectId, SpecDetails)
    VALUES
	   (@specificationTypeId, @projectId, @specificationDetails)
END
GO
SELECT * FROM ProjectSpecification WHERE ProjectId = @projectId AND SpecName = @specificationType