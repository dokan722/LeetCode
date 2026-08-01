#ifndef PROBLEM_3275_H
#define PROBLEM_3275_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3275 : public problem {
public:
    bool test() override;

    std::vector<int> resultsArray(std::vector<std::vector<int>>& queries, int k);
};

#endif //PROBLEM_3275_H
