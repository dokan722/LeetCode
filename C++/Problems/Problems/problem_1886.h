#ifndef PROBLEM_1886_H
#define PROBLEM_1886_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1886 : public problem {
public:
    bool test() override;

    bool findRotation(std::vector<std::vector<int>>& mat, std::vector<std::vector<int>>& target);
};

#endif //PROBLEM_1886_H
