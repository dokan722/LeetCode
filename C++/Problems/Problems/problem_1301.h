#ifndef PROBLEM_1301_H
#define PROBLEM_1301_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1301 : public problem {
public:
    bool test() override;

    std::vector<int> pathsWithMaxScore(std::vector<std::string>& board);
};

#endif //PROBLEM_1301_H
