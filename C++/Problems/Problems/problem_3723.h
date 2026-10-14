#ifndef PROBLEMS_PROBLEM_3723_H
#define PROBLEMS_PROBLEM_3723_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3723 : public problem {
public:
    bool test() override;

    std::string maxSumOfSquares(int num, int sum);
};

#endif //PROBLEMS_PROBLEM_3723_H