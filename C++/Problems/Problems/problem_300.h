#ifndef PROBLEMS_PROBLEM_300_H
#define PROBLEMS_PROBLEM_300_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_300 : public problem {
public:
    bool test() override;

    int lengthOfLIS(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_300_H