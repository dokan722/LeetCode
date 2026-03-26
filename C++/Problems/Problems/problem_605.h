#ifndef PROBLEMS_PROBLEM_605_H
#define PROBLEMS_PROBLEM_605_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_605 : public problem {
public:
    bool test() override;

    bool canPlaceFlowers(std::vector<int>& flowerbed, int n);
};

#endif //PROBLEMS_PROBLEM_605_H