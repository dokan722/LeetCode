#ifndef PROBLEM_1921_H
#define PROBLEM_1921_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1921 : public problem {
public:
    bool test() override;

    int eliminateMaximum(std::vector<int>& dist, std::vector<int>& speed);
};

#endif //PROBLEM_1921_H
