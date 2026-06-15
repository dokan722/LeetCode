#include "problem_2095.h"

bool problem_2095::test() {
    auto node1 =  ListNode(1);
    auto node2 = ListNode(2, &node1);
    auto node3 = ListNode(4, &node2);
    auto head = ListNode(5, &node3);

    auto node4 =  ListNode(1);
    auto node5 = ListNode(4, &node4);
    auto head2 =  ListNode(5,  &node5);
    auto expected = &head2;

    auto result = deleteMiddle(&head);

    while (expected != nullptr && result != nullptr)
    {
        if (expected->val != result->val)
            return false;
        expected = expected->next;
        result = result->next;
    }

    return true;
}

problem_2095::ListNode * problem_2095::deleteMiddle(ListNode *head) {
    if (head->next == nullptr)
        return nullptr;
    auto slow = head;
    auto fast = head->next;
    while (fast->next != nullptr && fast->next->next != nullptr)
    {
        slow = slow->next;
        fast = fast->next->next;
    }
    slow->next = slow->next->next;

    return head;
}
