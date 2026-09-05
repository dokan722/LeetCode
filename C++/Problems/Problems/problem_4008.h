#ifndef PROBLEMS_PROBLEM_4008_H
#define PROBLEMS_PROBLEM_4008_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_4008 : public problem {
public:
    bool test() override;

    long long minInitialStrength(std::vector<int>& monsters, std::vector<std::vector<int>>& boosts);
};
#endif //PROBLEMS_PROBLEM_4008_H