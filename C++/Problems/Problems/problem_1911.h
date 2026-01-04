#ifndef PROBLEMS_PROBLEM_1911_H
#define PROBLEMS_PROBLEM_1911_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1911 : public problem {
public:
    bool test() override;

    long long maxAlternatingSum(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_1911_H