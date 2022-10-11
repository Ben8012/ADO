USE ADO

-- DELETE Student WHERE Id = 1; -- test tirgger

-- EXEC dbo.AddStudent 'Benjamin','Sterckx','1929-12-10',20, 'Secr?tariat' -- test check birtdate >= 1930
-- EXEC dbo.AddStudent 'Benjamin','Sterckx','1980-12-10',21, 'Secr?tariat' -- test check yearresult between 0 and 20
-- EXEC dbo.AddStudent 'Benjamin','Sterckx','1980-12-10',20, 'Secr?tariat' 

-- EXEC dbo.DeleteStudent 26 -- test procedure delete passe par le trigger

-- EXEC dbo.UpdateStudent 26,19,1120 -- test procedure updateStudent

-- EXEC dbo.AddSection 200,'Ma section test' -- test procedure AddSection

-- Select * From V_Student -- test vue
