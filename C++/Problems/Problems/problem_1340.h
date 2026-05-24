#ifndef PROBLEMS_PROBLEM_1340_H
#define PROBLEMS_PROBLEM_1340_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1340 : public problem {
public:
    bool test() override;

    int maxJumps(std::vector<int>& arr, int d);
private:
    void dfs(std::vector<int>& arr, int d, int id, int n, std::vector<int>& dp);
};

#endif //PROBLEMS_PROBLEM_1340_H