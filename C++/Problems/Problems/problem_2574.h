#ifndef PROBLEM_2574_H
#define PROBLEM_2574_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2574 : public problem {
public:
    bool test() override;

    std::vector<int> leftRightDifference(std::vector<int>& nums);
};

#endif //PROBLEM_2574_H
