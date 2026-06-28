#ifndef PROBLEMS_PROBLEM_3152_H
#define PROBLEMS_PROBLEM_3152_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3152 : public problem {
public:
    bool test() override;

    std::vector<bool> isArraySpecial(std::vector<int>& nums, std::vector<std::vector<int>>& queries);
};

#endif //PROBLEMS_PROBLEM_3152_H