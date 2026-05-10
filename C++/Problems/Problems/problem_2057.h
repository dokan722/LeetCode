#ifndef PROBLEM_2057_H
#define PROBLEM_2057_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2057 : public problem {
public:
    bool test() override;

    int smallestEqual(std::vector<int>& nums) ;
};

#endif //PROBLEM_2057_H
