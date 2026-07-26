#ifndef PROBLEMS_PROBLEM_628_H
#define PROBLEMS_PROBLEM_628_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_628 : public problem {
public:
    bool test() override;

    int maximumProduct(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_628_H