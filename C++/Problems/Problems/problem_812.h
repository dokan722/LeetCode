#ifndef PROBLEM_812_H
#define PROBLEM_812_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_812: public problem {
public:
    bool test() override;

    double largestTriangleArea(std::vector<std::vector<int>>& points);
};



#endif //PROBLEM_812_H
