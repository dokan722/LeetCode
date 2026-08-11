#ifndef PROBLEM_447_H
#define PROBLEM_447_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_447 : public problem {
public:
    bool test() override;

    int numberOfBoomerangs(std::vector<std::vector<int>>& points);
};

#endif //PROBLEM_447_H
