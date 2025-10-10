#ifndef PROBLEM_974_H
#define PROBLEM_974_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_974 : public problem {
public:
    bool test() override;

    int subarraysDivByK(std::vector<int>& nums, int k);
};



#endif //PROBLEM_974_H
