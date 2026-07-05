#ifndef PROBLEM_3781_H
#define PROBLEM_3781_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3781 : public problem {
public:
    bool test() override;

    long long maximumScore(std::vector<int>& nums, std::string s);
};

#endif //PROBLEM_3781_H
