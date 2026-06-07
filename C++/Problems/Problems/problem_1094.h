#ifndef PROBLEMS_PROBLEM_1094_H
#define PROBLEMS_PROBLEM_1094_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1094 : public problem {
public:
    bool test() override;

    bool carPooling(std::vector<std::vector<int>>& trips, int capacity);
};

#endif //PROBLEMS_PROBLEM_1094_H