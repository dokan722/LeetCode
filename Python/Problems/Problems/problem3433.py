import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3433(Problem):
    def test(self) -> bool:
        numberOfUsers = 2
        events = [["MESSAGE", "10", "id1 id0"], ["OFFLINE", "11", "0"], ["MESSAGE", "71", "HERE"]]

        expected = [2, 2]

        result = self.countMentions(numberOfUsers, events)

        print1DArray(result)

        return result == expected

    def countMentions(self, numberOfUsers: int, events: List[List[str]]) -> List[int]:
        online = [0] * numberOfUsers
        events.sort(key=lambda x: (int(x[1]), -ord(x[0][0])))
        result = [0] * numberOfUsers
        alls = 0
        for e in events:
            if e[0][0] == 'O':
                ts = int(e[1])
                id = int(e[2])
                online[id] = ts + 60
            else:
                if e[2][0] == 'A':
                    alls += 1
                elif (e[2][0] == 'H'):
                    ts = int(e[1])
                    for i in range(numberOfUsers):
                        if online[i] <= ts:
                            result[i] += 1
                else:
                    ids = e[2].split(' ')
                    for  id in ids:
                        result[int(id[2:])] += 1
        if alls > 0:
            for i in range(numberOfUsers):
                result[i] += alls

        return result