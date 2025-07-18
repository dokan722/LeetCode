#ifndef PROBLEM_1480_H
#define PROBLEM_1480_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1480 : public problem {
public:
    bool test() override;

    std::vector<int> runningSum(std::vector<int>& nums);
};



#endif //PROBLEM_1480_H
