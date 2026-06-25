#ifndef PROBLEMS_PROBLEM_3942_H
#define PROBLEMS_PROBLEM_3942_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3942 : public problem {
public:
    bool test() override;

    int minOperations(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3942_H