#ifndef PROBLEMS_PROBLEM_1011_H
#define PROBLEMS_PROBLEM_1011_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1011 : public problem {
public:
    bool test() override;

    int shipWithinDays(std::vector<int>& weights, int days);
};

#endif //PROBLEMS_PROBLEM_1011_H