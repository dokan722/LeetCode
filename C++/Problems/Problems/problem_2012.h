#ifndef PROBLEMS_PROBLEM_2012_H
#define PROBLEMS_PROBLEM_2012_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2012 : public problem {
public:
    bool test() override;

    int sumOfBeauties(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_2012_H