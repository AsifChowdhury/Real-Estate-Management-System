ALTER PROC sp_ValidateREMSUserLogIn
	(@userId varchar(50), @password varchar(50), @isValid bit OUTPUT)
AS
BEGIN
	SET @isValid = 0
    BEGIN TRY
        IF EXISTS(SELECT EmpId FROM Employee WHERE EmpId=@userId)
			BEGIN
				DECLARE @pass varchar(50)
				SELECT @pass = Password_Text FROM Employee WHERE EmpId = @userId
				IF @pass = @password
					BEGIN
						SET @isValid = 1
					END
				ELSE
					BEGIN
						RAISERROR('Mismatch of UserId and Password. Please try again.',16,1)
					END
			END
		ELSE
			BEGIN
				RAISERROR('User not found in Database!!',16,1)
			END
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
