#ifndef PROBLEMS_PROBLEM_3427_H
#define PROBLEMS_PROBLEM_3427_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3427 : public problem {
public:
    bool test() override;

    int subarraySum(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3427_H