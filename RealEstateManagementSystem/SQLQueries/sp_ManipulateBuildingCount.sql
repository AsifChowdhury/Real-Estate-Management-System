ALTER PROC sp_ManipulateBuildingCount @projectId       INT,
                                      @countOfBuilding INT,
                                      @user            VARCHAR(50),
                                      @manipulatedFrom VARCHAR(50)
AS
BEGIN
    IF @countOfBuilding < 1
	   BEGIN
		  RAISERROR('Number of Building Cannot be less than 1', 16, 1);
	   END;
    ELSE
	   BEGIN
	       BEGIN TRY
		  	 BEGIN TRANSACTION;
			 DECLARE @i AS INT;
			 SET @i = 1;
			 WHILE @i <= @countOfBuilding
				BEGIN
				    INSERT INTO dbo.BuildingBlocks
	   				    (BuildingNumber,Name,ProjectId,EntryMadeBy,EntryMadeOn,EntryMadeFrom)
				    VALUES
			 		    (@i, CONVERT(varchar(5),@i), @projectId, @user, getdate(), @manipulatedFrom);
				    SET @i = @i + 1
				END;
			 COMMIT TRANSACTION;
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
		  END CATCH;
	   END
END;
GO
--EXEC sp_ManipulateBuildingCount 84,5,'test','1111'
--SELECT * FROM ProjectInfo WHERE ProjectName = 'SEL ABHISHEK'
--DELETE BuildingBlocks WHERE EntryMadeFrom = '192.168.56.1'
--SELECT * FROM BuildingBlocks WHERE ProjectId = 230
SELECT * FROM BuildingNumber