import pandas as pd

from .problem import Problem

class Problem620(Problem):
    def test(self) -> bool:
        customerValues = {'id': [1, 2, 3, 4, 5], 'movie': ['War', 'Science', 'irish', 'Ice song', 'House card'],
                          'description': ['great 3D', 'fiction', 'boring', 'Fantacy', 'Interesting'],
                          'rating' : [8.9, 8.5, 6.2, 8.6, 9.1]}
        customer = pd.DataFrame(data=customerValues)

        expectedDic = {'id': [5, 1], 'movie' : ['House card', 'War'], 'description' : ['Interesting', 'great 3D'],
                       'rating' : [9.1, 8.9]}
        expected = pd.DataFrame(data=expectedDic)

        result = not_boring_movies(customer)

        return expected.reset_index(drop=True).equals(result.reset_index(drop=True))


def not_boring_movies(cinema: pd.DataFrame) -> pd.DataFrame:
    filtered = cinema[
        (cinema['id'] % 2 == 1) &
        (cinema['description'] != 'boring')
    ]
    result = filtered.sort_values(by='rating', ascending=False)
    return result