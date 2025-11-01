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

class Problem328(Problem):
    def test(self) -> bool:
        head = ListNode(1, ListNode(2, ListNode(3, ListNode(4, ListNode(5)))))

        expected = ListNode(1, ListNode(3, ListNode(5, ListNode(2, ListNode(4)))))

        result = self.oddEvenList(head)

        while result != None and expected != None:
            if result.val != expected.val:
                return False
            result = result.next
            expected = expected.next

        return result == expected

    def oddEvenList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        even = ListNode()
        odd = ListNode()
        currEven = even
        currOdd = odd
        curr = head
        cnt = 1
        while curr != None:
            if cnt % 2 == 0:
                currEven.next = curr
                currEven = currEven.next
            else:
                currOdd.next = curr
                currOdd = currOdd.next
            curr = curr.next
            cnt += 1

        currEven.next = None
        currOdd.next = even.next

        return odd.next