#ifndef PROBLEMS_PROBLEM_735_H
#define PROBLEMS_PROBLEM_735_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_735 : public problem {
public:
    bool test() override;

    std::vector<int> asteroidCollision(std::vector<int>& asteroids);
};

#endif //PROBLEMS_PROBLEM_735_H