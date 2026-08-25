#ifndef PROBLEMS_PROBLEM_1872_H
#define PROBLEMS_PROBLEM_1872_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1872 : public problem {
public:
    bool test() override;

    int stoneGameVIII(std::vector<int>& stones);
};

#endif //PROBLEMS_PROBLEM_1872_H