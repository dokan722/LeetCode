#ifndef PROBLEM_3719_H
#define PROBLEM_3719_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3719 : public problem {
public:
    bool test() override;

    int longestBalanced(std::vector<int>& nums);
};

#endif //PROBLEM_3719_H
