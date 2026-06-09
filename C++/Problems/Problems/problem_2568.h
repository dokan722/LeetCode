#ifndef PROBLEM_2568_H
#define PROBLEM_2568_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2568 : public problem {
public:
    bool test() override;

    int minImpossibleOR(std::vector<int>& nums);
};

#endif //PROBLEM_2568_H
