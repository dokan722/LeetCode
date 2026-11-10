#ifndef PROBLEMS_PROBLEM_3282_H
#define PROBLEMS_PROBLEM_3282_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3282 : public problem {
public:
    bool test() override;

    long long findMaximumScore(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3282_H