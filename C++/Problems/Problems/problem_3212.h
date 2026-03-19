#ifndef PROBLEM_3212_H
#define PROBLEM_3212_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3212 : public problem {
public:
    bool test() override;

    int numberOfSubmatrices(std::vector<std::vector<char>>& grid);
};

#endif //PROBLEM_3212_H
