#ifndef PROBLEMS_PROBLEM_2841_H
#define PROBLEMS_PROBLEM_2841_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2841 : public problem {
public:
    bool test() override;

    long long maxSum(std::vector<int>& nums, int m, int k);
};

#endif //PROBLEMS_PROBLEM_2841_H