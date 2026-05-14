#ifndef PROBLEMS_PROBLEM_2784_H
#define PROBLEMS_PROBLEM_2784_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2784 : public problem {
public:
    bool test() override;

    bool isGood(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_2784_H