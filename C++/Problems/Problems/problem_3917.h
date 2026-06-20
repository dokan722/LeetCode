#ifndef PROBLEMS_PROBLEM_3917_H
#define PROBLEMS_PROBLEM_3917_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3917 : public problem {
public:
    bool test() override;

    std::vector<int> countOppositeParity(std::vector<int>& nums);
};
#endif //PROBLEMS_PROBLEM_3917_H