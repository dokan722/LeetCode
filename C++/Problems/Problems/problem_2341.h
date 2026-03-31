#ifndef PROBLEM_2341_H
#define PROBLEM_2341_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2341 : public problem {
public:
    bool test() override;

    std::vector<int> numberOfPairs(std::vector<int>& nums);
};

#endif //PROBLEM_2341_H
