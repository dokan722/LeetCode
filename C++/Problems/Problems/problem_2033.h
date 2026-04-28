#ifndef PROBLEM_2033_H
#define PROBLEM_2033_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2033 : public problem {
public:
    bool test() override;

    int minOperations(std::vector<std::vector<int>>& grid, int x);
};

#endif //PROBLEM_2033_H
