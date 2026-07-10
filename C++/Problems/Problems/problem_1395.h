#ifndef PROBLEMS_PROBLEM_1395_H
#define PROBLEMS_PROBLEM_1395_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1395 : public problem {
public:
    bool test() override;

    int numTeams(std::vector<int>& rating);
};

#endif //PROBLEMS_PROBLEM_1395_H