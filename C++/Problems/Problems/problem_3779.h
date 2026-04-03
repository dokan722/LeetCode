#ifndef PROBLEM_3779_H
#define PROBLEM_3779_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3779 : public problem {
public:
    bool test() override;

    int minOperations(std::vector<int>& nums);
};

#endif //PROBLEM_3779_H
