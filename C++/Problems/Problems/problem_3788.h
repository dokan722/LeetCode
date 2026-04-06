#ifndef PROBLEM_3788_H
#define PROBLEM_3788_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3788 : public problem {
public:
    bool test() override;

    long long maximumScore(std::vector<int>& nums);
};

#endif //PROBLEM_3788_H
