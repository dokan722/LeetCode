#ifndef PROBLEMS_PROBLEM_856_H
#define PROBLEMS_PROBLEM_856_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_856 : public problem {
public:
    bool test() override;

    int scoreOfParentheses(std::string s);
};

#endif //PROBLEMS_PROBLEM_856_H