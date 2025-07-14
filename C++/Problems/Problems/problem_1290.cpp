#include "problem_1290.h"

bool problem_1290::test() {
    auto node1 = ListNode_1290(1);
    auto node2 = ListNode_1290(0);
    auto node3 = ListNode_1290(1);
    node1.next = &node2;
    node2.next = &node3;

    auto expected = 5;

    auto result = getDecimalValue(&node1);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1290::getDecimalValue(ListNode_1290 *head) {
    auto curr = head;
    auto result = 0;
    while (curr != nullptr)
    {
        result *= 2;
        result += curr->val;
        curr = curr->next;
    }

    return result;
}
