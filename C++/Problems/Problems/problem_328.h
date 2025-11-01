#ifndef PROBLEM_328_H
#define PROBLEM_328_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_328 : public problem {
    struct ListNode {
        int val;
        ListNode *next;
        ListNode() : val(0), next(nullptr) {}
        ListNode(int x) : val(x), next(nullptr) {}
        ListNode(int x, ListNode *next) : val(x), next(next) {}
        ~ListNode() { delete next; }
    };
public:
    bool test() override;

    ListNode* oddEvenList(ListNode* head);
};



#endif //PROBLEM_328_H
