#ifndef PROBLEM_2905_H
#define PROBLEM_2905_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_2905 : public problem {
public:
    bool test() override;

    std::vector<int> findIndices(std::vector<int>& nums, int indexDifference, int valueDifference);
};

#endif //PROBLEM_2905_H
