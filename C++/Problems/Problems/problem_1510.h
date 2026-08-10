#ifndef PROBLEM_1510_H
#define PROBLEM_1510_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_1510 : public problem {
public:
    bool test() override;

    bool winnerSquareGame(int n);
private:
    bool canWin(std::vector<int>& dp, int n);
};

#endif //PROBLEM_1510_H
