#ifndef PROBLEM_1914_H
#define PROBLEM_1914_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_1914 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> rotateGrid(std::vector<std::vector<int>>& grid, int k);
private:
    std::pair<int, int> getCoords(int layerNum, int pos, int layerW, int layerH, int h, int w);
};

#endif //PROBLEM_1914_H
