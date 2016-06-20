ALTER PROC sp_ManipulateBuildingData
    @buildingId int, @buildingName varchar(50), @countOfBasements int, @countOfFloors int, @user varchar(50), @workstationIP varchar(50)
AS
BEGIN
    BEGIN TRY
	   BEGIN TRANSACTION
	   --SELECT * FROM BuildingBlocks
	   UPDATE BuildingBlocks SET Name = @buildingName WHERE BuildingId = @buildingId
	   
	   DECLARE @existingFloors int
	   SELECT @existingFloors = ISNULL(COUNT(FloorId),0) FROM FloorInfo WHERE BuildingId = @buildingId
	   
	   IF @existingFloors < 1
	   BEGIN
		  IF @countOfBasements > 0
		  BEGIN
			 DECLARE @basementNumber int = 1
			 WHILE @basementNumber <= @countOfBasements
			 BEGIN
				SELECT * FROM FloorInfo
				INSERT INTO FloorInfo
				    (BuildingId, FloorType, FloorNumber, EntryMadeBy, UpdatedFrom)
				VALUES
				    (@buildingId, 'Basement', @basementNumber, @user, @workstationIP)
				SET @basementNumber = @basementNumber + 1 
			 END
		  END

		  IF @countOfFloors > 0
		  BEGIN
			 DECLARE @floorNumber int = 0
			 WHILE @floorNumber < @countOfFloors
			 BEGIN
				INSERT INTO FloorInfo
				    (BuildingId, FloorType, FloorNumber, EntryMadeBy, UpdatedFrom)
				VALUES
				    (@buildingId, 'Floor', @floorNumber, @user, @workstationIP)
			 
				SET @floorNumber = @floorNumber + 1
			 END
		  END
	   END
	   COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
	   IF @@TRANCOUNT > 0
		  ROLLBACK TRANSACTION;

	   DECLARE @ErrorNumber INT = ERROR_NUMBER();
	   DECLARE @ErrorLine INT = ERROR_LINE();
	   DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
	   DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
	   DECLARE @ErrorState INT = ERROR_STATE();

	   --PRINT 'Actual error number: ' + CAST(@ErrorNumber AS VARCHAR(10));
	   --PRINT 'Actual line number: ' + CAST(@ErrorLine AS VARCHAR(10));

	   RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	   --THROW;
    END CATCH
END;
GO
SELECT * FROM FloorInfo