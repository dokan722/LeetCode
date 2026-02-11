#ifndef PROBLEM2658_H
#define PROBLEM2658_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2658 : public problem {
public:
    bool test() override;

    int findMaxFish(std::vector<std::vector<int>>& grid);
private:
    int dfs(int x, int y, std::vector<std::vector<bool>>& visited, std::vector<std::vector<int>>& grid);
};

#endif //PROBLEM2658_H
