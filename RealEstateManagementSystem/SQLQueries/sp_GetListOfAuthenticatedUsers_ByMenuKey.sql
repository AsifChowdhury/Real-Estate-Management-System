ALTER PROC sp_GetListOfAuthenticatedUsers_ByMenuKey
	@applicationId int, @menuKey varchar(50)
AS
SELECT dbo.Employee.EmpId, 
       ISNULL((SELECT isAllowed FROM dbo.ApplicationMenuPermissionDetails 
			WHERE (EmpId = dbo.Employee.EmpId) AND 
				  (MenuKey = @menuKey) AND 
				  (ApplicationId = @applicationId)), 0) AS IsAllowed, 
		dbo.EmployeeDetails.CompanyId, dbo.EmployeeDetails.Name, 
		dbo.EmployeeDetails.CurrentPosition
FROM    dbo.Employee INNER JOIN
		dbo.EmployeeDetails ON dbo.Employee.PFNumber = dbo.EmployeeDetails.CompanyId
WHERE   (dbo.Employee.EmpId IN
			(SELECT EmpId FROM dbo.ApplicationPermission
				WHERE (isAllowed = 1) AND (ApplicationId = @applicationId))) AND (dbo.EmployeeDetails.IsActive = 1)
ORDER BY dbo.Employee.EmpId