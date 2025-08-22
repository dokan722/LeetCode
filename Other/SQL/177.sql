--mssql
CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
IF (@N > 0)
    RETURN (
        SELECT (SELECT DISTINCT salary FROM Employee ORDER BY salary DESC OFFSET @N - 1 ROWS FETCH NEXT 1 ROWS ONLY) AS SecondHighestSalary
    )
RETURN NULL
END

--mysql

CREATE FUNCTION getNthHighestSalary(N INT) RETURNS INT
BEGIN
  DECLARE off INT;
  SET off = N - 1;
  RETURN IF(
    N > 0,
    (SELECT DISTINCT salary 
     FROM Employee 
     ORDER BY salary DESC 
     LIMIT 1 OFFSET off),
    NULL
  );
END