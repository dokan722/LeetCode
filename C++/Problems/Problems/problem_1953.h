#ifndef PROBLEMS_PROBLEM_1953_H
#define PROBLEMS_PROBLEM_1953_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1953 : public problem {
public:
    bool test() override;

    long long numberOfWeeks(std::vector<int>& milestones);
};

#endif //PROBLEMS_PROBLEM_1953_H