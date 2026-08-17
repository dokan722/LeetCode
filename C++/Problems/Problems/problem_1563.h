#ifndef PROBLEMS_PROBLEM_1563_H
#define PROBLEMS_PROBLEM_1563_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1563 : public problem {
public:
    bool test() override;

    int stoneGameV(std::vector<int>& stoneValue);
private:
    int gameDp(std::vector<std::vector<int>>& dp, std::vector<int>& pref, std::vector<int>& arr, int l, int r);
};
#endif //PROBLEMS_PROBLEM_1563_H