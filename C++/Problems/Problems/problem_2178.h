#ifndef PROBLEM_2178_H
#define PROBLEM_2178_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_2178 : public problem {
public:
    bool test() override;

    std::vector<long long> maximumEvenSplit(long long finalSum);
};

#endif //PROBLEM_2178_H
