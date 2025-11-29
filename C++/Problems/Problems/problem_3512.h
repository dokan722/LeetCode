#ifndef PROBLEM_3512_H
#define PROBLEM_3512_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3512 : public problem {
public:
    bool test() override;

    int minOperations(std::vector<int>& nums, int k);
};

#endif //PROBLEM_3512_H
