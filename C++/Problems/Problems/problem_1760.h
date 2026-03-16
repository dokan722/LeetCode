#ifndef PROBLEMS_PROBLEM_1760_H
#define PROBLEMS_PROBLEM_1760_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1760 : public problem {
public:
    bool test() override;

    int minimumSize(std::vector<int>& nums, int maxOperations);
};

#endif //PROBLEMS_PROBLEM_1760_H