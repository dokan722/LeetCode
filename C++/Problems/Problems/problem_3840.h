#ifndef PROBLEMS_PROBLEM_3840_H
#define PROBLEMS_PROBLEM_3840_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3840 : public problem {
public:
    bool test() override;

    long long rob(std::vector<int>& nums, std::vector<int>& colors) ;
};
#endif //PROBLEMS_PROBLEM_3840_H