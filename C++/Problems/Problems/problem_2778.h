#ifndef PROBLEMS_PROBLEM_2778_H
#define PROBLEMS_PROBLEM_2778_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2778 : public problem {
public:
    bool test() override;

    int sumOfSquares(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_2778_H