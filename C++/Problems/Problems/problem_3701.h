#ifndef PROBLEMS_PROBLEM_3701_H
#define PROBLEMS_PROBLEM_3701_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3701 : public problem {
public:
    bool test() override;

    int alternatingSum(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3701_H