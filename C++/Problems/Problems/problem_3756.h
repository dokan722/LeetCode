#ifndef PROBLEM_3756_H
#define PROBLEM_3756_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3756 : public problem {
public:
    bool test() override;

    std::vector<int> sumAndMultiply(std::string s, std::vector<std::vector<int>>& queries);
};

#endif //PROBLEM_3756_H
