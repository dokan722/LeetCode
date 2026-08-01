#ifndef PROBLEM_3951_H
#define PROBLEM_3951_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3951 : public problem {
public:
    bool test() override;

    long long minEnergy(int n, int brightness, std::vector<std::vector<int>>& intervals);
};

#endif //PROBLEM_3951_H
