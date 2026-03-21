#ifndef PROBLEM_3643_H
#define PROBLEM_3643_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3643 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> reverseSubmatrix(std::vector<std::vector<int>>& grid, int x, int y, int k) ;
};

#endif //PROBLEM_3643_H
