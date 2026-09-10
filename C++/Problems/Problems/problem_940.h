#ifndef PROBLEMS_PROBLEM_940_H
#define PROBLEMS_PROBLEM_940_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_940 : public problem {
public:
    bool test() override;

    int distinctSubseqII(std::string s);
};

#endif //PROBLEMS_PROBLEM_940_H