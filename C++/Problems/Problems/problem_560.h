#ifndef PROBLEMS_PROBLEM_560_H
#define PROBLEMS_PROBLEM_560_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_560 : public problem {
public:
    bool test() override;

    int subarraySum(std::vector<int>& nums, int k) ;
};

#endif //PROBLEMS_PROBLEM_560_H