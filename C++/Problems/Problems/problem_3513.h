#ifndef PROBLEMS_PROBLEM3513_H
#define PROBLEMS_PROBLEM3513_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_3513 : public problem {
public:
    bool test() override;

    int uniqueXorTriplets(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM3513_H