#ifndef PROBLEMS_PROBLEM_1861_H
#define PROBLEMS_PROBLEM_1861_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1861 : public problem {
public:
    bool test() override;

    std::vector<std::vector<char>> rotateTheBox(std::vector<std::vector<char>>& boxGrid);
};

#endif //PROBLEMS_PROBLEM_1861_H