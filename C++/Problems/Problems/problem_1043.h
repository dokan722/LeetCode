#ifndef PROBLEMS_PROBLEM_1043_H
#define PROBLEMS_PROBLEM_1043_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1043 : public problem {
public:
    bool test() override;

    int maxSumAfterPartitioning(std::vector<int>& arr, int k);
};

#endif //PROBLEMS_PROBLEM_1043_H