#ifndef PROBLEM_523_H
#define PROBLEM_523_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_523 : public problem {
public:
    bool test() override;

    bool checkSubarraySum(std::vector<int>& nums, int k);
};

#endif //PROBLEM_523_H
