#ifndef PROBLEMS_PROBLEM_822_H
#define PROBLEMS_PROBLEM_822_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_822 : public problem {
public:
    bool test() override;

    int flipgame(std::vector<int>& fronts, std::vector<int>& backs);
};

#endif //PROBLEMS_PROBLEM_822_H