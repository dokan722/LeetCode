import pandas as pd
import numpy as np
from .problem import Problem

class Problem176(Problem):
    def test(self) -> bool:
        employeeValues = {'id' : [1, 2, 3], 'salary': [100, 200, 300]}
        employee = pd.DataFrame(data=employeeValues)

        expectedDic = {'SecondHighestSalary': [200]}
        expected = pd.DataFrame(data=expectedDic)

        result = second_highest_salary(employee)

        return expected.reset_index(drop=True).equals(result.reset_index(drop=True))

def second_highest_salary(employee: pd.DataFrame) -> pd.DataFrame:
    sorted = employee['salary'].drop_duplicates().sort_values(ascending=False)
    if len(sorted) >= 2:
        second = sorted.iloc[1]
    else:
        second = float('nan')
    return pd.DataFrame({'SecondHighestSalary': [second]})