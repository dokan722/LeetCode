#ifndef PROBLEMS_PROBLEM_3871_H
#define PROBLEMS_PROBLEM_3871_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3871 : public problem {
public:
    bool test() override;

    long long countCommas(long long n);
};

#endif //PROBLEMS_PROBLEM_3871_H