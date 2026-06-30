#ifndef PROBLEM_3976_H
#define PROBLEM_3976_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_3976 : public problem {
public:
    bool test() override;

    long long maxSubarraySum(std::vector<int>& nums, int k);
};

#endif //PROBLEM_3976_H
