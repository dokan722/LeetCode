#ifndef PROBLEMS_PROBLEM_2023_H
#define PROBLEMS_PROBLEM_2023_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2023 : public problem {
public:
    bool test() override;

    int numOfPairs(std::vector<std::string>& nums, std::string target);
};

#endif //PROBLEMS_PROBLEM_2023_H