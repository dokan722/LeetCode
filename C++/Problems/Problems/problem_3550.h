#ifndef PROBLEM_3550_H
#define PROBLEM_3550_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3550 : public problem {
public:
    bool test() override;

    int smallestIndex(std::vector<int>& nums);
};

#endif //PROBLEM_3550_H
