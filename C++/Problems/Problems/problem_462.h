#ifndef PROBLEMS_PROBLEM_462_H
#define PROBLEMS_PROBLEM_462_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_462 : public problem {
public:
    bool test() override;

    int minMoves2(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_462_H