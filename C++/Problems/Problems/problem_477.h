#ifndef PROBLEM_477_H
#define PROBLEM_477_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_477 : public problem {
public:
    bool test() override;

    int totalHammingDistance(std::vector<int>& nums);
};

#endif //PROBLEM_477_H
