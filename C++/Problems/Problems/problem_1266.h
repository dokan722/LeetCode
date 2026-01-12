#ifndef PROBLEM_1266_H
#define PROBLEM_1266_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1266 : public problem {
public:
    bool test() override;

    int minTimeToVisitAllPoints(std::vector<std::vector<int>>& points);
};

#endif //PROBLEM_1266_H
