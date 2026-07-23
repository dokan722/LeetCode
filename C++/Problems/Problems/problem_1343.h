#ifndef PROBLEMS_PROBLEM_1343_H
#define PROBLEMS_PROBLEM_1343_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1343 : public problem {
public:
    bool test() override;

    int numOfSubarrays(std::vector<int>& arr, int k, int threshold);
};

#endif //PROBLEMS_PROBLEM_1343_H