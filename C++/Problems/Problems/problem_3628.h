#ifndef PROBLEM_3628_H
#define PROBLEM_3628_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3628 : public problem {
public:
    bool test() override;

    long long numOfSubsequences(std::string s);
};

#endif //PROBLEM_3628_H
