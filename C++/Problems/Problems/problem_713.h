#ifndef PROBLEMS_PROBLEM_713_H
#define PROBLEMS_PROBLEM_713_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_713 : public problem {
public:
    bool test() override;

    int numSubarrayProductLessThanK(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_713_H