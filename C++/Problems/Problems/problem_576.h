#ifndef PROBLEM_576_H
#define PROBLEM_576_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_576 : public problem {
public:
    bool test() override;

    int findPaths(int m, int n, int maxMove, int startRow, int startColumn);
};

#endif //PROBLEM_576_H
