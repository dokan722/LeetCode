#ifndef PROBLEMS_PROBLEM_1539_H
#define PROBLEMS_PROBLEM_1539_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1539 : public problem {
public:
    bool test() override;

    int findKthPositive(std::vector<int>& arr, int k);
};

#endif //PROBLEMS_PROBLEM_1539_H