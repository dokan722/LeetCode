#ifndef PROBLEM_1053_H
#define PROBLEM_1053_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1053 : public problem {
public:
    bool test() override;

    std::vector<int> prevPermOpt1(std::vector<int>& arr);
};

#endif //PROBLEM_1053_H
