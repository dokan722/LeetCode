#ifndef PROBLEMS_PROBLEM_3862_H
#define PROBLEMS_PROBLEM_3862_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3862 : public problem {
public:
    bool test() override;

    int smallestBalancedIndex(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3862_H