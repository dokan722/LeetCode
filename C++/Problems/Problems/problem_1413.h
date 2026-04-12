#ifndef PROBLEMS_PROBLEM_1413_H
#define PROBLEMS_PROBLEM_1413_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1413 : public problem {
public:
    bool test() override;

    int minStartValue(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_1413_H