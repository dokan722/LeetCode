#ifndef PROBLEMS_PROBLEM_2001_H
#define PROBLEMS_PROBLEM_2001_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2001 : public problem {
public:
    bool test() override;

    long long interchangeableRectangles(std::vector<std::vector<int>>& rectangles);
};

#endif //PROBLEMS_PROBLEM_2001_H