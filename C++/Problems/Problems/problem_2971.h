#ifndef PROBLEM_2971_H
#define PROBLEM_2971_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_2971 : public problem {
public:
    bool test() override;

    long long largestPerimeter(std::vector<int>& nums);
};

#endif //PROBLEM_2971_H
