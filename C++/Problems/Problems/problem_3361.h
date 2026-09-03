#ifndef PROBLEMS_PROBLEM_3361_H
#define PROBLEMS_PROBLEM_3361_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3361 : public problem {
public:
    bool test() override;

    long long shiftDistance(std::string s, std::string t, std::vector<int>& nextCost, std::vector<int>& previousCost);
};

#endif //PROBLEMS_PROBLEM_3361_H