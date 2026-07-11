#ifndef PROBLEMS_PROBLEM_1481_H
#define PROBLEMS_PROBLEM_1481_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1481 : public problem {
public:
    bool test() override;

    int findLeastNumOfUniqueInts(std::vector<int>& arr, int k);
};

#endif //PROBLEMS_PROBLEM_1481_H