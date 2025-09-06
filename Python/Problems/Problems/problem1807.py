from typing import List

from .problem import Problem


class Problem1807(Problem):
    def test(self) -> bool:
        s = "(name)is(age)yearsold"
        knowledge = [["name", "bob"], ["age", "two"]]

        expected = "bobistwoyearsold"

        result = self.evaluate(s, knowledge)

        print(result)

        return expected == result

    def evaluate(self, s: str, knowledge: List[List[str]]) -> str:
        wordsDic = { x[0]: x[1] for x in knowledge }
        result = []
        i = 0
        while i < len(s):
            if s[i] == '(':
                start = i + 1
                end = start + 1
                while s[end] != ')':
                    end += 1
                key = s[start:end]
                if key in wordsDic:
                    result.append(wordsDic[key])
                else:
                    result.append('?')
                i = end

            else:
                result.append(s[i])
            i += 1

        return ''.join(result)