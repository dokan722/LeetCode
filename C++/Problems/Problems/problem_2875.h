#ifndef PROBLEMS_PROBLEM_2875_H
#define PROBLEMS_PROBLEM_2875_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2875 : public problem {
public:
    bool test() override;

    int minSizeSubarray(std::vector<int>& nums, int target);
};

#endif //PROBLEMS_PROBLEM_2875_H