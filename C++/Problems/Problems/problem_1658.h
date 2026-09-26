#ifndef PROBLEMS_PROBLEM_1658_H
#define PROBLEMS_PROBLEM_1658_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1658 : public problem {
public:
    bool test() override;

    int minOperations(std::vector<int>& nums, int x);
};

#endif //PROBLEMS_PROBLEM_1658_H