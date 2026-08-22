#ifndef PROBLEMS_PROBLEM_3622_H
#define PROBLEMS_PROBLEM_3622_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3622 : public problem {
public:
    bool test() override;

    bool checkDivisibility(int n);
};

#endif //PROBLEMS_PROBLEM_3622_H