#ifndef PROBLEM_918_H
#define PROBLEM_918_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_918 : public problem {
public:
    bool test() override;

    int maxSubarraySumCircular(std::vector<int>& nums);
};



#endif //PROBLEM_918_H
