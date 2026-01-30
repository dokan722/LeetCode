#ifndef PROBLEMS_PROBLEM_1004_H
#define PROBLEMS_PROBLEM_1004_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1004 : public problem {
public:
    bool test() override;

    int longestOnes(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_1004_H