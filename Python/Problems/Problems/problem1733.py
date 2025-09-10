from typing import List, Set

from .problem import Problem


class Problem1733(Problem):
    def test(self) -> bool:
        n = 2
        languages = [[1], [2], [1, 2]]
        friendships = [[1, 2], [1, 3], [2, 3]]

        expected = 1

        result = self.minimumTeachings(n, languages, friendships)

        print(result)

        return expected == result

    def minimumTeachings(self, n: int, languages: List[List[int]], friendships: List[List[int]]) -> int:
        numPeople = len(languages)
        nonCommon = set()
        languagesSets = [set(languages[i]) for i in range(numPeople)]
        for friendship in friendships:
            if self.isCommonLanguage(languagesSets[friendship[0] - 1], languagesSets[friendship[1] - 1]):
                continue
            nonCommon.add(friendship[0] - 1)
            nonCommon.add(friendship[1] - 1)

        counts = [0] * n
        for non in nonCommon:
            for language in languages[non]:
                counts[language - 1] += 1

        return len(nonCommon) - max(counts)

    def isCommonLanguage(self, languagesFirst: Set[int], languagesSecond: Set[int]) -> bool:
        for lang in languagesFirst:
            if lang in languagesSecond:
                return True

        return False