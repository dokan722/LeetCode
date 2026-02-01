#ifndef PROBLEMS_PROBLEM_3010_H
#define PROBLEMS_PROBLEM_3010_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3010 : public problem {
public:
    bool test() override;

    int minimumCost(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3010_H