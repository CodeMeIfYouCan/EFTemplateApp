SELECT [Id]
  FROM dbo.Customers(nolock)
where ExternalClientNo = {0} and
  Id = {1} 
