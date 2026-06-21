#ifndef PROBLEMS_PROBLEM_172_H
#define PROBLEMS_PROBLEM_172_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_172 : public problem {
public:
    bool test() override;

    int trailingZeroes(int n);
};

#endif //PROBLEMS_PROBLEM_172_H