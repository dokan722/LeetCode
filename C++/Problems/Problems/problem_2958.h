#ifndef PROBLEM_2958_H
#define PROBLEM_2958_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2958 : public problem {
public:
    bool test() override;

    int maxSubarrayLength(std::vector<int>& nums, int k);
};



#endif //PROBLEM_2958_H
