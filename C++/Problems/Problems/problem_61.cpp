#include "problem_61.h"

bool problem_61::test() {
    auto node5 = ListNode(5);
    auto node4 = ListNode(4, &node5);
    auto node3 = ListNode(3, &node4);
    auto node2 = ListNode(2, &node3);
    auto head =  ListNode(1,  &node2);

    auto k = 2;

    auto node5e = ListNode(3);
    auto node4e = ListNode(2, &node5e);
    auto node3e = ListNode(1, &node4e);
    auto node2e = ListNode(5, &node3e);
    ListNode expected =  ListNode(4,  &node2e);

    auto result = rotateRight(&head, k);

    auto it = &expected;
    while (it != nullptr && result != nullptr)
    {
        if (it->val != result->val)
            return false;
        it = it->next;
        result = result->next;
    }

    return it == nullptr && result == nullptr;
}

problem_61::ListNode * problem_61::rotateRight(ListNode *head, int k) {
    if (head == nullptr)
        return nullptr;
    if (k == 0)
        return head;
    auto tail = head;
    int n = 1;
    while (tail->next != nullptr)
    {
        tail = tail->next;
        n++;
    }
    k = k % n;
    k = n - k - 1;
    auto b = head;
    while (k > 0)
    {
        b = b->next;
        k--;
    }
    tail->next = head;
    auto nHead = b->next;
    b->next = nullptr;

    return nHead;
}
