SELECT TOP (1000) [AdminId]
      ,[EmailId]
      ,[Password]
  FROM [dbo].[AdminInfo]

  SELECT TOP (1000) [BlogInfoId]
      ,[Title]
      ,[Subject]
      ,[DateofCreation]
      ,[BlogUrl]
      ,[EmpEmailId]
  FROM [dbo].[BlogInfo]

  SELECT TOP (1000) [EmpInfoId]
      ,[EmailId]
      ,[Name]
      ,[DateofJoining]
      ,[Passcode]
  FROM [dbo].[EmpInfo]



