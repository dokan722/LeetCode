#ifndef PROBLEMS_PROBLEM_1798_H
#define PROBLEMS_PROBLEM_1798_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1798 : public problem {
public:
    bool test() override;

    int getMaximumConsecutive(std::vector<int>& coins);
};

#endif //PROBLEMS_PROBLEM_1798_H