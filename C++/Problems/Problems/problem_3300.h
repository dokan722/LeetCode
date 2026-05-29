#ifndef PROBLEMS_PROBLEM_3300_H
#define PROBLEMS_PROBLEM_3300_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3300 : public problem {
public:
    bool test() override;

    int minElement(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3300_H