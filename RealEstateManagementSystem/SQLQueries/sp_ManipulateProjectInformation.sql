ALTER PROC [dbo].[prcManipulateProjectInfo]
	@projectId int, @locationId int, @inChargeId int, @architectId int, @structuralDesignerId int, 
	@projectName varchar(100), @projectName_Bangla nvarchar(150),
	@address varchar(250), @address_Bangla nvarchar(350), 
	@area float, @remarks varchar(300), 
	@plotTakeover datetime,	@agreementSign datetime, 
	@startedOn datetime, @approvalDate datetime, 
	@constructionDuration int, @constructionGracePeriod int,
	@saleStartedOn datetime, @approxCompletion datetime, @handoverDate datetime, 
    @landTypeId int, @projectCode int, 
    @entryAvailable tinyint, @showInWeb tinyint,
    @geoLocation varchar(50),
    @SignatoryId int, @pile smallint, @isCancelledProject smallint, @projectTypeId int, 
    @rajukNumber varchar(400),
	@manipulatedBy varchar(50), @manipulatedFrom varchar(50)
AS
BEGIN
	DECLARE @err nVarchar(max), @tempProjectName varchar(100)
	SET @err = ''
	IF EXISTS (SELECT ProjectId FROM ProjectInfo WHERE ProjectName = @projectName AND ProjectId != @projectId)
		BEGIN
			SET @err = 'Project Name <'+ @projectName +'> is already available in Database.'
		END

	IF EXISTS (SELECT ProjectId FROM ProjectInfo WHERE ProjectCode = @projectCode AND ProjectId != @projectId)
		BEGIN
			SELECT @tempProjectName = ProjectName FROM ProjectInfo WHERE ProjectCode = @projectCode
			SET @err = 'Project Code <'+ @projectCode +'> is already assosiated with Project Name <'+ @tempProjectName +'>.'
		END
	
	IF @projectName = ''
		BEGIN
			SET @err = 'Project Name cannot be blank.'
		END

	IF @projectCode < 1
		BEGIN
			SET @err = 'Invalid project code.'
		END

	IF @address = ''
		BEGIN
			SET @err = 'Address cannot be blank.'
		END

	IF @err <> ''
		BEGIN
			RAISERROR(@err,16,1)
		END
	ELSE
		BEGIN
			BEGIN TRY
				IF EXISTS(SELECT * FROM ProjectInfo WHERE ProjectId = @projectId)
					BEGIN
						UPDATE ProjectInfo 
						SET 
							LocationId=@locationId, InChargeId=@inChargeId, ArchitectId=@architectId, StructuralDesignerId=@structuralDesignerId,
							ProjectName=@projectName, ProjectName_Bangla=@projectName_Bangla, [Address]=@address, Address_Bangla=@address_Bangla, 
							Area=@area, Remarks=@remarks,
							PlotTakeOverDate=@plotTakeover, AgreementSign=@agreementSign, StartedOn=@startedOn, ApprovalDate=@approvalDate,
							ConstructionDuration=@constructionDuration, ConstructionGracePeriod=@constructionGracePeriod,
							SaleStartedOn=@saleStartedOn, Completion=@approxCompletion, Handover=@handoverDate,
							LandTypeId=@landTypeId,	ProjectCode=@projectCode, 
							EntryAvailable=@entryAvailable, ShowInWeb=@showInWeb, GeoLocation=@geoLocation, 
							SignatoryId=@SignatoryId, Pile=@pile, IsCanceledProject=@isCancelledProject, 
							RAJUKNumber=@rajukNumber, ProjectTypeId=@projectTypeId, 
							LastUpdatedBy=@manipulatedBy, LastUpdatedOn = GETDATE(), UpdatedFrom=@manipulatedFrom
						WHERE ProjectID=@projectId
					END
				ELSE
					BEGIN
						INSERT INTO ProjectInfo
							(
								LocationId, InChargeId, ArchitectId, StructuralDesignerId, 
								ProjectName, ProjectName_Bangla, [Address], Address_Bangla, 
								Area, Remarks, 
								PlotTakeOverDate, AgreementSign, StartedOn, ApprovalDate, 
								ConstructionDuration, ConstructionGracePeriod, 
								SaleStartedOn, Completion, Handover, 
								LandTypeId, ProjectCode, 
								EntryAvailable, ShowInWeb, 
								GeoLocation, SignatoryId, 
								Pile, IsCanceledProject, 
								RAJUKNumber, ProjectTypeId, 
								EntryMadeBy, EntryMadeFrom
							)
							VALUES
							(
								@locationId, @inChargeId, @architectId, @structuralDesignerId, 
								@projectName, @projectName_Bangla, @address, @address_Bangla, 
								@area, @remarks, 
								@plotTakeover, @agreementSign, @startedOn, @approvalDate, 
								@constructionDuration, @constructionGracePeriod,
								@saleStartedOn, @approxCompletion, @handoverDate, 
								@landTypeId, @projectCode, 
								@entryAvailable, @showInWeb, 
								@geoLocation, @SignatoryId, 
								@pile, @isCancelledProject, 
								@rajukNumber, @projectTypeId,
								@manipulatedBy, @manipulatedFrom
							)
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
		END
END;
