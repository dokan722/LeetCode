#ifndef PROBLEMS_PROBLEM_2233_H
#define PROBLEMS_PROBLEM_2233_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2233 : public problem {
public:
    bool test() override;

    int maximumProduct(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_2233_H