import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Problem3217(Problem):
    def test(self) -> bool:
        head = ListNode(1, ListNode(2, ListNode(3, ListNode(4, ListNode(5)))))
        nums = [1, 2, 3]

        expected = ListNode(4, ListNode(5))

        result = self.modifiedList(nums, head)

        while result != None and expected != None:
            if result.val != expected.val:
                return False
            result = result.next
            expected = expected.next

        return result == expected

    def modifiedList(self, nums: List[int], head: Optional[ListNode]) -> Optional[ListNode]:
        numsSet = set(nums)
        guard = ListNode(0, head)
        prev = guard
        curr = head
        while curr != None:
            if curr.val in numsSet:
                prev.next = curr.next
            else:
                prev = curr
            curr = curr.next

        return guard.next