#ifndef PROBLEMS_PROBLEM_1291_H
#define PROBLEMS_PROBLEM_1291_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1291 : public problem {
public:
    bool test() override;

    std::vector<int> sequentialDigits(int low, int high);
};

#endif //PROBLEMS_PROBLEM_1291_H