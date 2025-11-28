#ifndef PROBLEM_2872_H
#define PROBLEM_2872_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2872 : public problem {
public:
    bool test() override;

    int maxKDivisibleComponents(int n, std::vector<std::vector<int>>& edges, std::vector<int>& values, int k);
private:
    int count = 0;
    int dfs(int e, int prev, std::vector<std::vector<int>>& graph, std::vector<int>& values, int k);
};



#endif //PROBLEM_2872_H
