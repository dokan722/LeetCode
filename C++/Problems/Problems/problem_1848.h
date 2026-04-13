#ifndef PROBLEMS_PROBLEM_1848_H
#define PROBLEMS_PROBLEM_1848_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1848 : public problem {
public:
    bool test() override;

    int getMinDistance(std::vector<int>& nums, int target, int start);
};

#endif //PROBLEMS_PROBLEM_1848_H