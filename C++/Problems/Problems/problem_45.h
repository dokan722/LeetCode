#ifndef PROBLEMS_PROBLEM_45_H
#define PROBLEMS_PROBLEM_45_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_45 : public problem {
public:
    bool test() override;

    int jump(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_45_H