#ifndef PROBLEMS_PROBLEM_3531_H
#define PROBLEMS_PROBLEM_3531_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_3531 : public problem {
public:
    bool test() override;

    int countCoveredBuildings(int n, std::vector<std::vector<int>>& buildings);
};

#endif //PROBLEMS_PROBLEM_3531_H