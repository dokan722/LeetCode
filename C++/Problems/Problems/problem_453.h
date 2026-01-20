#ifndef PROBLEM_453_H
#define PROBLEM_453_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_453 : public problem {
public:
    bool test() override;

    int minMoves(std::vector<int>& nums);
};

#endif //PROBLEM_453_H
