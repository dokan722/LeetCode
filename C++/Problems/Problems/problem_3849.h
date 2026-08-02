#ifndef PROBLEM_3849_H
#define PROBLEM_3849_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3849 : public problem {
public:
    bool test() override;

    std::string maximumXor(std::string s, std::string t);
};

#endif //PROBLEM_3849_H
