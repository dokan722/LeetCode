#ifndef PROBLEM_3453_H
#define PROBLEM_3453_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3453 : public problem {
public:
    bool test() override;

    double separateSquares(std::vector<std::vector<int>>& squares);
};

#endif //PROBLEM_3453_H
