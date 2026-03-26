#ifndef PROBLEMS_PROBLEM_2357_H
#define PROBLEMS_PROBLEM_2357_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2357 : public problem {
public:
    bool test() override;

    int minimumOperations(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_2357_H