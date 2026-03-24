#ifndef PROBLEM_2906_H
#define PROBLEM_2906_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2906 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> constructProductMatrix(std::vector<std::vector<int>>& grid);
};

#endif //PROBLEM_2906_H
