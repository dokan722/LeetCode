#ifndef PROBLEM_1679_H
#define PROBLEM_1679_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1679 : public problem {
public:
    bool test() override;

    int maxOperations(std::vector<int>& nums, int k);
};

#endif //PROBLEM_1679_H
