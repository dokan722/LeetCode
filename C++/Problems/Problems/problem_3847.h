#ifndef PROBLEMS_PROBLEM_3847_H
#define PROBLEMS_PROBLEM_3847_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3847 : public problem {
public:
    bool test() override;

    int scoreDifference(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3847_H