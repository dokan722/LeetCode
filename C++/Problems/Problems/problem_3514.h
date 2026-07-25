#ifndef PROBLEMS_PROBLEM_3514_H
#define PROBLEMS_PROBLEM_3514_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3514 : public problem {
public:
    bool test() override;

    int uniqueXorTriplets(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3514_H