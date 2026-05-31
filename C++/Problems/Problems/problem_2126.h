#ifndef PROBLEMS_PROBLEM_2126_H
#define PROBLEMS_PROBLEM_2126_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2126 : public problem {
public:
    bool test() override;

    bool asteroidsDestroyed(int mass, std::vector<int>& asteroids);
};

#endif //PROBLEMS_PROBLEM_2126_H