#ifndef PROBLEMS_PROBLEM_2365_H
#define PROBLEMS_PROBLEM_2365_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2365 : public problem {
public:
    bool test() override;

    long long taskSchedulerII(std::vector<int>& tasks, int space);
};

#endif //PROBLEMS_PROBLEM_2365_H