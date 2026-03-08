#ifndef PROBLEM_2587_H
#define PROBLEM_2587_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2587 : public problem {
public:
    bool test() override;

    int maxScore(std::vector<int>& nums);
};

#endif //PROBLEM_2587_H
