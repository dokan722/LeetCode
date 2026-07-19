#ifndef PROBLEM_2611_H
#define PROBLEM_2611_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_2611 : public problem {
public:
    bool test() override;

    int miceAndCheese(std::vector<int>& reward1, std::vector<int>& reward2, int k);
};

#endif //PROBLEM_2611_H
