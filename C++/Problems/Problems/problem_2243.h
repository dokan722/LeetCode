#ifndef PROBLEMS_PROBLEM_2243_H
#define PROBLEMS_PROBLEM_2243_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2243 : public problem {
public:
    bool test() override;

    std::string digitSum(std::string s, int k);
};

#endif //PROBLEMS_PROBLEM_2243_H