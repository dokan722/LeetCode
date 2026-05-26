#ifndef PROBLEM_539_H
#define PROBLEM_539_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_539 : public problem {
public:
    bool test() override;

    int findMinDifference(std::vector<std::string>& timePoints);
};

#endif //PROBLEM_539_H
