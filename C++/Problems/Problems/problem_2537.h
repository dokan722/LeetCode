#ifndef PROBLEM_2537_H
#define PROBLEM_2537_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2537 : public problem {
public:
    bool test() override;

    long long countGood(std::vector<int>& nums, int k);
};

#endif //PROBLEM_2537_H
