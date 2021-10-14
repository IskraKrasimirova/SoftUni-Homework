--Select all of the planes, which name contains "tr". 
--Order them by id (ascending), name (ascending), seats (ascending) and range (ascending).

SELECT * FROM Planes
WHERE [Name] LIKE '%tr%'
ORDER BY Id,[Name],Seats,[Range]