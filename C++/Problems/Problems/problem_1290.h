#ifndef PROBLEM_1290_H
#define PROBLEM_1290_H

#include "../problem.h"
#include <vector>


struct ListNode_1290 {
    int val;
    ListNode_1290 *next;
    ListNode_1290() : val(0), next(nullptr) {}
    ListNode_1290(int x) : val(x), next(nullptr) {}
    ListNode_1290(int x, ListNode_1290 *next) : val(x), next(next) {}
};


class problem_1290 : public problem {
public:
    bool test() override;

    int getDecimalValue(ListNode_1290* head);
};



#endif //PROBLEM_1290_H
