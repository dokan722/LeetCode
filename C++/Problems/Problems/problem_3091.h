#ifndef PROBLEMS_PROBLEM_3091_H
#define PROBLEMS_PROBLEM_3091_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3091 : public problem {
public:
    bool test() override;

    int minOperations(int k);
};

#endif //PROBLEMS_PROBLEM_3091_H