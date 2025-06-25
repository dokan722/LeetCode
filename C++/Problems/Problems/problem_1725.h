#ifndef PROBLEM_1725_H
#define PROBLEM_1725_H

#include "../problem.h"
#include <vector>

class problem_1725 : public problem {
public:
    bool test() override;

    int countGoodRectangles(std::vector<std::vector<int>>& rectangles);
};



#endif //PROBLEM_1725_H
