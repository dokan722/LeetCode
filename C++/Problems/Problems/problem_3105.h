#ifndef PROBLEMS_PROBLEM_3105_H
#define PROBLEMS_PROBLEM_3105_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3105 : public problem {
public:
    bool test() override;

    int longestMonotonicSubarray(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3105_H