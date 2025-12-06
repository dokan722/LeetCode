#ifndef PROBLEMS_PROBLEM_1470_H
#define PROBLEMS_PROBLEM_1470_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1470 : public problem {
public:
    bool test() override;

    std::vector<int> shuffle(std::vector<int>& nums, int n);
};


#endif //PROBLEMS_PROBLEM_1470_H