#ifndef PROBLEMS_PROBLEM_3751_H
#define PROBLEMS_PROBLEM_3751_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3751 : public problem {
public:
    bool test() override;

    int totalWaviness(int num1, int num2);
};

#endif //PROBLEMS_PROBLEM_3751_H