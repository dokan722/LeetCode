#ifndef PROBLEM_2463_H
#define PROBLEM_2463_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2463 : public problem {
public:
    bool test() override;

    long long minimumTotalDistance(std::vector<int>& robot, std::vector<std::vector<int>>& factory);
};

#endif //PROBLEM_2463_H
