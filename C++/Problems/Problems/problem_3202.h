#ifndef PROBLEM_3202_H
#define PROBLEM_3202_H

#include "../problem.h"
#include <vector>

class problem_3202 : public problem {
public:
    bool test() override;

    int maximumLength(std::vector<int>& nums, int k);
};



#endif //PROBLEM_3202_H
