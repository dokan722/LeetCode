#ifndef PROBLEM_1590_H
#define PROBLEM_1590_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1590 : public problem {
public:
    bool test() override;

    int minSubarray(std::vector<int>& nums, int p);
};



#endif //PROBLEM_1590_H
