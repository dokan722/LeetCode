import pandas as pd
import numpy as np
from .problem import Problem

class Problem178(Problem):
    def test(self) -> bool:
        scoresValues = {'id' : [1, 2, 3, 4, 5, 6], 'score': [3.50, 3.65, 4.00, 3.85, 4.00, 3.65]}
        scores = pd.DataFrame(data=scoresValues)

        expectedDic = {'score': [4.00, 4.00, 3.85, 3.65, 3.65, 3.50], 'rank' : [1, 1, 2, 3, 3, 4]}
        expected = pd.DataFrame(data=expectedDic)

        result = order_scores(scores)

        return expected.reset_index(drop=True).equals(result.reset_index(drop=True))

def order_scores(scores: pd.DataFrame) -> pd.DataFrame:
    scores['rank'] = scores['score'].rank(method='dense', ascending=False).astype(int)
    return scores.sort_values(by=['rank'], ascending=True).drop(columns=['id'])