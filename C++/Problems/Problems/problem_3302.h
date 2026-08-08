#ifndef PROBLEM_3302_H
#define PROBLEM_3302_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3302 : public problem {
public:
    bool test() override;

    std::vector<int> validSequence(std::string word1, std::string word2);
};

#endif //PROBLEM_3302_H
