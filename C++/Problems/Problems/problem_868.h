#ifndef PROBLEMS_PROBLEM_868_H
#define PROBLEMS_PROBLEM_868_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_868 : public problem {
public:
    bool test() override;

    int binaryGap(int n);
};

#endif //PROBLEMS_PROBLEM_868_H