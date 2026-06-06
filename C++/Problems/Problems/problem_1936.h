#ifndef PROBLEMS_PROBLEM_1936_H
#define PROBLEMS_PROBLEM_1936_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1936 : public problem {
public:
    bool test() override;

    int addRungs(std::vector<int>& rungs, int dist) ;
};

#endif //PROBLEMS_PROBLEM_1936_H