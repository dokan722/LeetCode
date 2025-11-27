#ifndef PROBLEM_3381_H
#define PROBLEM_3381_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3381 : public problem {
public:
    bool test() override;

    long long maxSubarraySum(std::vector<int>& nums, int k) ;
};



#endif //PROBLEM_3381_H
