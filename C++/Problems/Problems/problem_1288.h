#ifndef PROBLEMS_PROBLEM_1288_H
#define PROBLEMS_PROBLEM_1288_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1288 : public problem {
public:
    bool test() override;

    int removeCoveredIntervals(std::vector<std::vector<int>>& intervals);
};

#endif //PROBLEMS_PROBLEM_1288_H