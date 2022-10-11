---- Execute reader fonctionne de la meme maniere 
--DECLARE @id INT, 
--@LastName NVARCHAR(50),
--@FirstName NVARCHAR(50)


--DECLARE CR_Student CURSOR FOR 
--SELECT id, LastName, FirstName
--FROM Student

--OPEN CR_Student;

--FETCH CR_Student INTO @Id, @LastName, @FirstName;

--WHILE(@@FETCH_STATUS = 0)
-- BEGIN
--	PRINT @LastName;
--	FETCH CR_Student INTO @Id, @LastName, @FirstName;

-- END

-- CLOSE CR_Student;
-- DEALLOCATE CR_Student;