#ifndef PROBLEM_2099_H
#define PROBLEM_2099_H



#include "../problem.h"
#include <vector>

class problem_2099 : public problem {
public:
    bool test() override;

    std::vector<int> maxSubsequence(std::vector<int>& nums, int k);
};



#endif //PROBLEM_2099_H
