#ifndef PROBLEM_3169_H
#define PROBLEM_3169_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3169 : public problem {
public:
    bool test() override;

    int countDays(int days, std::vector<std::vector<int>>& meetings);
};

#endif //PROBLEM_3169_H
