#include "problem_2130.h"


bool problem_2130::test() {
    auto node1 =  ListNode(1);
    auto node2 = ListNode(2, &node1);
    auto node3 = ListNode(4, &node2);
    auto head = ListNode(5, &node3);

    int expected = 6;

    auto result = pairSum(&head);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2130::pairSum(ListNode *head) {
    auto slow = head;
    auto fast = head->next;
    std::stack<int> stack;
    while (fast != nullptr)
    {
        stack.push(slow->val);
        slow = slow->next;
        fast = fast->next;
        if (fast)
            fast = fast->next;
    }
    int result = 0;
    while (slow != nullptr)
    {
        result = std::max(result, stack.top() + slow->val);
        stack.pop();
        slow = slow->next;
    }

    return result;
}
