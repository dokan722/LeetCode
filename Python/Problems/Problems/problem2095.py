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

class Problem2095(Problem):
    def test(self) -> bool:
        head = ListNode(5, ListNode(4, ListNode(2, ListNode(1))))

        expected = ListNode(5, ListNode(4, ListNode(1)))

        result = self.deleteMiddle(head)

        while expected != None and result != None:
            if expected.val != result.val:
                return False
            expected = expected.next
            result = result.next

        return True

    def deleteMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head.next == None:
            return None
        slow = head
        fast = head.next
        while fast.next != None and fast.next.next != None:
            slow = slow.next
            fast = fast.next.next
        slow.next = slow.next.next

        return head