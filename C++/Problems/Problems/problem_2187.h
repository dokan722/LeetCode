#ifndef PROBLEM_2187_H
#define PROBLEM_2187_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_2187 : public problem {
public:
    bool test() override;

    long long minimumTime(std::vector<int>& time, int totalTrips);
};

#endif //PROBLEM_2187_H
