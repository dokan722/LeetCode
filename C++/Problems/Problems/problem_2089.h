#ifndef PROBLEMS_PROBLEM_2089_H
#define PROBLEMS_PROBLEM_2089_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2089 : public problem {
public:
    bool test() override;

    std::vector<int> targetIndices(std::vector<int>& nums, int target);
};

#endif //PROBLEMS_PROBLEM_2089_H