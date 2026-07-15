#ifndef PROBLEM_1465_H
#define PROBLEM_1465_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1465 : public problem {
public:
    bool test() override;

    int maxArea(int h, int w, std::vector<int>& horizontalCuts, std::vector<int>& verticalCuts);
};

#endif //PROBLEM_1465_H
