#ifndef PROBLEMS_PROBLEM_3875_H
#define PROBLEMS_PROBLEM_3875_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3875 : public problem {
public:
    bool test() override;

    bool uniformArray(std::vector<int>& nums1);
};

#endif //PROBLEMS_PROBLEM_3875_H