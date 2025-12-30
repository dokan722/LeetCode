#ifndef PROBLEMS_PROBLEM_840_H
#define PROBLEMS_PROBLEM_840_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_840 : public problem {
public:
    bool test() override;

    int numMagicSquaresInside(std::vector<std::vector<int>>& grid);
};

#endif //PROBLEMS_PROBLEM_840_H