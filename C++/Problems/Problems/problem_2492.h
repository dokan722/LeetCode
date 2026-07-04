#ifndef PROBLEM_2492_H
#define PROBLEM_2492_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_2492 : public problem {
public:
    bool test() override;

    int minScore(int n, std::vector<std::vector<int>>& roads);
};

#endif //PROBLEM_2492_H
