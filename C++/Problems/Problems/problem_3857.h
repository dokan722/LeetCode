#ifndef PROBLEMS_PROBLEM_3857_H
#define PROBLEMS_PROBLEM_3857_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3857 : public problem {
public:
    bool test() override;

    int minCost(int n);
};

#endif //PROBLEMS_PROBLEM_3857_H