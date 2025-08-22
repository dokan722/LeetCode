import pandas as pd
import numpy as np
from .problem import Problem

class Problem175(Problem):
    def test(self) -> bool:
        personValues = {'personId': [1, 2], 'lastName': ['Wang', 'Alice'], 'firstName': ['Allen', 'Bob']}
        person = pd.DataFrame(data=personValues)
        adressValues = {'addressId' : [1, 2], 'personId': [2, 3], 'city': ['New York City', 'Leetcode'],
                        'state': ['New York', 'California']}
        adress = pd.DataFrame(data=adressValues)

        expectedDic = {'firstName': ['Allen', 'Bob'], 'lastName' : ['Wang', 'Alice'], 'city' : [np.nan, 'New York City'],
                       'state' : [np.nan, 'New York']}
        expected = pd.DataFrame(data=expectedDic)

        result = combine_two_tables(person, adress)

        return expected.reset_index(drop=True).equals(result.reset_index(drop=True))

def combine_two_tables(person: pd.DataFrame, address: pd.DataFrame) -> pd.DataFrame:
    return person.merge(address, how='left', on='personId')[['firstName', 'lastName', 'city', 'state']]