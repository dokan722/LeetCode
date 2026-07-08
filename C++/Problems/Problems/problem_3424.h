#ifndef PROBLEM_3424_H
#define PROBLEM_3424_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3424 : public problem {
public:
    bool test() override;

    long long minCost(std::vector<int>& arr, std::vector<int>& brr, long long k);
};

#endif //PROBLEM_3424_H
