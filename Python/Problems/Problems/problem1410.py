import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1410(Problem):
    def test(self) -> bool:
        text = "&amp; is an HTML entity but &ambassador; is not."

        expected = "& is an HTML entity but &ambassador; is not."

        result = self.entityParser(text)

        print(result)

        return result == expected

    def entityParser(self, text: str) -> str:
        encoded =  {
            "quot": "\"",
            "apos": "\'",
            "amp": "&",
            "gt": ">",
            "lt": "<",
            "frasl": "/"}
        n = len(text)
        result = ''
        i = 0
        while i < n:
            if text[i] == '&' and i != n - 1:
                start = i
                i += 1
                while i < n and text[i] != ';' and text[i] != '&':
                    i += 1
                if i == n:
                    result += text[start:]
                elif text[i] == '&':
                    result += text[start:i]
                    i -= 1
                else:
                    ins = text[start + 1:i]
                    if ins in encoded:
                        result += encoded[ins]
                    else:
                        result += text[start:i+1]
            else:
                result += text[i]
            i += 1
        return result