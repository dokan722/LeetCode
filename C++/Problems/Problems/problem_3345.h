#ifndef PROBLEM_3345_H
#define PROBLEM_3345_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3345 : public problem {
public:
    bool test() override;

    int smallestNumber(int n, int t);
};

#endif //PROBLEM_3345_H
