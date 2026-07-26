#ifndef PROBLEMS_PROBLEM_1509_H
#define PROBLEMS_PROBLEM_1509_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1509 : public problem {
public:
    bool test() override;

    int minDifference(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_1509_H