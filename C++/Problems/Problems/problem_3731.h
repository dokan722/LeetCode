#ifndef PROBLEM_3731_H
#define PROBLEM_3731_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3731 : public problem {
public:
    bool test() override;

    std::vector<int> findMissingElements(std::vector<int>& nums);
};

#endif //PROBLEM_3731_H
