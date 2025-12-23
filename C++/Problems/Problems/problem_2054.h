#ifndef PROBLEMS_PROBLEM_2054_H
#define PROBLEMS_PROBLEM_2054_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2054 : public problem {
public:
    bool test() override;

    int maxTwoEvents(std::vector<std::vector<int>>& events);
};

#endif //PROBLEMS_PROBLEM_2054_H