#ifndef PROBLEM_1963_H
#define PROBLEM_1963_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_1963 : public problem {
public:
    bool test() override;

    int minSwaps(std::string s);
};

#endif //PROBLEM_1963_H
