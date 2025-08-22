import pandas as pd
import numpy as np
from .problem import Problem

class Problem177(Problem):
    def test(self) -> bool:
        employeeValues = {'id' : [1, 2, 3], 'salary': [100, 200, 300]}
        employee = pd.DataFrame(data=employeeValues)
        N = 2

        expectedDic = {'getNthHighestSalary(2)': [200]}
        expected = pd.DataFrame(data=expectedDic)

        result = nth_highest_salary(employee, N)

        return expected.reset_index(drop=True).equals(result.reset_index(drop=True))

def nth_highest_salary(employee: pd.DataFrame, N: int) -> pd.DataFrame:
    sorted = employee['salary'].drop_duplicates().sort_values(ascending=False)
    if 0 < N <= len(sorted):
        second = sorted.iloc[N - 1]
    else:
        second = float('nan')
    return pd.DataFrame({'getNthHighestSalary({0})'.format(N): [second]})