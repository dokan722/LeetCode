#ifndef PROBLEMS_PROBLEM_3732_H
#define PROBLEMS_PROBLEM_3732_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3732 : public problem {
public:
    bool test() override;

    long long maxProduct(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3732_H