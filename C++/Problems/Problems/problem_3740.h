#ifndef PROBLEMS_PROBLEM_3740_H
#define PROBLEMS_PROBLEM_3740_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3740 : public problem {
public:
    bool test() override;

    int minimumDistance(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3740_H