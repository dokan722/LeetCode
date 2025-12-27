#ifndef PROBLEM_167_H
#define PROBLEM_167_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_167 : public problem {
public:
    bool test() override;

    std::vector<int> twoSum(std::vector<int>& numbers, int target);
};

#endif //PROBLEM_167_H
