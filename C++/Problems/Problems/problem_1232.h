#ifndef PROBLEMS_PROBLEM_1232_H
#define PROBLEMS_PROBLEM_1232_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1232 : public problem {
public:
    bool test() override;

    bool checkStraightLine(std::vector<std::vector<int>>& coordinates);
};


#endif //PROBLEMS_PROBLEM_1232_H