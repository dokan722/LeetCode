#ifndef PROBLEMS_PROBLEM_2530_H
#define PROBLEMS_PROBLEM_2530_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2530 : public problem {
public:
    bool test() override;

    long long maxKelements(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_2530_H