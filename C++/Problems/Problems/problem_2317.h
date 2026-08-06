#ifndef PROBLEM_2317_H
#define PROBLEM_2317_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_2317 : public problem {
public:
    bool test() override;

    int maximumXOR(std::vector<int>& nums);
};

#endif //PROBLEM_2317_H
