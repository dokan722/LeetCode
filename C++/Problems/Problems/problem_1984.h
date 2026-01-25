#ifndef PROBLEM_1984_H
#define PROBLEM_1984_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1984 : public problem {
public:
    bool test() override;

    int minimumDifference(std::vector<int>& nums, int k);
};

#endif //PROBLEM_1984_H
