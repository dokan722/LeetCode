import pandas as pd
from typing import List, Dict

from .problem import Problem

class Problem584(Problem):
    def test(self) -> bool:
        customerValues = { 'id': [1, 2, 3, 4, 5, 6], 'name': ['Will', 'Jane', 'Alex', 'Bill', 'Zack', 'Mark'],
                           'referee_id': [None, None, 2, None, 1, 2]}
        customer = pd.DataFrame(data=customerValues)

        expectedDic = { 'name': ['Will', 'Jane', 'Bill', 'Zack']}
        expected = pd.DataFrame(data=expectedDic)

        result = find_customer_referee(customer)

        return expected.equals(result)

def find_customer_referee(customer: pd.DataFrame) -> pd.DataFrame:
    return customer.loc[(customer['referee_id'] != 2) | (customer['referee_id'].isna()), ['name']]