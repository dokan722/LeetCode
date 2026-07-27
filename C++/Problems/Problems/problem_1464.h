#ifndef PROBLEMS_PROBLEM_1464_H
#define PROBLEMS_PROBLEM_1464_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1464 : public problem {
public:
    bool test() override;

    int maxProduct(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_1464_H