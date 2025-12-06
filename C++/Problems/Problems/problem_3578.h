#ifndef PROBLEMS_PROBLEM_3578_H
#define PROBLEMS_PROBLEM_3578_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_3578 : public problem {
public:
    bool test() override;

    int countPartitions(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3578_H