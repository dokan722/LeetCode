#ifndef PROBLEMS_PROBLEM_3895_H
#define PROBLEMS_PROBLEM_3895_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3895 : public problem {
public:
    bool test() override;

    int countDigitOccurrences(std::vector<int>& nums, int digit);
};

#endif //PROBLEMS_PROBLEM_3895_H