#ifndef PROBLEM_3217_H
#define PROBLEM_3217_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3217 : public problem {
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

    ListNode* modifiedList(std::vector<int>& nums, ListNode* head);
};



#endif //PROBLEM_3217_H
