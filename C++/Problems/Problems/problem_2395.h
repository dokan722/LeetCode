#ifndef PROBLEMS_PROBLEM_2395_H
#define PROBLEMS_PROBLEM_2395_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2395 : public problem {
public:
    bool test() override;

    bool findSubarrays(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_2395_H