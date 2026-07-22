#ifndef PROBLEM_1260_H
#define PROBLEM_1260_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1260 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> shiftGrid(std::vector<std::vector<int>>& grid, int k);
private:
    void revGrid(std::vector<std::vector<int>>& grid, int l, int r, int m);
};

#endif //PROBLEM_1260_H
