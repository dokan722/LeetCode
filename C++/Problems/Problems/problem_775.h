#ifndef PROBLEM_775_H
#define PROBLEM_775_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_775 : public problem {
public:
    bool test() override;

    bool isIdealPermutation(std::vector<int>& nums);
};

#endif //PROBLEM_775_H
