#ifndef PROBLEMS_PROBLEM_3096_H
#define PROBLEMS_PROBLEM_3096_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3096 : public problem {
public:
    bool test() override;

    int minimumLevels(std::vector<int>& possible);
};

#endif //PROBLEMS_PROBLEM_3096_H