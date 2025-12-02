#ifndef PROBLEM_2279_H
#define PROBLEM_2279_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2279 : public problem {
public:
    bool test() override;

    int maximumBags(std::vector<int>& capacity, std::vector<int>& rocks, int additionalRocks);
};

#endif //PROBLEM_2279_H
