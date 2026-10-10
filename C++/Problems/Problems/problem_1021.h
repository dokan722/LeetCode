#ifndef PROBLEMS_PROBLEM_1021_H
#define PROBLEMS_PROBLEM_1021_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1021 : public problem {
public:
    bool test() override;

    std::string removeOuterParentheses(std::string s);
};


#endif //PROBLEMS_PROBLEM_1021_H