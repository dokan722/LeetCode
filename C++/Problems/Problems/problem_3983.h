#ifndef PROBLEM_3983_H
#define PROBLEM_3983_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3983 : public problem {
public:
    bool test() override;

    bool canMakeSubsequence(std::string s, std::string t);
};

#endif //PROBLEM_3983_H
