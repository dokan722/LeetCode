#ifndef PROBLEM_1572_H
#define PROBLEM_1572_H

#include "../problem.h"
#include <vector>


class problem_1572 : public problem
{
public:
    bool test() override;

    int diagonalSum(std::vector<std::vector<int>>& mat);
};



#endif //PROBLEM_1572_H
