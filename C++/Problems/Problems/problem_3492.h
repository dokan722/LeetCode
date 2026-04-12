#ifndef PROBLEMS_PROBLEM_3492_H
#define PROBLEMS_PROBLEM_3492_H
#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3492 : public problem {
public:
    bool test() override;

    int maxContainers(int n, int w, int maxWeight);
};

#endif //PROBLEMS_PROBLEM_3492_H