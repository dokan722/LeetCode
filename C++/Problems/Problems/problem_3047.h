#ifndef PROBLEMS_PROBLEM_3047_H
#define PROBLEMS_PROBLEM_3047_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3047 : public problem {
public:
    bool test() override;

    long long largestSquareArea(std::vector<std::vector<int>>& bottomLeft, std::vector<std::vector<int>>& topRight);
};

#endif //PROBLEMS_PROBLEM_3047_H