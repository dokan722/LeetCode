#ifndef PROBLEM_3418_H
#define PROBLEM_3418_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3418 : public problem {
public:
    bool test() override;

    int maximumAmount(std::vector<std::vector<int>>& coins);
};

#endif //PROBLEM_3418_H
