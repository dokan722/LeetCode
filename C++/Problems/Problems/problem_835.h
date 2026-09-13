#ifndef PROBLEMS_PROBLEM_835_H
#define PROBLEMS_PROBLEM_835_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_835 : public problem {
public:
    bool test() override;

    int largestOverlap(std::vector<std::vector<int>>& img1, std::vector<std::vector<int>>& img2) ;
};

#endif //PROBLEMS_PROBLEM_835_H