#ifndef PROBLEM_3432_H
#define PROBLEM_3432_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3432 : public problem {
public:
    bool test() override;

    int countPartitions(std::vector<int>& nums) ;
};

#endif //PROBLEM_3432_H
