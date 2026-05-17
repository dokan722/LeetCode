#ifndef PROBLEMS_PROBLEM_55_H
#define PROBLEMS_PROBLEM_55_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_55 : public problem {
public:
    bool test() override;

    bool canJump(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_55_H