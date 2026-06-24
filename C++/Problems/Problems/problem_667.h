#ifndef PROBLEM_667_H
#define PROBLEM_667_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_667 : public problem {
public:
    bool test() override;

    std::vector<int> constructArray(int n, int k);
};

#endif //PROBLEM_667_H
