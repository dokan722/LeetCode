#ifndef PROBLEM_3974_H
#define PROBLEM_3974_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3974 : public problem {
public:
    bool test() override;

    long long maxSum(std::vector<int>& nums, int k, int mul);
};

#endif //PROBLEM_3974_H
