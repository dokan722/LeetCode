#ifndef PROBLEM_2865_H
#define PROBLEM_2865_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2865 : public problem {
public:
    bool test() override;

    long long maximumSumOfHeights(std::vector<int>& heights);
};

#endif //PROBLEM_2865_H
