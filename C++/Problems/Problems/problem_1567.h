#ifndef PROBLEMS_PROBLEM_1567_H
#define PROBLEMS_PROBLEM_1567_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1567 : public problem {
public:
    bool test() override;

    int getMaxLen(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_1567_H