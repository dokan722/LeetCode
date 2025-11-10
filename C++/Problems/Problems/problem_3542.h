#ifndef PROBLEM_3542_H
#define PROBLEM_3542_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3542 : public problem {
public:
    bool test() override;

    int minOperations(std::vector<int>& nums);
};





#endif //PROBLEM_3542_H
