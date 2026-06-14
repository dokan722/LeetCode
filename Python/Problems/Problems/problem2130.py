import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Problem2130(Problem):
    def test(self) -> bool:
        head = ListNode(5, ListNode(4, ListNode(2, ListNode(1))))

        expected = 6

        result = self.pairSum(head)

        print(result)

        return result == expected

    def pairSum(self, head: Optional[ListNode]) -> int:
        slow = head
        fast = head.next
        stack = []
        while fast != None:
            stack.append(slow.val)
            slow = slow.next
            fast = fast.next
            if fast:
                fast = fast.next
        result = 0
        while slow != None:
            result = max(result, stack.pop() + slow.val)
            slow = slow.next

        return result