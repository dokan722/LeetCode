#ifndef PROBLEMS_PROBLEM_624_H
#define PROBLEMS_PROBLEM_624_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_624 : public problem {
public:
    bool test() override;

    int maxDistance(std::vector<std::vector<int>>& arrays);
};

#endif //PROBLEMS_PROBLEM_624_H