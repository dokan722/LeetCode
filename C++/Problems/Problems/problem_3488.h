#ifndef PROBLEM_3488_H
#define PROBLEM_3488_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3488 : public problem {
public:
    bool test() override;

    std::vector<int> solveQueries(std::vector<int>& nums, std::vector<int>& queries);
};

#endif //PROBLEM_3488_H
