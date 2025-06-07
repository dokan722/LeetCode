#ifndef PROBLEM_1_H
#define PROBLEM_1_H

#include "../problem.h"

#include <vector>

class problem_1 : public problem
{
public:
    bool test() override;

    std::vector<int> twoSum(std::vector<int>& nums, int target);
};

#endif
