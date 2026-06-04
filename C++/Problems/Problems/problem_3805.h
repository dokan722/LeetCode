#ifndef PROBLEMS_PROBLEM_3805_H
#define PROBLEMS_PROBLEM_3805_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3805 : public problem {
public:
    bool test() override;

    long long countPairs(std::vector<std::string>& words);
};

#endif //PROBLEMS_PROBLEM_3805_H