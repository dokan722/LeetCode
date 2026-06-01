#ifndef PROBLEMS_PROBLEM_2144_H
#define PROBLEMS_PROBLEM_2144_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2144 : public problem {
public:
    bool test() override;

    int minimumCost(std::vector<int>& cost);
};

#endif //PROBLEMS_PROBLEM_2144_H