#ifndef PROBLEMS_PROBLEM_319_H
#define PROBLEMS_PROBLEM_319_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_319 : public problem {
public:
    bool test() override;

    int bulbSwitch(int n);
};

#endif //PROBLEMS_PROBLEM_319_H