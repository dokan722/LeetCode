#ifndef PROBLEM_1351_H
#define PROBLEM_1351_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1351 : public problem {
public:
    bool test() override;

    int countNegatives(std::vector<std::vector<int>>& grid);
};

#endif //PROBLEM_1351_H
