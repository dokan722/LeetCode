#ifndef PROBLEM_1310_H
#define PROBLEM_1310_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_1310 : public problem {
public:
    bool test() override;

    std::vector<int> xorQueries(std::vector<int>& arr, std::vector<std::vector<int>>& queries);
};

#endif //PROBLEM_1310_H
