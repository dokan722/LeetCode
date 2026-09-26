#ifndef PROBLEMS_PROBLEM_2855_H
#define PROBLEMS_PROBLEM_2855_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_2855 : public problem {
public:
    bool test() override;

    int minimumRightShifts(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_2855_H