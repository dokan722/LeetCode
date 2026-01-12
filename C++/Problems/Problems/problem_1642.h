#ifndef PROBLEM_1642_H
#define PROBLEM_1642_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1642 : public problem {
public:
    bool test() override;

    int furthestBuilding(std::vector<int>& heights, int bricks, int ladders);
};

#endif //PROBLEM_1642_H
