--ms sql
SELECT (SELECT DISTINCT salary FROM Employee ORDER BY salary DESC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY) AS SecondHighestSalary

--mysql
SELECT (SELECT DISTINCT salary FROM Employee ORDER BY salary DESC LIMIT 2 OFFSET 1) AS SecondHighestSalary