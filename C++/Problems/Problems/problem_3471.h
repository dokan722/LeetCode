#ifndef PROBLEMS_PROBLEM_3471_H
#define PROBLEMS_PROBLEM_3471_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3471 : public problem {
public:
    bool test() override;

    int largestInteger(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3471_H