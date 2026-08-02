#ifndef PROBLEM_4001_H
#define PROBLEM_4001_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_4001 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> aggregateTimeSeries(std::vector<std::vector<int>>& series1, std::vector<std::vector<int>>& series2);
};

#endif //PROBLEM_4001_H
