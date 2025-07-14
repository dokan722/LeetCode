from typing import Optional


class ListNode:
    def __init__(self, val: int = 0, next: Optional["ListNode"] = None):
        self.val = val
        self.next = next

from .problem import Problem

class Problem1290(Problem):
    def test(self) -> bool:
        node1 = ListNode(1)
        node2 = ListNode(0)
        node3 = ListNode(1)
        node1.next = node2
        node2.next = node3

        expected = 5

        result = self.getDecimalValue(node1)

        print(result)

        return result == expected

    def getDecimalValue(self, head: Optional[ListNode]) -> int:
        curr = head
        result = 0
        while curr != None:
            result *= 2
            result += curr.val
            curr = curr.next

        return result

