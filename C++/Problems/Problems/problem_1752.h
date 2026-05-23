#ifndef PROBLEMS_PROBLEM_1752_H
#define PROBLEMS_PROBLEM_1752_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1752 : public problem {
public:
    bool test() override;

    bool check(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_1752_H