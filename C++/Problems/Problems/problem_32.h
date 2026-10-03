#ifndef PROBLEMS_PROBLEM_32_H
#define PROBLEMS_PROBLEM_32_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_32 : public problem {
public:
    bool test() override;

    int longestValidParentheses(std::string s);
};

#endif //PROBLEMS_PROBLEM_32_H