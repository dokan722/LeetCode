#ifndef PROBLEM_3650_H
#define PROBLEM_3650_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3650 : public problem {
public:
    bool test() override;

    int minCost(int n, std::vector<std::vector<int>>& edges);
};

#endif //PROBLEM_3650_H
