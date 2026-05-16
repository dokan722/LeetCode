#ifndef PROBLEMS_PROBLEM_565_H
#define PROBLEMS_PROBLEM_565_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_565 : public problem {
public:
    bool test() override;

    int arrayNesting(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_565_H