#ifndef PROBLEM_3653_H
#define PROBLEM_3653_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3653 : public problem {
public:
    bool test() override;

    int xorAfterQueries(std::vector<int>& nums, std::vector<std::vector<int>>& queries);
};

#endif //PROBLEM_3653_H
