#ifndef PROBLEMS_PROBLEM_3784_H
#define PROBLEMS_PROBLEM_3784_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3784 : public problem {
public:
    bool test() override;

    long long minCost(std::string s, std::vector<int>& cost) ;
};

#endif //PROBLEMS_PROBLEM_3784_H