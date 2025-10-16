#ifndef PROBLEM_2598_H
#define PROBLEM_2598_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2598 : public problem {
public:
    bool test() override;

    int findSmallestInteger(std::vector<int>& nums, int value);
};



#endif //PROBLEM_2598_H
