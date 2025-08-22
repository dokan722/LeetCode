--MS SQL
SELECT [firstName], [lastName], [city], [state] FROM [Person] LEFT JOIN [Address] ON [Person].[PersonId] = [Address].[PersonId] 

--MySQL
SELECT firstName, lastName, city, state FROM Person LEFT JOIN Address ON Person.PersonId = Address.PersonId