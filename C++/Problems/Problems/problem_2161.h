#ifndef PROBLEMS_PROBLEM_2161_H
#define PROBLEMS_PROBLEM_2161_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2161 : public problem {
public:
    bool test() override;

    std::vector<int> pivotArray(std::vector<int>& nums, int pivot) ;
};
#endif //PROBLEMS_PROBLEM_2161_H